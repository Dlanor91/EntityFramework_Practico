using DemoEF_01.Dominio.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasosDeUso
{
    public interface IManejadorAutor
    {
        public bool NuevoActor(Autor autor);
    }
}
