using System;
using System.Collections.Generic;
using System.Text;
using DemoEF_01.Dominio.EntidadesNegocio;
using DemoEF_01.Dominio.InterfacesRepositorios;

namespace AccesoDatos.EF
{
	public class RepositorioAutor : IRepositorioAutor
	{
		public bool Add(Autor nuevoAutor)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Autor> FindAll()
		{
			throw new NotImplementedException();
		}

		public Autor FindById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Autor> GetAutoresNacionalidad(string nacionalidad)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Autor> GetAutoresNombreIncluye(string textoBuscado)
		{
			throw new NotImplementedException();
		}

		public bool Remove(int id)
		{
			throw new NotImplementedException();
		}

		public bool Update(Autor autor)
		{
			throw new NotImplementedException();
		}
	}
}
