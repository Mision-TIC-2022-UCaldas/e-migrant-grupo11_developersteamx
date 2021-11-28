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
    public class FormColaboradorModel : PageModel
    {
       private readonly RepositorioColaboradores repositoriocolaborador;
       [BindProperty]
        public Colaborador Colaborador {get;set;}

        public FormColaboradorModel(RepositorioColaboradores repositoriocolaborador)
       {
            this.repositoriocolaborador=repositoriocolaborador;
       }

        public IActionResult OnGet(string  colaboradorId)
        {
            //Colaborador=repositoriocolaborador.GetColaboradorWithId(colaboradorId);
            Colaborador = repositoriocolaborador.GetWithQuery(colaboradorId);
                return Page();     
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
         
            Colaborador = repositoriocolaborador.Update(Colaborador);
            
            return RedirectToPage("/Index");
        }




    }
}

