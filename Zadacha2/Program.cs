using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of figures: ");
            var number = VerifyNumber();

            Console.WriteLine("Enter the name of the file: ");
            var fileName = Convert.ToString(Console.ReadLine());
            Console.WriteLine(new string('_', 60) + "\n");

            var production = new ProductionMode();
            production.CreateFile(number, fileName);

            var analysis = new AnalysisMode();
            var figuresList = analysis.GetFigures(fileName);
            foreach (var figure in figuresList)
            {
                Console.WriteLine("Figure {0}: area is {1}, perimeter is {2}", figure.Name, figure.Area, figure.Perimeter);
            }
            Console.WriteLine("  Total: circles:    {0} \n \t triangles:  {1} \n\t rectangles: {2}", analysis.circle, analysis.triangle, analysis.rectangle);
            Console.WriteLine(new string('_', 60));

            Console.WriteLine("\nChoose the number of figure type to see total information:\n   1. Circle \n   2. Triangle \n   3. Rectangle \n");
            var figureType = VerifyType();
            Console.WriteLine("Total area is:      {0}", analysis.GetTotalArea(figureType));
            Console.WriteLine("Total perimeter is: {0}", analysis.GetTotalPerimeter(figureType));

            Console.ReadKey();
        }

        static private int VerifyNumber()
        {
            var number = 0;
            while (number <= 0)
            {
                int.TryParse(Console.ReadLine(), out number);
                if (number <= 0)
                {
                    Console.WriteLine("You entered the wrong symbol. The number must be greater than zero!\nEnter another number:");
                }
            }
            return number;
        }

        static private int VerifyType()
        {
            var figureType = 0;
            while (figureType < 1 || figureType > 3)
            {
                int.TryParse(Console.ReadLine(), out figureType);
                if (figureType < 1 || figureType > 3)
                {
                    Console.WriteLine("Wrong number! Enter 1, 2 or 3!");
                }
            }
            return figureType;
        }
    }
}
