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
    public class SalePage : PageModel
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IWebHostEnvironment _appEnvironment;

        public SalePage(ApplicationContext applicationContext, IWebHostEnvironment appEnvironment)
        {
            _applicationContext = applicationContext;
            _appEnvironment = appEnvironment;
        }
        
        [BindProperty]
        public IEnumerable<Sale> Sales { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="Введие цену", AllowEmptyStrings = false)]
        [Range(1000, 1000000000, ErrorMessage = "Цена недвижимости не может быть меньше 1тыс руб и больше 1млрд руб")]
        [DisplayName("Цена")]
        public int PriceForSale { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage ="Выберите фото недвижимости", AllowEmptyStrings = false)]
        [DisplayName("Фото")]
        public IFormFile PhotoForSale { get; set; }

        [BindProperty]
        [Range(1, 10, ErrorMessage = "Количество комнат не может быть меньше 1 и больше 10")]
        [Required(ErrorMessage ="Введите количество комнат", AllowEmptyStrings = false)]
        [DisplayName("Количество комнат")]
        public byte NumberOfRoomsForSale { get; set; }
        
        [BindProperty]
        [StringLength(20)]
        [Required(ErrorMessage ="Введите тип недвижимости", AllowEmptyStrings = false)]
        [RegularExpression(@"^[а-яА-ЯёЁ]*", ErrorMessage = "Можно использовать только русские буквы")]
        [DisplayName("Тип недвижимости")]
        public string TypeOfImmovablesForSale { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="Введите площадь недвижимости", AllowEmptyStrings = false)]
        [Range(10, 1000, ErrorMessage = "Площадь недвижимости не может быть меньше 10м^2 и больше 1000м^2")]
        [DisplayName("Площадь недвижимости")]
        public string RoomAreaForSale { get; set; }
        
        [BindProperty]
        [StringLength(20)]
        [RegularExpression(@"^[а-яА-ЯёЁ]+([ -]*)+[ а-яА-ЯёЁ]+$", 
            ErrorMessage = "Можно использовать только русские буквы, пробел и дефис")]
        [Required(ErrorMessage ="Введите город", AllowEmptyStrings = false)]
        [DisplayName("Город")]
        public string CityForSale { get; set; }
        
        [BindProperty]
        [StringLength(20)]
        [RegularExpression(@"^[а-яА-ЯёЁ]+([ -]*)+[ а-яА-ЯёЁ]+$", 
            ErrorMessage = "Можно использовать только русские буквы, пробел и дефис")]
        [Required(ErrorMessage ="Введите улицу", AllowEmptyStrings = false)]
        [DisplayName("Улица")]
        public string StreetForSale { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage ="Введите номер дома", AllowEmptyStrings = false)]
        [Range(1, 1000, ErrorMessage = "Введите допустимый номер дома")]
        [DisplayName("Дом")]
        public int HouseForSale { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage ="Введите корпус дома", AllowEmptyStrings = false)]
        [Range(0, 100, ErrorMessage = "Введите допустимый корпус дома")]
        [DisplayName("Корпус")]
        public byte BuildingForSale { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage ="Введите номер квартиры", AllowEmptyStrings = false)]
        [Range(1, 10000, ErrorMessage = "Введите допустимый номер квартиры")]
        [DisplayName("Квартира")]
        public int ApartmentForSale { get; set; }
        
        public User User { get; set; }

        private static List<string> ExtensionList = new() { "png", "jpg", "jpeg", "jfif" };

        public void OnGet()
        {
            var user = HttpContext.Items["user"] as User;
            User = user;
            Sales = _applicationContext.Sales.Where(u => u.User == user).Include(s => s.Immovable)
                .Include(c => c.User).Take(2);
        }
        
        public IActionResult OnGetMoreImmovablesForSale(int skip, int take)
        {
            if (skip < 0 || take < 0) return null;
            if (HttpContext.Items["user"] is User user) 
                return ViewComponent("ImmovablesForSale", new {userId = user.Id, skip, take});
            return null;
        }
        
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (!ExtensionList.Contains(PhotoForSale.FileName.Split(".")[1]))
                {
                    ModelState.AddModelError("Photo", "Загрузите фото другого расширения");
                    return Page();
                }
                
                if (PhotoForSale != null)
                {
                    string path = "/Images/" + PhotoForSale.FileName;
                    using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        PhotoForSale.CopyTo(fileStream);
                    }
                    
                    var immovableForSale = new Immovable
                    {
                        City = CityForSale,
                        Street = StreetForSale,
                        House = HouseForSale,
                        Building = BuildingForSale,
                        Apartment = ApartmentForSale,
                        NumberOfRooms = NumberOfRoomsForSale,
                        TypeOfImmovable = TypeOfImmovablesForSale,
                        RoomArea = RoomAreaForSale,
                        Photo = path
                    };
                    
                    var user = HttpContext.Items["user"] as User;
                    var newSale = new Models.Sale
                    {
                        User = user,
                        Immovable = immovableForSale,
                        Price = PriceForSale,
                        PostingDate = DateTime.Today
                    };
                    
                    _applicationContext.Add(newSale);
                    _applicationContext.Add(immovableForSale);
                    _applicationContext.SaveChanges();
                }
            }
            return RedirectToPage();
        }
        
        public IActionResult OnPostDelete(int id)
        {
            Sales = _applicationContext.Sales.Include(s => s.Immovable).ToList();
            var deleteSale = _applicationContext.Sales.Find(id);
            if (deleteSale != null)
            {
                _applicationContext.Sales.Remove(deleteSale);
                _applicationContext.SaveChanges();
            }
            return RedirectToPage();
        }
    }
}