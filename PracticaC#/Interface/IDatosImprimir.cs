using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaC_.Interface
{
    public interface IDatosImprimir <T> where T : class
    {
        void ImprimirInformacion(T entity);
    }
}
