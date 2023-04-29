using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sem.Models;

namespace Sem.Pages
{
    public class Registration : PageModel
    {
        private ApplicationContext _applicationContext;

        public Registration(ApplicationContext applicationContext) => _applicationContext = applicationContext;

        public void OnGet()
        {
        }
        
        [BindProperty]
        [Required(ErrorMessage ="Введите Email", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage ="Пожалуйста, введите действительный адрес электронной почты.")]
        [DisplayName("Email")]
        public string EmailAddress { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage ="Введите пароль", AllowEmptyStrings = false)]
        [StringLength(39, MinimumLength = 10, ErrorMessage = "Пароль должен содержать не менее 10 символов")]
        [RegularExpression(@"^(\w|-|\?|!|.)*", ErrorMessage = "Можно использовать только английские буквы и специальные знаки")]
        [DisplayName("Пароль")]
        public string Password { get; set; }
        
        [BindProperty]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [StringLength(39, MinimumLength = 10, ErrorMessage = "Пароль должен содержать не менее 10 символов")]
        [DisplayName("Повторите пароль")]
        public string ConfirmPassword { get; set; }
        
        [BindProperty] 
        public bool IsBank { get; set; }
        
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                var user = new User()
                {
                    Email = EmailAddress,
                    HashedPassword = Hash(Password),
                    Status = IsBank ? Status.Bank : Status.DefaultUser
                };
                
                _applicationContext.Users.Add(user);
                _applicationContext.SaveChanges();
            }
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