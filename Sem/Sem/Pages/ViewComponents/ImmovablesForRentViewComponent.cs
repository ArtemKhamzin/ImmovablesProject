using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sem.Models;

namespace Sem.Pages.ViewComponents
{
    public class ImmovablesForRentViewComponent : ViewComponent
    {
        private readonly ApplicationContext _applicationContext;

        public ImmovablesForRentViewComponent(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public IViewComponentResult Invoke(int userId, int skip, int take)
        {
            var sales = _applicationContext.Rents
                .Include(s => s.Immovable)
                .Where(u => u.User.Id == userId)
                .Skip(skip)
                .Take(take);
            return View(sales);
        }
    }
}