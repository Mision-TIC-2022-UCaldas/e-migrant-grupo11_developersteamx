using System.Collections;
using System.Collections.Generic;
using EMigrant.App.Dominio;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace EMigrant.App.Persistencia.AppRepositorios
{
    public class RepositorioArticulo
    {
        List<Articulo> articulos;
        private readonly AppContext _appContext = new AppContext();

        public IEnumerable<Articulo> GetAll()
        {
            return _appContext.Articulos;
        }
        public Articulo GetWithQuery(string id)
        {

            //return _appContext.Migrantes.Find(mail);
            return _appContext.Articulos.Where(p => p.tituloArticulo == id).FirstOrDefault();

        }
        public Articulo GetArticuloWithtitulo(string titulo)
        {

            //return _appContext.Migrantes.Find(mail);
            return _appContext.Articulos.Where(p => p.tituloArticulo == titulo).FirstOrDefault();

        }

        public IEnumerable<Articulo> GetVarios(int id)
        {
            return _appContext.Articulos.Where(x => x.id == id).ToList();
        }
        public Articulo GetArticuloWithId(string id)
        {
            return _appContext.Articulos.Find(id);

        }
        // public Articulo Create(Articulo newArticulo)
        // {
        //     var addArticulo = _appContext.Articulos.Add(newArticulo);
        //     _appContext.SaveChanges();
        //     return addArticulo.Entity;

        // }

        public Articulo Create(Articulo newArticulo)
        {
            if (articulos.Count > 0)
            {
                newArticulo.id = articulos.Max(r => r.id) + 1;
            }
            else
            {
                newArticulo.id = 1;
            }
            articulos.Add(newArticulo);
            return newArticulo;
        }


        public Articulo Update(Articulo newArticulo)
        {
            var articulo = _appContext.Articulos.Find(newArticulo.id);
            if (articulo != null)
            {

                articulo.activor = newArticulo.activor;
                articulo.tituloArticulo = newArticulo.tituloArticulo;
                articulo.fechaNovedad = newArticulo.fechaNovedad;
                articulo.diasArticulo = newArticulo.diasArticulo;
                articulo.textoArticulo = newArticulo.textoArticulo;

                //Guardar en base de datos
                _appContext.SaveChanges();
            }
            return articulo;
        }
    }
}