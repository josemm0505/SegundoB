using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLSegundoB
{
    public class OMB
    {
        private float num1, num2;

        public float Num1 { get => num1; set => num1 = value; }
        public float Num2 { get => num2; set => num2 = value; }

        public float suma() { return Num1 + Num2; }
        public float resta() { return Num1 - Num2; }
        public float multiplicar() { return Num1 * Num2; }
        public float dividir() { return Num1 / Num2; }
    }
}
