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
    public class AboutImmovable : PageModel
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IWebHostEnvironment _appEnvironment;

        public AboutImmovable(ApplicationContext applicationContext, IWebHostEnvironment appEnvironment)
        {
            _applicationContext = applicationContext;
            _appEnvironment = appEnvironment;
        }

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
        [Required(ErrorMessage ="Выберите фото планировки", AllowEmptyStrings = false)]
        [DisplayName("Планировка")]
        public IFormFile Scheme { get; set; }
        
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

        private static List<string> ExtensionList = new() { "png", "jpg", "jpeg", "jfif" };
        
        public IEnumerable<Sale> Sales { get; set; }
        
        public IEnumerable<Models.Rent> Rents { get; set; }
        
        public Sale SaleDetails { get; set; }
        
        public Models.Rent RentDetails { get; set; }
        
        public User AdminUser { get; set; }

        public void OnGet(int id)
        {
            var user = HttpContext.Items["user"] as User;
            AdminUser = user;
            Sales = _applicationContext.Sales.Include(s => s.Immovable)
                .Include(c => c.User).ToList();
            Rents = _applicationContext.Rents.Include(s => s.Immovable)
                .Include(c => c.User).ToList();
            SaleDetails = _applicationContext.Sales.Find(id);
            RentDetails = _applicationContext.Rents.Find(id);
        }
        
        public IActionResult OnPostDeleteSale(int id)
        {
            Sales = _applicationContext.Sales.Include(s => s.Immovable).ToList();
            var deleteSale = _applicationContext.Sales.Find(id);
            if (deleteSale != null)
            {
                _applicationContext.Sales.Remove(deleteSale);
                _applicationContext.SaveChanges();
            }
            return RedirectToPage("Index");
        }
        
        public IActionResult OnPostDeleteRent(int id)
        {
            Rents = _applicationContext.Rents.Include(r => r.Immovable).ToList();
            var deleteRent = _applicationContext.Rents.Find(id);
            if (deleteRent != null)
            {
                _applicationContext.Rents.Remove(deleteRent);
                _applicationContext.SaveChanges();
            }
            return RedirectToPage("Index");
        }
        
        public IActionResult OnPostEditSale(int id)
        {
            Sales = _applicationContext.Sales.Include(s => s.Immovable).ToList();
            var editSale = _applicationContext.Sales.Find(id);
            
            if (PhotoForSale != null && PhotoForSale.Length / 8 / 1024 / 1024 > 20)
            {
                ModelState.AddModelError("Photo", "Размер фото не должен превышать 20 Мб");
                return Page();
            }
                
            if (PhotoForSale != null && !ExtensionList.Contains(PhotoForSale.FileName.Split(".")[1]))
            {
                ModelState.AddModelError("Photo", "Загрузите фото другого расширения");
                return Page();
            }
            
            var path = "/Images/" + PhotoForSale?.FileName;
            using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
            {
                PhotoForSale?.CopyTo(fileStream);
            }
            
            var pathScheme = "/Images/Scheme/" + Scheme.FileName;
            using (var fileStream = new FileStream(_appEnvironment.WebRootPath + pathScheme, FileMode.Create))
            {
                Scheme.CopyTo(fileStream);
            }
            
            if ((editSale != null) & (PhotoForSale != null))
            {
                editSale.Price = PriceForSale;
                editSale.Immovable.Apartment = ApartmentForSale;
                editSale.Immovable.Building = BuildingForSale;
                editSale.Immovable.City = CityForSale;
                editSale.Immovable.House = HouseForSale;
                editSale.Immovable.Street = StreetForSale;
                editSale.Immovable.RoomArea = RoomAreaForSale;
                editSale.Immovable.NumberOfRooms = NumberOfRoomsForSale;
                editSale.Immovable.TypeOfImmovable = TypeOfImmovablesForSale;
                editSale.Immovable.Photo = path;
                editSale.Immovable.SchemeImage = pathScheme;
                _applicationContext.Sales.Update(editSale);
            }
            _applicationContext.SaveChanges();
            
            return RedirectToPage();
        }
        
        public IActionResult OnPostEditRent(int id)
        {
            Rents = _applicationContext.Rents.Include(r => r.Immovable).ToList();
            var editRent = _applicationContext.Rents.Find(id);
            
            if (PhotoForSale.Length / 8 / 1024 / 1024 > 20)
            {
                ModelState.AddModelError("Photo", "Размер фото не должен превышать 20 Мб");
                return Page();
            }
                
            if (!ExtensionList.Contains(PhotoForSale.FileName.Split(".")[1]))
            {
                ModelState.AddModelError("Photo", "Загрузите фото другого расширения");
                return Page();
            }
            
            string path = "/Images/" + PhotoForSale.FileName;
            using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
            {
                PhotoForSale.CopyTo(fileStream);
            }
            
            string pathScheme = "/Images/Scheme/" + Scheme.FileName;
            using (var fileStream = new FileStream(_appEnvironment.WebRootPath + pathScheme, FileMode.Create))
            {
                Scheme.CopyTo(fileStream);
            }
            
            if ((editRent != null) & (PhotoForSale != null))
            {
                editRent.Price = PriceForSale;
                editRent.Immovable.Apartment = ApartmentForSale;
                editRent.Immovable.Building = BuildingForSale;
                editRent.Immovable.City = CityForSale;
                editRent.Immovable.House = HouseForSale;
                editRent.Immovable.Street = StreetForSale;
                editRent.Immovable.RoomArea = RoomAreaForSale;
                editRent.Immovable.NumberOfRooms = NumberOfRoomsForSale;
                editRent.Immovable.TypeOfImmovable = TypeOfImmovablesForSale;
                editRent.Immovable.Photo = path;
                editRent.Immovable.SchemeImage = pathScheme;
                _applicationContext.Rents.Update(editRent);
            }
            _applicationContext.SaveChanges();
            
            return RedirectToPage();
        }
    }
}