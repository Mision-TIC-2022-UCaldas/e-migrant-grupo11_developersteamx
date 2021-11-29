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
    public class FormArticuloModel : PageModel
    {
       private readonly RepositorioArticulo repositorioarticulo;
       [BindProperty]
        public Articulo Articulo{get;set;}

        public FormArticuloModel(RepositorioArticulo repositorioarticulo)
       {
            this.repositorioarticulo=repositorioarticulo;
       }

        public IActionResult OnGet(string  articuloId)
        {
            //Migrante=repositoriomigrantes.GetMigranteWithId(migranteId);
            Articulo = repositorioarticulo.GetWithQuery(articuloId);
                return Page();     
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
         
            Articulo = repositorioarticulo.Create(Articulo);
            
            return RedirectToPage("/Index");
        }

    }
}