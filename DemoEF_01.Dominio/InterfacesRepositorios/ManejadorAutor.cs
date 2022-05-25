using DemoEF_01.Dominio.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEF_01.Dominio.InterfacesRepositorios
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
