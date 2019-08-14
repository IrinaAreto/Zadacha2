using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of figures: ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of the file: ");
            var fileName = Convert.ToString(Console.ReadLine());

            var production =new ProductionMode();
            production.CreateFile(number, fileName);


            Console.ReadKey();
        }
    }
}
