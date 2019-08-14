using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class ProductionMode
    {
        public void CreateFile(int number, string fileName)
        {
            var writeFigure = new StreamWriter(fileName + ".txt", false);
            for (int i = 0; i <= number; i++)
            {
                int figure = CreateFigure();
                if (figure == 0)
                {
                    int radius = FigureSize();
                    writeFigure.WriteLine(figure + " " + radius);
                }
                else if (figure == 1)
                {
                    int side = FigureSize();
                    writeFigure.WriteLine(figure + " " + side);
                }
                else
                {
                    int side1 = FigureSize();
                    int side2 = FigureSize();
                    writeFigure.WriteLine(figure + " " + side1 + " " + side2);
                }
            }
            writeFigure.Close();
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
