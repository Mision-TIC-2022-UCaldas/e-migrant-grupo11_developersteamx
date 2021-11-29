using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EMigrant.App.Persistencia.AppRepositorios;
using EMigrant.App.Dominio;

namespace EMigrant.App.Frontend.Pages
{
    public class FormMigranteModel : PageModel
    {
       private readonly RepositorioMigrantes repositoriomigrantes;
       [BindProperty]
        public Migrante Migrante{get;set;}

        public FormMigranteModel(RepositorioMigrantes repositoriomigrantes)
       {
            this.repositoriomigrantes=repositoriomigrantes;
       }

        public IActionResult OnGet(string  migranteId)
        {
            //Migrante=repositoriomigrantes.GetMigranteWithId(migranteId);
            Migrante = repositoriomigrantes.GetWithQuery(migranteId);
                return Page();     
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
         
            Migrante = repositoriomigrantes.Update(Migrante);
            
            return RedirectToPage("/Index");
        }

    }
}

