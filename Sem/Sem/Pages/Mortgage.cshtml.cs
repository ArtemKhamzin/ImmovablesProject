using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sem.Models;

namespace Sem.Pages
{
    public class Mortgage : PageModel
    {
        private readonly ApplicationContext _applicationContext;

        public IEnumerable<Models.Mortgage> Mortgages { get; set; }
        public Mortgage(ApplicationContext applicationContext) => _applicationContext = applicationContext;

        [BindProperty]
        [StringLength(30)]
        [Required(ErrorMessage ="Введите наименование банка", AllowEmptyStrings = false)]
        [DisplayName("Банк")]
        public string Bank { get; set; }
        
        [BindProperty]
        [Range(3, 30, ErrorMessage = "Ставка не может быть меньше 3% и больше 30%")]
        [Required(ErrorMessage ="Введите ипотечную ставку", AllowEmptyStrings = false)]
        [DisplayName("Ставка")]
        public int MortgageRate { get; set; }
        
        [BindProperty]
        [Range(10000, 1000000, ErrorMessage = "Ежемесячный платеж не может быть меньше 10тыс руб и больше 1млн руб")]
        [Required(ErrorMessage ="Введите ежемесячный платеж", AllowEmptyStrings = false)]
        [DisplayName("Платеж")]
        public int MonthlyPayment { get; set; }
        
        [BindProperty]
        [Range(5, 100, ErrorMessage = "Срок ипотеки не может быть меньше 5 лет и больше 100 лет")]
        [Required(ErrorMessage ="Введите срок ипотеки", AllowEmptyStrings = false)]
        [DisplayName("Срок ипотеки")]
        public byte Term { get; set; }

        public User MortgageUser { get; set; }
        
        public void OnGet()
        {
            Mortgages = _applicationContext.Mortgages;
            MortgageUser = HttpContext.Items["user"] as User;
        }
        
        public void OnPost()
        {
            Mortgages = _applicationContext.Mortgages;
            MortgageUser = HttpContext.Items["user"] as User;
            if (ModelState.IsValid)
            {
                var mortgage = new Models.Mortgage()
                {
                    User = MortgageUser,
                    Bank = Bank, 
                    MortgageRate = MortgageRate,
                    MonthlyPayment = MonthlyPayment,
                    Term = Term
                };
                
                _applicationContext.Mortgages.Add(mortgage);
                _applicationContext.SaveChanges();
            }
        }
        
        public IActionResult OnPostDeleteMortgage(int id)
        {
            Mortgages = _applicationContext.Mortgages;
            var deleteMortgage = _applicationContext.Mortgages.Find(id);
            if (deleteMortgage != null)
            {
                _applicationContext.Mortgages.Remove(deleteMortgage);
                _applicationContext.SaveChanges();
            }
            return RedirectToPage();
        }
    }
}