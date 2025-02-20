using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_1.Modelos
{
    internal class Categoria
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public double SueldoBase { get; set; }

        public static void hola()
        {
            Console.WriteLine("hola");
        }


        public static void eyleen()
        {
            bool eyleen_vio_a_mario = true;

            if (eyleen_vio_a_mario == true) {
                Console.WriteLine("ush");
            }
        
        public static void Adios()
        {
            Console.WriteLine("Adios");
        }
    }
}
