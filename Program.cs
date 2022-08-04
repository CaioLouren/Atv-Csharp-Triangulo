using ConsoleApp4.Entities;
using System;
using System.Globalization;

namespace ConsoleApp4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE O VALOR DE CADA LADO: ");
            Console.Write("LADO A: ");
            double ladoA = double.Parse(Console.ReadLine());
            Console.Write("LADO B: ");
            double ladoB = double.Parse(Console.ReadLine());
            Console.Write("LADO C: ");
            double ladoC = double.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);

            double area = triangulo.CalculoArea(triangulo);
            Console.WriteLine("A ÁREA DO TRIÂNGULO É:" + area);

        }
    }
}