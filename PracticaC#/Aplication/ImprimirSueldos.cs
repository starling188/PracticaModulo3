using PracticaC_.Entities;
using PracticaC_.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaC_.Aplication
{
    public class ImprimirSueldos : ISueldoImprimir
    {
        public void ImprimirSueldo(decimal sueldo)
        {
         
            Console.WriteLine("El sueldo es de : " + sueldo);
        }
    }
}
