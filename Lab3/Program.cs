namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
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
    }
}
