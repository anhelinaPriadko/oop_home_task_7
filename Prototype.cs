using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            IFigure figure = new Rectangle(10, 20);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle(15);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Triangle(40, 80);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.Read();
        }
    }

    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
    class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }
        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }
        public void GetInfo()
        {
            Console.WriteLine("Прямокутник з довжиною {0} і шириною {1}", height, width);
        }
    }

    class Triangle : IFigure
    {
        int side;
        int height;
        public Triangle(int s, int h)
        {
            side = s;
            height = h;
        }
        public IFigure Clone()
        {
            return new Triangle(this.side, this.height);
        }
        public void GetInfo()
        {
            Console.WriteLine("Трикутник зі стороною {0} і висотою {1}", side, height);
        }
    }

    class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }
        public IFigure Clone()
        {
            return new Circle(this.radius);
        }
        public void GetInfo()
        {
            Console.WriteLine("Коло з радіусом {0}", radius);
        }
    }
}
