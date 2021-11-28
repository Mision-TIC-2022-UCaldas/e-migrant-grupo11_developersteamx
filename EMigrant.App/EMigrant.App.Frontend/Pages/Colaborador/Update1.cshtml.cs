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
    public class NuevoColaboradorModel : PageModel
    {
       private readonly RepositorioColaboradores repositoriocolaboradores;
       [BindProperty]
        public Colaborador Colaborador{get;set;}

        public NuevoColaboradorModel(RepositorioColaboradores repositoriocolaboradores)
       {
            this.repositoriocolaboradores=repositoriocolaboradores;
       }

        public IActionResult OnGet(string  colaboradorId)
        {
            //Colaborador=repositoriocolaborador.GetColaboradorWithId(colaboradorId);
            Colaborador = repositoriocolaboradores.GetWithQuery(colaboradorId);
                return Page();     
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
         
            Colaborador = repositoriocolaboradores.Create(Colaborador);
            
            return RedirectToPage("/Index");
        }




    }
}

