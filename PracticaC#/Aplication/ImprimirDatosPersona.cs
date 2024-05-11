using PracticaC_.Entities;
using PracticaC_.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaC_.Aplication
{
    public class ImprimirDatosPersona : IDatosImprimir<Persona>
    {
        public void ImprimirInformacion(Persona persona)
        {
            Console.WriteLine("Nombre : " + persona.Nombre);
            Console.WriteLine("Su edad es : " + persona.Edad);

        }
    }
}
