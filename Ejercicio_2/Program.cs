using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            Double R, b, h;
            Console.WriteLine("Bienvenido, vamos a encontrar el área de su triángulo. Para comenzar: ");
            Console.WriteLine("Escriba la base de su tríangulo: ");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ahora, escriba la altura de su triángulo");
            h = Double.Parse(Console.ReadLine());
            R = (b * h) / 2;
            Console.WriteLine("\nEl área de su triángulo es: " + R);
            Console.ReadKey();
        }
    }
        }
    
