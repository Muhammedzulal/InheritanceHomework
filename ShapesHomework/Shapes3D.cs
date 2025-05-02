using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHomework
{
    public class Shapes3D : Shapes
    {
        //Alan-(Hacim)
        //küp, silindir, küre

        public virtual double CalculateVolume()
        {
            return 0.0;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Bu bir 3D şekil.");
        }

    }

    //
    //Küp
    //
    public class Cube : Shapes3D
    {
        public int n { get; set; }
        
        public Cube(int n)
        {
            this.n = n;
        }

        public override void GetInfo()
        {
            Console.WriteLine("Bu bir Küp.");
        }

        public override double CalculateVolume()//Hacim
        {
            return Math.Pow(n,3);
        }
        public override double CalculateArea()//Alan
        {
            return 6 * Math.Pow(n, 2);
        }
    }
    //
    //Silindir
    //
    public class Cylinder : Shapes3D
    {
        public int radius { get; set; }
        public int height { get; set; }
        public Cylinder(int radius, int height)
        {
            this.radius = radius;
            this.height = height;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Bu bir Silindir.");
        }
        public override double CalculateVolume()//Hacim
        {
            int area = (int)(Math.PI * Math.Pow(radius, 2));
            return area * height;
        }
        public override double CalculateArea()//Alan
        {
            double area1 = 2 * Math.PI * Math.Pow(radius, 2);
            double area2 = 2 * Math.PI * radius * height;
            return area1 + area2;
        }
    }

    //
    //Küre
    //
    public class Sphere : Shapes3D
    {
        public int radius { get; set; }
        public Sphere(int radius)
        {
            this.radius = radius;
        }

        public override void GetInfo()
        {
            Console.WriteLine("Bu bir Küre.");
        }

        public override double CalculateVolume()//Hacim
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
        public override double CalculateArea()//Alan
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }
    }
}
