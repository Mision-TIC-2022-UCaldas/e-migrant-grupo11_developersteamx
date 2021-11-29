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
    public class ListArticuloModel : PageModel
    {
       
        private readonly RepositorioArticulo repositorioarticulo;
        public IEnumerable<Articulo> Articulo {get;set;}

    public ListArticuloModel(RepositorioArticulo repositorioarticulo)
    {
        this.repositorioarticulo=repositorioarticulo;
     }

    public void OnGet()
    {
        Articulo=repositorioarticulo.GetAll();
    }
    }
}
