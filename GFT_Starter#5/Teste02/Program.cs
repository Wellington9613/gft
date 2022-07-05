using System;
using System.Globalization;
namespace Teste02
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p = new Aluno();
            double media;
            Console.WriteLine("Diga sua matricula:");

            p.Matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 01:");
            p.Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 02:");
            p.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 03:");
            p.Nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite Sua frequencia");
            p.Frequencia = int.Parse(Console.ReadLine());
            media = (p.Nota1 + p.Nota2 + p.Nota3) / 3;
            Aluno p1 = new Aluno();
            Console.WriteLine("Diga sua matricula:");

            p1.Matricula = int.Parse(Console.ReadLine());
            while (p1.Matricula == p.Matricula)
            {
                System.Console.WriteLine("Matricula ja existente");
                Console.WriteLine("Diga sua matricula:");
            }
            Console.WriteLine("Digite nota 01:");
            p1.Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 02:");
            p1.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 03:");
            p1.Nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite Sua frequencia");
            p1.Frequencia = int.Parse(Console.ReadLine());
            double media1 = (p1.Nota1 + p1.Nota2 + p1.Nota3) / 3;

            Aluno p2 = new Aluno();
            Console.WriteLine("Diga sua matricula:");
            p2.Matricula = int.Parse(Console.ReadLine());
            while (p1.Matricula == p2.Matricula && p2.Matricula == p.Matricula)
            {
                System.Console.WriteLine("Matricula ja existente");
                Console.WriteLine("Diga sua matricula:");
            }



            Console.WriteLine("Digite nota 01:");
            p2.Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 02:");
            p2.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 03:");
            p2.Nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite Sua frequencia");
            p2.Frequencia = int.Parse(Console.ReadLine());
            double media2 = (p2.Nota1 + p2.Nota2 + p2.Nota3) / 3;
            if (media >= media2 && media >= media1)
            {
                System.Console.WriteLine();
            }



        }
    }
}