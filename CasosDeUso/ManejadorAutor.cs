
using AccesoDatos.EF;
using DemoEF_01.Dominio.EntidadesNegocio;
using DemoEF_01.Dominio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasosDeUso
{
    public class ManejadorAutor : IManejadorAutor
    {
        public IRepositorioAutor RepoAutor { get; set; }

        public ManejadorAutor(IRepositorioAutor repoAutor)
        {
            RepoAutor=repoAutor;
        }       

        public bool NuevoActor(Autor autor)
        {
            return RepoAutor.Add(autor);
        }
    }
}
