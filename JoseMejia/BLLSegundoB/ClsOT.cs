using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLSegundoB
{
    public class ClsOT
    {
        public double areacirculo(double r)
        {
            double Pi = 3.1416;
            //return (Pi * Math.Pow(r, 2);            
            return (Pi*(r*r));
        }
        public double areatriangulo (double Base, double Altura)
        {
            return (Base*Altura)/2;
        }
        public double arearectangulo (double Base, double Altura)
        {
            return (Base*Altura);
        }
    }
}
