using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sem.Models;

namespace Sem.Pages
{
    public class Authorization : PageModel
    {
        private readonly ApplicationContext _applicationContext;

        public Authorization(ApplicationContext applicationContext) => _applicationContext = applicationContext;

        public void OnGet()
        {
        }
        
        [BindProperty]
        [DisplayName("Запомнить меня")]
        public bool IsRememberedMe { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage ="Введите Email", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage ="Пожалуйста, введите действительный адрес электронной почты.")]
        [DisplayName("Email")]
        public string EmailAddress { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage ="Введите пароль", AllowEmptyStrings = false)]
        [StringLength(39, MinimumLength = 10, ErrorMessage = "Пароль должен содержать не менее 10 символов")]
        [DisplayName("Пароль")]
        public string Password { get; set; }
        
        public IActionResult OnPost()
        {
            var user = _applicationContext.Users.FirstOrDefault(a => a.Email == EmailAddress);

            if (user != null && IsRememberedMe)
            {
                Response.Cookies.Append("token", HttpContext.Session.Id, 
                    new CookieOptions(){Expires = DateTimeOffset.Now.AddDays(365)
                });
                var session = new CookieToken()
                {
                    Token = HttpContext.Session.Id,
                    User = user
                };
                _applicationContext.Add(session);
                _applicationContext.SaveChanges();

                return RedirectToPage("Index");
            }
            
            if (user != null)
            {
                if (Hash(Password) == user.HashedPassword)
                {
                    HttpContext.Session.SetString("email", user.Email);
                    return RedirectToPage("Index");
                }

                ModelState.AddModelError("","Неверный пароль");
            }
            else ModelState.AddModelError("","Неверный email или пароль");
            
            return Page();
        }
        
        private string Hash(string password)
        {
            var hash = Encoding.ASCII.GetBytes(password);
            var md5 = new MD5CryptoServiceProvider();
            var hashenc = md5.ComputeHash(hash);
            return hashenc.Aggregate("", (current, b) => current + b.ToString("x2"));
        }
    }
}