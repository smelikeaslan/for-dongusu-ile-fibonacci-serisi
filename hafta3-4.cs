using System;


namespace hafta3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Fibonacci serisi için eleman sayısı girin: ");
            int elemanSayisi = int.Parse(Console.ReadLine());

            if (elemanSayisi >= 0)
            {
                int x = 0,  y= 1, z = 1;

                if (elemanSayisi >= 0) Console.Write(x);
                if (elemanSayisi >= 1) Console.Write(" {0}", y);

                for (int i = 2; i < elemanSayisi; i++)
                {
                    z = x + y;
                    Console.Write($" {z}");
                    x = y;
                    y = z;

                }
            }

            else
            {
                Console.WriteLine("Girdiginiz sayi negatif olamaz!");
            }
            Console.ReadKey();
        }
    }
}



