using DemoEF_01.Dominio.EntidadesNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos.EF
{
    public class LibreriaContext: DbContext
    {
        public DbSet<Autor> Autores { get; set; }

        public LibreriaContext(DbContextOptions<LibreriaContext> opciones) : base(opciones)
        {
        }
    }
}
