using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnPersona
{
    internal class ClsPersona
    {
        //Declaracion de variables
        private string nombre { get; set; }
        private int edad { get; set; }

        //Metodos
        public void CargarDatos()
        {
            Console.WriteLine("Digite su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite su edad");
            edad = int.Parse(Console.ReadLine());

        }

        public void MostrarDatos()
        {
            Console.WriteLine(nombre + " " + "su edad es" + " " + edad + " " + "años");

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
        }
    }
}
