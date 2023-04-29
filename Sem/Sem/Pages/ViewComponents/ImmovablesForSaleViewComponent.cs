using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sem.Models;

namespace Sem.Pages.ViewComponents
{
    public class ImmovablesForSaleViewComponent : ViewComponent
    {
        private readonly ApplicationContext _applicationContext;

        public ImmovablesForSaleViewComponent(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public IViewComponentResult Invoke(int userId, int skip, int take)
        {
            var sales = _applicationContext.Sales
                .Include(s => s.Immovable)
                .Where(u => u.User.Id == userId)
                .Skip(skip)
                .Take(take);
            return View(sales);
        }
    }
}