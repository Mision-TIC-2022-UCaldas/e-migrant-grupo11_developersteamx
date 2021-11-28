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
    public class DetColaboradorModel : PageModel
    {
       private readonly RepositorioColaboradores repositoriocolaboradores;
       [BindProperty]
        public Colaborador Colaborador{get;set;}

        public DetColaboradorModel(RepositorioColaboradores repositoriocolaboradores)
       {
            this.repositoriocolaboradores=repositoriocolaboradores;
       }

        public IActionResult OnGet(string  colaboradorId)
        {
            //Migrante=repositoriomigrantes.GetMigranteWithId(migranteId);
            Colaborador = repositoriocolaboradores.GetWithQuery(colaboradorId);
                return Page();     
        }
        




    }
}