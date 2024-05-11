using PracticaC_.Entities;
using PracticaC_.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaC_.Aplication
{
    public class ImprimirDatosEmpleado : IDatosImprimir<Empleado>
    {
        public void ImprimirInformacion(Empleado empleado)
        {
            Console.WriteLine("Nombre : " + empleado.Nombre);
            Console.WriteLine("Su edad es : " + empleado.Edad);

        }
    }
}
