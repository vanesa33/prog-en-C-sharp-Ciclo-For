using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclo_For
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre =("learnwtutorials");

            foreach (char letra in nombre)
            {
                Console.Write(" " + letra + " ");
            
            }

            Console.ReadKey();

        }
    }
}
