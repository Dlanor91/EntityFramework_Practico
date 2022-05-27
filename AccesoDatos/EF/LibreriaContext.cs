using DemoEF_01.Dominio.EntidadesNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos.EF
{
    public class LibreriaContext: DbContext //para cualquier proveedor, nosotros instalamos el sql server para ese contexto
    {
        public DbSet<Autor> Autores { get; set; }//para cada entidad que maneje hay un dbset

        public LibreriaContext(DbContextOptions<LibreriaContext> opciones) : base(opciones) //aqui configuro el sistema para que inyecte al context
        {
        }
    }
}
