using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie1();
            //Zadanie2();
            Zadanie3();
            //Zadanie4();
            //Zadanie5();
            //Zadanie6();
            //Zadanie7();
            //Zadanie8();
            
            

        }

        public static void Zadanie1()
        {
            double[] factors = { 2.4, 1.9, -0.5 };
            double x = 2.3;

            if (factors.Length == 3 )
            {
                Console.WriteLine(Math.Pow(x, 2)* factors[0] + x * factors[1] + factors[2]);
            }
            else if (factors.Length < 3)
            {
                Console.WriteLine("Nie można obliczyć równania, nie ma wszystkich współczynników.");
            }
            else
            {
                Console.WriteLine("Podano zbyt dużą ilość współczynników");
            }
        }

        public static void Zadanie2()
        {
            double[] arr = { 12.5, 6.7, 2.89, 19.1, 2.45 };

            for (int i = arr.Length -1; i>=0; --i)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void Zadanie3()
        {
            int suma = 0;
            Console.Write("Podaj liczbę całkowitą: ");
            while (int.TryParse(Console.ReadLine(), out int value))
            {
                Console.Write("Podaj liczbę całkowitą: ");
                suma += value;
            }
            Console.WriteLine();
            Console.WriteLine($"Suma = {suma}");

        }

        public static void Zadanie4()
        {
            double[,] arr = { { 1.1, 3.5, 2.56 }, { 1.4, 34, 7, }, { 1.5, 56, 2.6 } };
            double b = 4.1;

            foreach (var number in arr)
            {
                if (number>b)
                {
                    Console.WriteLine(number);
                }
            }
        }

        public static void Zadanie5()
        {
            do
            {
                Console.WriteLine("Podaj liczbę: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number > 0)
                    {
                        for (int y = 0; y < number; ++y)
                        {
                            Console.WriteLine();
                            for (int x = 0; x <= y; ++x)
                            {
                                Console.Write("#");
                            }
                        }
                        Console.WriteLine();
                        break;

                    } 
                    else if (number == 0)
                    {
                        Console.WriteLine("Podano prawidłową liczbę całkowitą ale trójkąt nie zostanie narysowany (nie istnieje trójkąt o boku 0)");
                    }
                    else
                    {
                        Console.WriteLine("Podano liczbę ujemną!");
                    }
                }
                else
                {
                    Console.WriteLine("Nie wpisałeś liczby całkowitej!");
                }
            }
            while (true);
        }

        public static void Zadanie6()
        {
            Console.Write("Podaj długość tablicy: ");
            int n = int.Parse(Console.ReadLine());

            double[] val = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Podaj wartość: ");
                double values = double.Parse(Console.ReadLine());
                val[i] = values;
            }

            Console.WriteLine();

            for (int i = n - 1; i >= 0; i -= 2)
            {
                Console.WriteLine(val[i]);
            }
        }

        public static void Zadanie7()
        {
            Console.Write("Podaj szerokość :");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Podaj wysokość :");
            int m = int.Parse(Console.ReadLine());

            char[,] tablica = new char[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 || j == 0 || i == n - 1 || j == m - 1)
                    {
                        tablica[i, j] = '#';
                    }
                    else
                    {
                        tablica[i, j] = ' ';
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(tablica[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void Zadanie8()
        {
            long n = long.Parse(Console.ReadLine());
            long x = n;

            int length = 0;
            while (n > 0) 
            {
                n /= 10;
                length++;
            }
            Console.WriteLine($"Liczba cyfr {x} to {length}");
        }
    }
}
