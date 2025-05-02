using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHomework
{
    public class Shapes
    {
        //Her şekil için ortak olan özellikler burada tanımlanır.
        //Örneğin, tüm şekillerin bir alanı vardır.

        public virtual double CalculateArea()
        {
            return 0;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Bu bir şekil.");
        }
    }
    public class  Point: Shapes
    {
        //Noktanın alanı hacmi çevresi yoktur.
        public override void GetInfo()
        {
            Console.WriteLine("Bu bir Nokta.");
        }
    }
}
