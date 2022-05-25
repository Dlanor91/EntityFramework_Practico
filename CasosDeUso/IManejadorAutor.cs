using DemoEF_01.Dominio.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEF_01.Dominio.InterfacesRepositorios
{
    public interface IManejadorAutor
    {
        public bool NuevoActor(Autor autor);
    }
}
