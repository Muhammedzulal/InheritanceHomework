using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHomework
{
    public class Shapes2D : Shapes
    {
        //Alan-(Çevre)
        //üçgen, daire, dikdörtgen 

        public virtual double CalculatePerimeter()
        {
            return 0.0;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Bu bir 2D şekil.");
        }
    }

    //
    //Daire
    //
    public class  Circle:Shapes2D
    {
        public int radius { get; set; }
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void GetInfo()
        {
            Console.WriteLine("Bu bir Daire.");
        }

        public override double CalculatePerimeter()//Çevre
        {
            return 2*Math.PI * radius;
        }

        public override double CalculateArea()//Alan
        {
            return Math.PI*Math.Pow(radius,2);
        }
    }

    //
    //Üçgen
    //
    public class Triangle : Shapes2D
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int height { get; set; }
        public int baseVal { get; set; }
        public Triangle(int a, int b, int c, int height, int baseVal)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.height = height;
            this.baseVal = baseVal;
        }

        public override void GetInfo()
        {
            Console.WriteLine("Bu bir Üçgen.");
        }

        public override double CalculatePerimeter()//Çevre
        {
            return a + b + c;
        }
        public override double CalculateArea()//Alan
        {
            return (baseVal*height)/2;
        }
    }

    //
    //Dikdörtgen
    //
    public class Rectangle : Shapes2D
    {
        public int height { get; set; }
        public int width { get; set; }
        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public override void GetInfo()
        {
            Console.WriteLine("Bu bir Dikdörtgen.");
        }

        public override double CalculatePerimeter()//Çevre
        {
            return 2 * (height + width);
        }
        public override double CalculateArea()//Alan
        {
            return height*width;
        }
    }
}
