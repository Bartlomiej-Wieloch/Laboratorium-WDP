namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie1();
            //Zadanie2();
            //Zadanie3();
            //Zadanie4();
            Zadanie5();
        }

        static void Zadanie1()
        {
            Console.WriteLine("Zadanie 1\n");
            decimal balans = 56;
            bool isCreditCardValid = false;
            decimal price = 45;
            bool canPay = balans >= price && isCreditCardValid;

            Console.WriteLine(canPay);
        }

        static void Zadanie2()
        {
            Console.WriteLine("\nZadanie 2\n");

            double a = 5;
            double b = 1;
            double c = 3;
            bool isTriangle = (a + b) > c && (a + c) > b && (b + c) > a;

            Console.WriteLine(isTriangle);
        }

        static void Zadanie3()
        {
            Console.WriteLine("\nZadanie 3\n");

            double cx = 2.56;
            double cy = 4.6;
            double cradius = 5;
            double x = 6.4;
            double y = 2.234;
            bool isOutside = Math.Sqrt(Math.Pow(x - cx, 2) + Math.Pow(y - cy, 2)) > cradius;

            Console.WriteLine(isOutside);
        }

        static void Zadanie4()
        {
            Console.WriteLine("\nZadanie 4\n");

            int rx = 56;
            int ry = 34;
            int width = 23;
            int height = 12;
            int x = 79;
            int y = 22;
            bool isOnBorder = (x == rx || x == rx + width) && (y == ry || y == ry - height);

            Console.WriteLine(isOnBorder);
        }

        public static void Zadanie5()
        {
            Console.WriteLine("\nZadanie 5\n");

            double x = 1.34;
            double a = 1;
            double b = 2;
            double c = 1;

            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta > 0)
            {
                double deltaRoot = Math.Sqrt(delta);

                double x1 = (-b - deltaRoot) / 2 * a;
                double x2 = (-b + deltaRoot) / 2 * a;

                Console.WriteLine($"x1= {x1}, x2= {x2}");
            }
            if (delta == 0)
            {
                double x1 = (-b) / 2 * a;
                Console.WriteLine($"x1,x2= {x1}");
            }
            if (delta < 0)
            {
                Console.WriteLine("Nie można otrzymać pierwiastków rzeczywistych!");
            }

        }
    }
}
