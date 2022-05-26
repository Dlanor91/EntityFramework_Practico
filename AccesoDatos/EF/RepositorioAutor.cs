using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoEF_01.Dominio.EntidadesNegocio;
using DemoEF_01.Dominio.InterfacesRepositorios;

namespace AccesoDatos.EF
{
	public class RepositorioAutor : IRepositorioAutor
	{
        public LibreriaContext Contexto { get; set; }

        public RepositorioAutor(LibreriaContext ctx)
        {
            Contexto=ctx;
        }

        public bool Add(Autor nuevoAutor)
		{
			Contexto.Autores.Add(nuevoAutor);
			return Contexto.SaveChanges() >=1;
		}

		public IEnumerable<Autor> FindAll()
		{
			return Contexto.Autores.ToList();
		}

		public Autor FindById(int id)
		{
			return Contexto.Autores.Find(id);
		}

		public IEnumerable<Autor> GetAutoresNacionalidad(string nacionalidad)
		{
			return Contexto.Autores.Where(autor => autor.Nacionalidad == nacionalidad).ToList();
		}

		public IEnumerable<Autor> GetAutoresNombreIncluye(string textoBuscado)
		{
			return Contexto.Autores.Where(autor => autor.Nombre.Contains(textoBuscado)).ToList();
		}

		public bool Remove(int id)
		{
			Contexto.Autores.Remove(new Autor() { Id = id});
			return Contexto.SaveChanges() >=1;
		}

		public bool Update(Autor autor)
		{
			Contexto.Autores.Update(autor);
			return Contexto.SaveChanges()>=1;
		}
	}
}
