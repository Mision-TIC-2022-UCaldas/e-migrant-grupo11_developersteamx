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
    public class NucleofModel : PageModel
    {
        private readonly RepositorioMigrantes repositoriomigrantes;
        public IEnumerable<Migrante> Migrantes { get; set; }
        [BindProperty]
        public Migrante migrante { get; set; }
        public NucleofModel(RepositorioMigrantes repositoriomigrantes)
        {
            this.repositoriomigrantes = repositoriomigrantes;
        }
        
        public void OnGet()
        {
            Migrantes = repositoriomigrantes.GetVarios("");
        }
        /*public IActionResult OnPost()
        {
        //repositoriomigrantes.GetMigranteWithcc(27);
            //return Page();
        }
        /*return RedirectToPage("./List");
        }*/


    }
}
