using System;
using System.Globalization;

namespace Estudo
{
    class calculoRetangulo
    {
        static void Main(string[] args)
        {
            double bs;
            double altura;
            double area;
            double perimetro;
            double diagonal;

            bs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = bs * altura;
            perimetro= 2* bs +2* altura;
            diagonal = Math.Sqrt(Math.Pow(bs, 2.0) + (Math.Pow(altura, 2.0)));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4",CultureInfo.InvariantCulture));


        }


    }

}