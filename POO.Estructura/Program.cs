using POO.Estructura.Enties;
using POO.Estructura.Service;
using System;

namespace POO.Estructura
{
    public class Program
    {
        static void Main(string[] args)
        {
            AlmunoService service = new AlmunoService();
            Alumnos alumno1 =  service.Agregar();           
            Console.WriteLine("Hello world");
            service.Imprimir(alumno1);

            Console.WriteLine("La calificacion es " + service.validarProm(alumno1.Promedio));

            Console.WriteLine("");

        }
    }
}
