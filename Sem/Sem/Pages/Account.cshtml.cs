using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Session;
using Sem.Models;

namespace Sem.Pages
{
    public class Account : PageModel
    {
        private ApplicationContext _applicationContext;

        public Account(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostExit()
        {
            HttpContext.Session.Clear();
            HttpContext.Response.Cookies.Delete("token");
            var token = Request.Cookies["token"];
            var cookieTokenForDelete = _applicationContext.CookieTokens.FirstOrDefault(cookieToken => cookieToken.Token == token);
            if (cookieTokenForDelete != null)
            {
                _applicationContext.CookieTokens.Remove(cookieTokenForDelete);
                _applicationContext.SaveChanges();
            }
            return RedirectToPage("Authorization");
        }
    }
}