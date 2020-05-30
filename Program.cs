using System;
/*
Área (A):
https://wikimedia.org/api/rest_v1/media/math/render/svg/bde3239088f69abf01f5c3f487b18d4fd3ae4505

//√(p(p-a)(p-b)(p-c))

Semiperímetro (p): metade da soma dos lados
https://wikimedia.org/api/rest_v1/media/math/render/svg/08ed8a6e351198e0c4ca8d71fa2e2bc4171e9439

Digite os lados do triângulo desejado.

Lado 1..: 3
Lado 2..: 25
Lado 3..: 26

Semiperímetro..: 27
Área...........: 36

*/
namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoUm, ladoDois, ladoTres, semiPerimetro, area;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Digite os lados do triângulo desejado.\n");

            Console.Write("Lado 1..: ");
            ladoUm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 2..: ");
            ladoDois = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 3..: ");
            ladoTres = Convert.ToDouble(Console.ReadLine());

            semiPerimetro = (ladoUm + ladoDois + ladoTres) / 2;
            area = Math.Sqrt(
                    semiPerimetro 
                    * (semiPerimetro - ladoUm) 
                    * (semiPerimetro - ladoDois) 
                    * (semiPerimetro - ladoTres)
            );

            Console.WriteLine($"\nSemiperímetro..: {semiPerimetro:N0}");
            Console.WriteLine($"Área...........: {area:N0}");

            Console.ResetColor();

        }
    }
}
