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
            //Zadanie7();
            Zadanie8();

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

        public static void Zadanie7()
        {
            int decimalNumber = 11;
            switch (decimalNumber)
            {
                case 0:
                    Console.WriteLine("Rzymianie nie znali zera!");
                    break;
                case 1:
                    Console.WriteLine("I");
                    break;
                case 2:
                    Console.WriteLine("II");
                    break;
                case 3:
                    Console.WriteLine("III");
                    break;
                case 4:
                    Console.WriteLine("IV");
                    break;
                case 5:
                    Console.WriteLine("V");
                    break;
                case 6:
                    Console.WriteLine("VI");
                    break;
                case 7:
                    Console.WriteLine("VII");
                    break;
                case 8:
                    Console.WriteLine("VIII");
                    break;
                case 9:
                    Console.WriteLine("IX");
                    break;
                case 10:
                    Console.WriteLine("X");
                    break;
                case 11:
                    Console.WriteLine("XI");
                    break;
                case 12:
                    Console.WriteLine("XII");
                    break;
                case 13:
                    Console.WriteLine("XIII");
                    break;
                case 14:
                    Console.WriteLine("XIV");
                    break;
                case 15:
                    Console.WriteLine("XV");
                    break;
                case 16:
                    Console.WriteLine("XVI");
                    break;
                case 17:
                    Console.WriteLine("XVII");
                    break;
                case 18:
                    Console.WriteLine("XVIII");
                    break;
                case 19:
                    Console.WriteLine("XIX");
                    break;
                case 20:
                    Console.WriteLine("XX");
                    break;
                default:
                    Console.WriteLine("Nie obsługuję liczb spoza zakresu od 1 do 20!");
                    break;
            }
        }

        public static void Zadanie8()
        {
            char hex = 'F';
            switch (hex)
            {
                case '0':
                    Console.WriteLine("0");
                    break;
                case '1':
                    Console.WriteLine("1");
                    break;
                case '2':
                    Console.WriteLine("2");
                    break;
                case '3':
                    Console.WriteLine("3");
                    break;
                case '4':
                    Console.WriteLine("4");
                    break;
                case '5':
                    Console.WriteLine("5");
                    break;
                case '6':
                    Console.WriteLine("6");
                    break;
                case '7':
                    Console.WriteLine("7");
                    break;
                case '8':
                    Console.WriteLine("8");
                    break;
                case '9':
                    Console.WriteLine("9");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine("10");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("11");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("12");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("13");
                    break;
                case 'E':
                case 'e':
                    Console.WriteLine("14");
                    break;
                case 'F':
                case 'f':
                    Console.WriteLine("15");
                    break;
                default:
                    Console.WriteLine("To nie jest cyfra szenstastkowa");
                    break;
            }
        }
    }
}
