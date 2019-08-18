using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class AnalysisMode
    {
        public List<FigureResults> FiguresList = new List<FigureResults>();
        public int circle = 0;
        public int triangle = 0;
        public int rectangle = 0;
        public List<FigureResults> GetFigures(string fileName)
        {
            using (var readFigure = new StreamReader(fileName + ".txt"))
            {
                string line = null;
                while ((line = readFigure.ReadLine()) != null)
                {
                    var figure = Array.ConvertAll(line.Split(), int.Parse);
                    if (figure[0] == 0)
                    {
                        FiguresList.Add(new FigureResults() { Name = "Circle", Area = GetCircleArea(figure[1]), Perimeter = GetCirclePerimeter(figure[1]) });
                        circle++;
                    }
                    else if (figure[0] == 1)
                    {
                        FiguresList.Add(new FigureResults() { Name = "Triangle", Area = GetTriangleArea(figure[1]), Perimeter = GetTrianglePerimeter(figure[1]) });
                        triangle++;
                    }
                    else
                    {
                        FiguresList.Add(new FigureResults() { Name = "Rectangle", Area = GetRectangleArea(figure[1], figure[2]), Perimeter = GetRectanglePerimeter(figure[1], figure[2]) });
                        rectangle++;
                    }
                }
                return FiguresList;
            }
        }
        private double GetCircleArea(int radius)
        {
            return radius * radius * Math.PI;
        }

        private double GetCirclePerimeter(int radius)
        {
            return radius * 2 * Math.PI;
        }

        private double GetTriangleArea(int side)
        {
            return (side * side * Math.Sqrt(3)) / 4;
        }

        private double GetTrianglePerimeter(int side)
        {
            return side * 3;
        }
        private double GetRectangleArea(int side1, int side2)
        {
            return side1 * side2;
        }

        private double GetRectanglePerimeter(int side1, int side2)
        {
            return (side1 + side2) * 2;
        }

        public double GetTotalArea(int figureType)
        {
            double sumArea = 0;
            if (figureType == 1)
            {
                foreach (var item in FiguresList)
                {
                    if (item.Name == "Circle")
                    {
                        sumArea += item.Area;
                    }
                }
                return sumArea;
            }
            else if (figureType == 2)
            {
                foreach (var item in FiguresList)
                {
                    if (item.Name == "Triangle")
                    {
                        sumArea += item.Area;
                    }
                }
                return sumArea;
            }
            else
            {
                foreach (var item in FiguresList)
                {
                    if (item.Name == "Rectangle")
                    {
                        sumArea += item.Area;
                    }
                }
                return sumArea;
            }
        }

        public double GetTotalPerimeter(int figureType)
        {
            double sumPerimeter = 0;
            if (figureType == 1)
            {
                foreach (var item in FiguresList)
                {
                    if (item.Name == "Circle")
                    {
                        sumPerimeter += item.Perimeter;
                    }
                }
                return sumPerimeter;
            }
            else if (figureType == 2)
            {
                foreach (var item in FiguresList)
                {
                    if (item.Name == "Triangle")
                    {
                        sumPerimeter += item.Perimeter;
                    }
                }
                return sumPerimeter;
            }
            else
            {
                foreach (var item in FiguresList)
                {
                    if (item.Name == "Rectangle")
                    {
                        sumPerimeter += item.Perimeter;
                    }
                }
                return sumPerimeter;
            }
        }
    }
}
