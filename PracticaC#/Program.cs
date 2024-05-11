
using PracticaC_.Aplication;
using PracticaC_.Entities;
using PracticaC_.Interface;

class Program
{
    static void Main(string[] args)
    {

        Persona persona = new Persona { 
        
            Nombre = "Oscar",
            Edad = 24
        };

        Empleado empleado = new Empleado
        {

            Nombre = "Rafael",
            Edad = 27,
            Sueldo = 80000m
        };

        decimal sueldo = empleado.Sueldo;
       

        IDatosImprimir<Persona> imprimir = new ImprimirDatosPersona();
        ISueldoImprimir sueldoImprimir = new ImprimirSueldos();
        IDatosImprimir<Empleado> imprimirEm = new ImprimirDatosEmpleado();

        Console.WriteLine("====Persona======");
        imprimir.ImprimirInformacion(persona);
        Console.WriteLine("\n");

        Console.WriteLine("=======Empleado======");
        imprimirEm.ImprimirInformacion(empleado);

        sueldoImprimir.ImprimirSueldo(sueldo);









    }
}