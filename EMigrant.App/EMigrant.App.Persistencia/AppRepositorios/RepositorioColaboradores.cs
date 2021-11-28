using System.Collections;
using System.Collections.Generic;
using EMigrant.App.Dominio;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
//using System.Linq.IQueryable;

namespace EMigrant.App.Persistencia.AppRepositorios
{    public class RepositorioColaboradores 
    {
        List<Colaborador> colaboradores;
        private readonly AppContext _appContext =  new AppContext();  

        public IEnumerable<Colaborador> GetAll()
        {
            return _appContext.Colaboradores;
        }
        
    public Colaborador GetWithQuery(string id){           
       return _appContext.Colaboradores.Where(p => p.email == id).FirstOrDefault();
        
    }
    
       public  Colaborador GetColaboradorWithId(int id){
            return _appContext.Colaboradores.Find(id);   
        }
        public Colaborador Create(Colaborador newColaborador)
        {
            var addColaborador = _appContext.Colaboradores.Add(newColaborador);
            _appContext.SaveChanges();
            return addColaborador.Entity;

        }

       public Colaborador Update(Colaborador newColaborador){
            var colaborador = _appContext.Colaboradores.Find(newColaborador.id);
            if(colaborador != null){
                
                colaborador.razonsocial = newColaborador.razonsocial;
                colaborador.nit = newColaborador.nit;
                colaborador.direcion = newColaborador.direcion;
                colaborador.ciudad = newColaborador.ciudad;
                colaborador.telefono = newColaborador.telefono;
                colaborador.email = newColaborador.email;
                colaborador.paginaweb = newColaborador.paginaweb;
                colaborador.sector = newColaborador.sector;
                colaborador.servicio = newColaborador.servicio;
                
                
                
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return colaborador;
        }
    }
}
