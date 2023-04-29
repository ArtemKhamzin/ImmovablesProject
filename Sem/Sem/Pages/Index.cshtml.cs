using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sem.Models;

namespace Sem.Pages
{
    public class IndexModel : PageModel
    {
        private  ApplicationContext _applicationContext { get; set; }

        public IndexModel(ApplicationContext applicationContext) => _applicationContext = applicationContext;

        [BindProperty]
        public IEnumerable<Models.Rent> Rents { get; set; }
        
        [BindProperty]
        public IEnumerable<Sale> Sales { get; set; }
        
        public User AdminUser { get; set; }

        public void OnGet()
        {
            Sales = _applicationContext.Sales.Include(s => s.Immovable)
                .Include(c => c.User).ToList();
            Rents = _applicationContext.Rents.Include(s => s.Immovable)
                .Include(c => c.User).ToList();
            AdminUser = HttpContext.Items["user"] as User;
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
            return RedirectToPage();
        }
        
        public IActionResult OnPostDeleteRent(int id)
        {
            Rents = _applicationContext.Rents.Include(s => s.Immovable).ToList();
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