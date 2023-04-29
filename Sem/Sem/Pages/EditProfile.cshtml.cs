using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sem.Models;

namespace Sem.Pages
{
    public class EditProfile : PageModel
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IWebHostEnvironment _appEnvironment;
        
        public EditProfile(ApplicationContext applicationContext, IWebHostEnvironment appEnvironment)
        {
            _applicationContext = applicationContext;
            _appEnvironment = appEnvironment;
        }

        [BindProperty]
        public User User { get; set; }
        
        [BindProperty]
        [StringLength(30)]
        [RegularExpression(@"^[а-яА-ЯёЁ]*", 
            ErrorMessage = "Имя может содержать только русские буквы")]
        [Required(ErrorMessage ="Введите новое имя", AllowEmptyStrings = false)]
        [DisplayName("Имя")]
        public string NewName { get; set; }
        
        [BindProperty]
        [StringLength(30)]
        [RegularExpression(@"^[а-яА-ЯёЁ]*", 
            ErrorMessage = "Фамилия может содержать только русские буквы")]
        [Required(ErrorMessage ="Введите новую фамилию", AllowEmptyStrings = false)]
        [DisplayName("Фамилия")]
        public string NewSurname { get; set; }

        [BindProperty]
        [StringLength(20)]
        [RegularExpression(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$", 
            ErrorMessage = "Введите действительный номер телефона")]
        [Required(ErrorMessage ="Введите новый номер телефона", AllowEmptyStrings = false)]
        [DisplayName("Номер телефона")]
        public string NewPhoneNumber { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage ="Выберите новое фото профиля", AllowEmptyStrings = false)]
        [DisplayName("Фото профиля")]
        public IFormFile NewPhoto { get; set; }
        
        public void OnGet()
        {
            User = HttpContext.Items["user"] as User;
        }
        
        public IActionResult OnPost()
        {
            string path = "/Images/" + NewPhoto.FileName;
            using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
            {
                NewPhoto.CopyTo(fileStream);
            }
            
            var user = HttpContext.Items["user"] as User;
            if ((user != null) & (NewPhoto != null))
            {
                user.Name = NewName;
                user.Surname = NewSurname;
                user.PhoneNumber = NewPhoneNumber;
                user.Photo = path;
                _applicationContext.Users.Update(user);
            }

            _applicationContext.SaveChanges();
            return RedirectToPage();
        }
    }
}