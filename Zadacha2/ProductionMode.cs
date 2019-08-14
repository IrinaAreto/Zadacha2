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
        private int _figure;
        private int _size1, _size2;
        public void CreateFile(int number, string fileName)
        {
            var writeFigure = new StreamWriter(fileName + ".txt", false);
            for (int i = 0; i <= number; i++)
            {
                _figure = CreateFigure();
                FigureSize();
                if (_figure == 2)
                {
                    writeFigure.WriteLine(_figure + " " + _size1 + " " + _size2);
                }
                else
                {
                    writeFigure.WriteLine(_figure + " " + _size1);
                }
            }
            writeFigure.Close();
        }
        private int CreateFigure()
        {
            var rand = new Random();
            return rand.Next(0, 3);
        }

        private void FigureSize()
        {
            var rand = new Random();
            if (_figure == 0)
            {
                _size1 = rand.Next(1, 101);
            }
            else if (_figure == 1)
            {
                _size1 = rand.Next(1, 101);
            }
            else
            {
                _size1 = rand.Next(1, 101);
                _size2 = rand.Next(1, 101);
            }
        }
    }
}
