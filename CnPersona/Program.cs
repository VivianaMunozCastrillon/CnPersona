using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnPersona
{
    internal class Program
    {
        /// <summary>
        /// Nombre:Viviana Muñoz
        /// Fecha:26/02/2023
        /// Descripcion:Este programa solicita el nombre y edad de una persona y muestra los datos ingresados y si es mayor de edad.
        /// </summary>
        static void Main(string[] args)
        {
            //Instancia de clase
            ClsPersona persona = new ClsPersona();


            //llamada de metodos
            persona.CargarDatos();
            persona.MostrarDatos();



            Console.ReadKey();
        }


    }
}
