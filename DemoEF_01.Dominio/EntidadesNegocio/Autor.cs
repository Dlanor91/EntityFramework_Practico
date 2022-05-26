using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DemoEF_01.Dominio.EntidadesNegocio
{
	/// <summary>
	/// Entidad POCO (Plain Old CLR Object)
	/// </summary>
	[Table("Autor")]
	public class Autor:InterfacesEntidades.IValidable, IEquatable<Autor>
	{
		#region Properties
		[MaxLength(20)][Required, Display(Name = "Nombre de Autor")]
		public string Nombre { get; set; }
		[MaxLength(20)]
		public string Nacionalidad { get; set; }
		[Key]
		public int Id { get ; set ; }


		#endregion
		#region Implementación de interfaces de las Entidades
		public bool Validar()
		{
			return !string.IsNullOrEmpty(Nombre) 
				&& !string.IsNullOrEmpty(Nacionalidad);
		}
		#endregion
		#region Métodos básicos

		public bool Equals([AllowNull] Autor other)
		{
			if (other ==null)
				return false;
			return other.Nombre.ToUpper().Trim()
				.Equals(this.Nombre.ToUpper().Trim());
		}
		public override string ToString()
		{
			return $"({Id}) {Nombre} - {Nacionalidad}";
		}
		#endregion
	}
}
