namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Zadanie1();
             Zadanie2();
             Zadanie3();
             Zadanie4();
             Zadanie5();
             Zadanie6();
        }

        /*
         * oblicz wartości trzech zmiennych cyfraSetek, cyfraDziesiatek i cyfraJedności zakładając, 
         * że w zmiennej number jest liczba mniejsza od 1000. 
         */
        public static void Zadanie1()
        {
            Console.WriteLine("Zadanie 1\n");

            int number = 837;
            int cyfraSetek = number / 100;
            //Console.WriteLine(cyfraSetek);
            int cyfraDziesiątek = (number - (cyfraSetek * 100)) / 10;
            //Console.WriteLine(cyfraDziesiątek);
            int cyfraJedności = number - (cyfraSetek * 100) - (cyfraDziesiątek * 10);
            //Console.WriteLine(cyfraJedności);

            Console.WriteLine($"Cyfra setek: {cyfraSetek}\nCyfra dziesiątek: {cyfraDziesiątek}\nCyfra jedności: {cyfraJedności}");
        }

        /*
        * wstaw wyrażenie, który do zmiennej sinValue przypisze wartość funkcji sinus na podstawie kąta w stopniach ze zmiennej degree. Wartość zmiennej sinValue wyświetl w konsoli
        */
        public static void Zadanie2()
        {
            Console.WriteLine("\nZadanie 2\n");

            double degree = 60;
            double radians = degree * (Math.PI / 180);
            double sinValue = Math.Sin(radians);

            Console.WriteLine($"Wartość funkcji sinus: {sinValue}");
        }

        /*
         * wpisz wyrażenie, które do zmiennej radius przypisze wartość promienia koła, którego pole powierzchni znajduje się w zmiennej area. Jeśli w zmiennej area jest liczba ujemna to promień powinien wynosić 0.
         */
        public static void Zadanie3()
        {
            Console.WriteLine("\nZadanie 3\n");

            double area = -189;
            if (area >= 0)
            {
                double radius = Math.Sqrt(area / Math.PI); //R=pierwiastek(Pole/PI)
                Console.WriteLine($"Promień okręgu o polu {area}, wynosi {radius} ");
            }
            else
            {
                double radius = 0;
                Console.WriteLine($"Promień okręgu o polu {area}, wynosi {radius} ");
            }
        }

        /*
         * wstaw wyrażenie przypisujące do zmiennej y wartość równania kwadratowego o współczynnikach w zmiennych a, b i c. Obliczoną zmienną wyświetl w konsoli. 
         */
        public static void Zadanie4()
        {
            Console.WriteLine("\nZadanie 4\n");

            double x = 0.45;
            double a = 1.5;
            double b = 3.2;
            double c = 4;
            double y = a * Math.Pow(x, 2) + b * x + c;

            Console.WriteLine(y);
        }

        /*
         * Przypisz do zmiennej max, największa wartość spośród zmiennych a, b i c, a do zmiennej min najmniejszą. Wyświetl obie zmiennej wg wzoru:
         * Max = 9
         * Min = 2
         */
        public static void Zadanie5()
        {
            Console.WriteLine("\nZadanie 5\n");

            int a = 9;
            int b = 6;
            int c = 2;
            int max = Math.Max(a, Math.Max(b, c));
            int min = Math.Min(a, Math.Min(b, c));

            Console.WriteLine($"Max = {max}\nMin = {min}");

        }
        /*
         * W zmiennej time znajduje się czas w minutach. Oblicz wartości zmiennych hours, minutes i seconds na postawie zmiennej time. Wyświetl obliczone wartości wg poniższego wzoru: <hours>:<minutes>:<seconds> 
         */
        public static void Zadanie6()
        {
            Console.WriteLine("\nZadanie 6\n");


            double time = 1234.45; // czas w minutach
            int hours = (int)time / 60;
            int minutes = (int)time - hours * 60;
            double fractinalSeconds = time - (int)time;
            int seconds = (int)fractinalSeconds * 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
