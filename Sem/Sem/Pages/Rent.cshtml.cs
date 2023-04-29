using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sem.Models;

namespace Sem.Pages
{
    public class Rent : PageModel
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IWebHostEnvironment _appEnvironment;
        
        public Rent(ApplicationContext applicationContext, IWebHostEnvironment appEnvironment)
        {
            _applicationContext = applicationContext;
            _appEnvironment = appEnvironment;
        }

        public IEnumerable<Models.Rent> Rents { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="Введие цену", AllowEmptyStrings = false)]
        [Range(1000, 1000000, ErrorMessage = "Цена за аренду не может быть меньше 1тыс руб и больше 1млн руб")]
        [DisplayName("Цена")]
        public int PriceForRent { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage ="Выберите фото недвижимости", AllowEmptyStrings = false)]
        [DisplayName("Фото")]
        public IFormFile PhotoForRent { get; set; }

        [BindProperty]
        [Range(1, 10, ErrorMessage = "Количество комнат не может быть меньше 1 и больше 10")]
        [Required(ErrorMessage ="Введите количество комнат", AllowEmptyStrings = false)]
        [DisplayName("Количество комнат")]
        public byte NumberOfRoomsForRent { get; set; }
        
        [BindProperty]
        [StringLength(20)]
        [Required(ErrorMessage ="Введите тип недвижимости", AllowEmptyStrings = false)]
        [RegularExpression(@"^[а-яА-ЯёЁ]*", ErrorMessage = "Можно использовать только русские буквы")]
        [DisplayName("Тип недвижимости")]
        public string TypeOfImmovablesForRent { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage ="Введите площадь недвижимости", AllowEmptyStrings = false)]
        [Range(10, 1000, ErrorMessage = "Площадь недвижимости не может быть меньше 10м^2 и больше 1000м^2")]
        [DisplayName("Площадь недвижимости")]
        public string RoomAreaForRent { get; set; }
        
        [BindProperty]
        [StringLength(20)]
        [RegularExpression(@"^[а-яА-ЯёЁ]+([ -]*)+[ а-яА-ЯёЁ]+$", 
            ErrorMessage = "Можно использовать только русские буквы, пробел и дефис")]
        [Required(ErrorMessage ="Введите город", AllowEmptyStrings = false)]
        [DisplayName("Город")]
        public string CityForRent { get; set; }
        
        [BindProperty]
        [StringLength(20)]
        [RegularExpression(@"^[а-яА-ЯёЁ]+([ -]*)+[ а-яА-ЯёЁ]+$", 
            ErrorMessage = "Можно использовать только русские буквы, пробел и дефис")]
        [Required(ErrorMessage ="Введите улицу", AllowEmptyStrings = false)]
        [DisplayName("Улица")]
        public string StreetForRent { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage ="Введите номер дома", AllowEmptyStrings = false)]
        [Range(1, 1000, ErrorMessage = "Введите допустимый номер дома")]
        [DisplayName("Дом")]
        public int HouseForRent { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage ="Введите корпус дома", AllowEmptyStrings = false)]
        [Range(0, 100, ErrorMessage = "Введите допустимый корпус дома")]
        [DisplayName("Корпус")]
        public byte BuildingForRent { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage ="Введите номер квартиры", AllowEmptyStrings = false)]
        [Range(1, 10000, ErrorMessage = "Введите допустимый номер квартиры")]
        [DisplayName("Квартира")]
        public int ApartmentForRent { get; set; }
        
        public User User { get; set; }
        
        private static List<string> ExtensionList = new()
        {
            "png", "jpg", "jpeg", "jfif"
        };
        
        public void OnGet()
        {
            var user = HttpContext.Items["user"] as User;
            User = user;
            Rents = _applicationContext.Rents.Where(u => u.User == user).Include(s => s.Immovable)
                .Include(c => c.User).Take(2);
        }
        
        public IActionResult OnGetMoreImmovablesForRent(int skip, int take)
        {
            if (skip < 0 || take < 0) return null;
            if (HttpContext.Items["user"] is User user) 
                return ViewComponent("ImmovablesForRent", new {userId = user.Id, skip, take});
            return null;
        }
        
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (PhotoForRent.Length / 8 / 1024 / 1024 > 20)
                {
                    ModelState.AddModelError("Photo", "Размер фото не должен превышать 20 Мб");
                    return Page();
                }
                
                if (!ExtensionList.Contains(PhotoForRent.FileName.Split(".")[1]))
                {
                    ModelState.AddModelError("Photo", "Загрузите фото другого расширения");
                    return Page();
                }
                
                if (PhotoForRent != null)
                {
                    string path = "/Images/" + PhotoForRent.FileName;
                    using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        PhotoForRent.CopyTo(fileStream);
                    }
                    
                    var immovableForRent = new Immovable()
                    {
                        City = CityForRent,
                        Street = StreetForRent,
                        House = HouseForRent,
                        Building = BuildingForRent,
                        Apartment = ApartmentForRent,
                        NumberOfRooms = NumberOfRoomsForRent,
                        TypeOfImmovable = TypeOfImmovablesForRent,
                        RoomArea = RoomAreaForRent,
                        Photo = path
                    };
                    var user = HttpContext.Items["user"] as User;
                    var newRent = new Models.Rent()
                    {
                        User = user,
                        Immovable = immovableForRent,
                        Price = PriceForRent,
                        PostingDate = DateTime.Today
                    };
                
                    _applicationContext.Add(immovableForRent);
                    _applicationContext.Add(newRent);
                    _applicationContext.SaveChanges();
                }
            }
            return RedirectToPage();
        }
        
        public IActionResult OnPostDelete(int id)
        {
            Rents = _applicationContext.Rents.Include(r => r.Immovable).ToList();
            var deleteRent = _applicationContext.Rents.Find(id);
            if (deleteRent != null)
            {
                _applicationContext.Rents.Remove(deleteRent);
                _applicationContext.SaveChanges();
            }
            return RedirectToPage();
        }
    }
}