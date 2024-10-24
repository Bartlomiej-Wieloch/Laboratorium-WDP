namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie1();
            Zadanie2();
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
    }
}
