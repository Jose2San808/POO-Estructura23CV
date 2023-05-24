using POO.Estructura.Enties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Estructura.Service
{
    public class AlmunoService
    {
        //responside 
        public Alumnos Agregar()
        {
            try
            {
                Alumnos res = new Alumnos()
                {
                    Id = 1,
                    Nombre = "jose ",
                    Apellido = "san pedro ",
                    FechaIngreso = DateTime.Now,
                    Grado = 3,
                    Promedio = 8,
                };
                return res;
            }
            catch (Exception ex)
            {

                throw new Exception("Sucede un error " + ex.Message);
            }
        }

        public void Imprimir(Alumnos request)
        {
            try
            {
                Console.WriteLine("Nombre ; "+ request.Nombre);
                Console.WriteLine("Apellido is; "+ request.Apellido);
                Console.WriteLine("El dia de ingreso es "+ request.FechaIngreso);
                Console.WriteLine("Grado "+ request.Grado);
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedio un error " + ex.Message);
            }
        }
        public bool validarProm(double num1)
        {
            bool validar = false; 
            if (num1 > 7)
            {
                validar = true;
            }
            return validar;
        }
    }
}