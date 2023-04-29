using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Sem.Models;

namespace Sem.Middlewares
{
    public class Cookie
    {
        public readonly RequestDelegate Next;
        
        public Cookie(RequestDelegate next)
        {
            Next = next;
        }

        public async Task InvokeAsync(HttpContext context, ApplicationContext _applicationContext)
        {
            var token = context.Request.Cookies["token"];
            if (token is null)
            {
                var email = context.Session.GetString("email");
                if (email is not null)
                {
                    var user = await _applicationContext.Users.FirstOrDefaultAsync(a => a.Email == email);
                    if (user is not null) context.Items.Add("user", user);
                }
            }
            else
            {
                var cookieToken = await _applicationContext.CookieTokens.Include(a => a.User)
                    .FirstOrDefaultAsync(a => a.Token == token);
                if (cookieToken is not null) context.Items.Add("user", cookieToken.User);
            }
            
            await Next.Invoke(context);
        }
    }
}