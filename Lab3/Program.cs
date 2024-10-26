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
            //Zadanie5();
            //Zadanie6();

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
            int x = 23;
            int y = 11;
            bool isOnBorder = (x == rx || x == rx + width) && (y == ry || y == ry - height);

            Console.WriteLine(isOnBorder);
        }

        public static void Zadanie5()
        {
            Console.WriteLine("\nZadanie 5\n");

            double a = 2.5;
            double b = -0.5;
            double c = 1.5;

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

        public static void Zadanie6()
        {
            Console.WriteLine("\nZadanie 6\n");

            int code = 4;
            int quantity = 11;
            decimal price = 3.5m;

            if (code < 10)
            {
                decimal sellPrice = price;
                Console.WriteLine($"Price: {sellPrice}");
            }
            else if (code >= 10 && code <= 15)
            {
                decimal sellPrice = Math.Round((price * 0.95m), 2, MidpointRounding.AwayFromZero);
                Console.WriteLine($"Price: {sellPrice}");
            }
            else
            {
                if (quantity <= 10)
                {
                    decimal sellPrice = Math.Round((price * 1.05m), 2, MidpointRounding.AwayFromZero);
                    Console.WriteLine($"Price: {sellPrice}");
                }
                else if (quantity >= 11 && quantity <= 20)
                {
                    decimal sellPrice = price;
                    Console.WriteLine($"Price: {sellPrice}");
                }
                else if (quantity > 20 && quantity < 100)
                {
                    decimal wholeNumbers = quantity / 10;
                    decimal priceMultiplier = 1 - (wholeNumbers / 100);
                    decimal sellPrice = price * priceMultiplier;

                    Console.WriteLine($"price: {sellPrice}");
                }
                else if (quantity >= 100)
                {
                    decimal sellPrice = price - (price * 0.1m);
                    Console.WriteLine($"Price: {sellPrice}");
                }
            }
        }
    }
}
