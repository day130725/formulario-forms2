using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace _126
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 D = new Class1();
            Console.WriteLine("Ingrese una frase:");
            string frase = Console.ReadLine().ToLower();
            string resultado = D.IntercambiarAxE(frase);
            Console.WriteLine(resultado);
        }
    }
}
