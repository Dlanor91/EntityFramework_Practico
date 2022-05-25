using System;
using System.Collections.Generic;
using System.Text;
using DemoEF_01.Dominio.EntidadesNegocio;

namespace DemoEF_01.Dominio.InterfacesRepositorios
{
	public interface IRepositorioAutor
		:IRepositorio<Autor>
	{
		public IEnumerable<Autor> GetAutoresNacionalidad(string nacionalidad);
		public IEnumerable<Autor> GetAutoresNombreIncluye(string textoBuscado);

	}
}
