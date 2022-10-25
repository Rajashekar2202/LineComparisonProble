using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    public class Length
    {
        public void Distance()
        { 
            int x1 = 1, y1 = 1, x2 = 3, y2 = 3;
            double distance = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Calculate The Distance of Given Cartisian : " + distance);    
        }
    }
}
