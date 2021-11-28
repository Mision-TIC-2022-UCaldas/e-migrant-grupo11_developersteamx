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
    public class DetailsMigranteModel : PageModel
    {
       private readonly RepositorioMigrantes repositoriomigrantes;
              public Migrante Migrante{get;set;}

        public DetailsMigranteModel(RepositorioMigrantes repositoriomigrantes)
       {
            this.repositoriomigrantes=repositoriomigrantes;
       }

        public IActionResult OnGet(int migranteId)
        {
                Migrante=repositoriomigrantes.GetMigranteWithId(migranteId);
                return Page();

        }
    }
}
