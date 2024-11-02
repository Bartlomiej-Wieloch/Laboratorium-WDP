namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie1();
            Zadanie2();
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
    }
}
