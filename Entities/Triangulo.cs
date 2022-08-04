using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Entities
{
    class Triangulo
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public double CalculoArea(Triangulo triangulo)
        {
            double p = (triangulo.LadoA + triangulo.LadoB + triangulo.LadoC) / 2;
            double area = Math.Sqrt(p * (p - triangulo.LadoA) * (p - triangulo.LadoB) * (p - triangulo.LadoC));
            return area;
        }
    }
}
