using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numlados;
            float medidalado, perimetro;

            Console.WriteLine("ingresa la cantidad de lados de la figura: ");
            numlados = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese medida de uno de los lados: ");
            medidalado= Single.Parse(Console.ReadLine());

            perimetro = numlados * medidalado;

            Console.WriteLine("el perimetro es: {0}", perimetro);

        }
    }
}
