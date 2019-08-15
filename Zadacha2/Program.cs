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
            if (number < 0)
            {
                throw new ArgumentException("Wrong number!");
            }
            Console.WriteLine("Enter the name of the file: ");
            var fileName = Convert.ToString(Console.ReadLine());

            var production = new ProductionMode();
            production.CreateFile(number, fileName);

            var analysis = new AnalysisMode();
            var figuresList = analysis.GetFigures(fileName);
            foreach (var figure in figuresList)
            {
                Console.WriteLine("Figure {0}: area is {1}, perimeter is {2}", figure.Name, figure.Area, figure.Perimeter);
            }
            Console.WriteLine("  Total: circles - {0} \n \t triangles - {1} \n\t rectangles - {2}", analysis.circle, analysis.triangle, analysis.rectangle);
            Console.WriteLine(new string('_', 50));

            Console.WriteLine("Choose the number of figure type to see total information:\n   1. Circle \n   2. Triangle \n   3. Rectangle ");
            var figureType = Convert.ToInt32(Console.ReadLine());
            if (figureType < 1 || figureType > 3)
            {
                throw new ArgumentException("Choose number 1, 2 or 3!");
            }
            Console.WriteLine("Total area is:  {0}", analysis.GetTotalArea(figureType));
            Console.WriteLine("Total perimeter is: {0}", analysis.GetTotalPerimeter(figureType));

            Console.ReadKey();
        }
    }
}
