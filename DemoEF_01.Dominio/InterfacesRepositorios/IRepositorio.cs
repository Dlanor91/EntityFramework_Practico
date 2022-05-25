using System;
using System.Collections.Generic;
using System.Text;
using DemoEF_01.Dominio.EntidadesNegocio;

namespace DemoEF_01.Dominio.InterfacesRepositorios
{
	public interface IRepositorio<T> where T:class
	{
		public bool Add(T nuevoAutor);
		public bool Remove(int id);
		public bool Update(T autor);
		public T FindById(int id);
		public IEnumerable<T> FindAll();

	}
}
