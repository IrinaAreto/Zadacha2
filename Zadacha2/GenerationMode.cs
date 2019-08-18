using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class GenerationMode
    {
        public void Generate(int number, string fileName)
        {
            using (var writeFigure = new StreamWriter(fileName + ".txt", false))
            {
                for (int i = 1; i <= number; i++)
                {
                    var figure = CreateFigure();
                    if (figure == 0)
                    {
                        var radius = FigureSize();
                        writeFigure.WriteLine(figure + " " + radius);
                    }
                    else if (figure == 1)
                    {
                        var side = FigureSize();
                        writeFigure.WriteLine(figure + " " + side);
                    }
                    else
                    {
                        var side1 = FigureSize();
                        var side2 = FigureSize();
                        writeFigure.WriteLine(figure + " " + side1 + " " + side2);
                    }
                }
            }
        }

        Random rand = new Random();
        private int CreateFigure()
        {
            return rand.Next(0, 3);
        }
        private int FigureSize()
        {
            return rand.Next(1, 101);
        }
    }
}
