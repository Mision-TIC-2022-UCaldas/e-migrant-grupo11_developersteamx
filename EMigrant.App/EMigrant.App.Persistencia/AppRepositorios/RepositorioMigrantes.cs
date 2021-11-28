using System.Collections;
using System.Collections.Generic;
using EMigrant.App.Dominio;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
//using System.Linq.IQueryable;

namespace EMigrant.App.Persistencia.AppRepositorios
{
    public class RepositorioMigrantes 
    {
        List<Migrante> migrantes;
        private readonly AppContext _appContext =  new AppContext();  

        public IEnumerable<Migrante> GetAll()
        {
            return _appContext.Migrantes;
        }
    public Migrante GetWithQuery(string id){

           //return _appContext.Migrantes.Find(mail);
       return _appContext.Migrantes.Where(p => p.email == id).FirstOrDefault();
        
    }
    
       public  Migrante GetMigranteWithId(int id){
            return _appContext.Migrantes.Find(id);
            
            
            
        }
        public Migrante Create(Migrante newMigrante)
        {
            var addMigrante = _appContext.Migrantes.Add(newMigrante);
            _appContext.SaveChanges();
            return addMigrante.Entity;

        }

       public Migrante Update(Migrante newMigrante){
            var migrante = _appContext.Migrantes.Find(newMigrante.id);
            if(migrante != null){
                
                migrante.activor = newMigrante.activor;
                migrante.nombres = newMigrante.nombres;
                migrante.apellidos = newMigrante.apellidos;
                migrante.tdocumento = newMigrante.tdocumento;
                migrante.nodocumento = newMigrante.nodocumento;
                migrante.paisorigen = newMigrante.paisorigen;
                migrante.fechanacimiento = newMigrante.fechanacimiento;
                migrante.email = newMigrante.email;
                migrante.telefono = newMigrante.telefono;
                migrante.direciona = newMigrante.direciona;
                migrante.ciudad = newMigrante.ciudad;
                migrante.situacionlaboral = newMigrante.situacionlaboral;
                
                
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return migrante;
        }
    }
}
