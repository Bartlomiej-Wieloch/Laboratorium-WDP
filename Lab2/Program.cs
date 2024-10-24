using System.Threading.Channels;

namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        //Arrays();
        //Task1();
        //ForInstruction();
        //Task2();
        //WhileInstruction();
        //Task4();
        ContinueInstruction();
        //BreakInstruction();
    }

    public static void Arrays()
    {
        int[] numbers = { 2, 5, 1, 9, 8 };
        double[] factors = new double[3]; //wypełniona dowolnymi wartościami dla double, czyli zerami
        factors[2] = 5;
        Console.WriteLine(numbers[0]);          //pierwszy element
        Console.WriteLine(factors[^1]);         //pierwszy element od końca (od końca ma indeks 1 a nie 0)
        Console.WriteLine(factors[^4]);         //gdy odwolamy sie do indeksu poza zakresem jest błąd, program przerywa działanie
        Console.WriteLine(factors[3]);
    }

    // oblicz wartość funkcji kwadratowej dla z
    // jeśli wpółczynniki równania zawiera tablica factors:
    // pierwszy elem. to a 
    // drugi to b
    // trzeci to c
    public static void Task1()
    {
        double[] factors = { 2.4, 2.6, 53 };
        double x = 0.5;
        double y = Math.Pow(x, 2) * factors[0] + x * factors[1] + factors[2];

        Console.WriteLine(y);
    }

    public static void ForInstruction() //debugerem mozna przesledzic krok po kroku dzialanie pętli
    {
        char[] chars = { 'a', 'c', '%', '*', 'a' };
        for (int i = 0; i < chars.Length; ++i)
        {
            Console.WriteLine(chars[i]);
        }
        Console.WriteLine();
        Console.WriteLine();
        int[] ints = { 2, 4, 1, 5, 7 };
        //wyświetl komórki ints od pierwzej do ostaniej

        for (int i = 0; i < ints.Length; ++i)
        {
            Console.WriteLine(ints[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
        //od konca do początku
        for (int i = 1; i < ints.Length + 1; i++) //--i/i-- ma znaczenie          
        {
            Console.Write($"{ints[^i]} ");
        }

        Console.WriteLine();

        foreach (var number in ints)
        {
            Console.Write($"{number} ");
        }
    }

    //Oblicz sumę elementów tablicy factors (za pomocą pętli)
    public static void Task2()
    {
        double[] factors = { 3, 2.2, 53, 8.4, 4.6, 12 };
        double sum = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            sum += factors[i];

        }
        Console.WriteLine(sum);
    }

    //Zmień liczby ujemne na ich wartość bezwględną w tablicy factors
    public static void Task3()
    {
        double[] factors = { 3, 2.2, 53, 8.4, 4.6, 12 };
        for (int i = 0; i < factors.Length; i++)
        {
            factors[i] = Math.Abs(factors[i]);
        }
    }

    public static void WhileInstruction()
    {
        Console.WriteLine("co chcesz dalej zrobić: Q lub coś innego");
        while (Console.ReadLine() != "Q") //gdy wpiszemy Q do konsoli, przerwie się pętla, jak coś innego, wykona się pętla
        {
            Console.WriteLine("Wykonję...");

        }

        Console.WriteLine("Koniec...");
    }

    //Napisz program, który wczytuje n liczb do tablicy
    public static void Task4()
    {
        Console.WriteLine("Podaj ilość liczb:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        while (n-- > 0)
        {
            Console.WriteLine("Wpisz kolejną liczbę do tablicy: ");
            array[^(n + 1)] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(string.Join(", ", array));
    }

    public static void ContinueInstruction()
    {
        double[] factors = { 3, -2.2, 53, -8.4, 4.6, 12 };
        double sum = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            if (factors[i] < 0)
            {
                continue;       //skacze do końca (138 linijka), pomija dalszą część iteracji
            }
            sum += factors[i];
        }

        Console.WriteLine(sum);
    }

    public static void BreakInstruction()
    {
        bool[] states = { true, true, true, false, true, false, true };
        bool result = true;
        //oblicz iloczyn logiczny z tablicy states
        foreach (var state in states)
        {
            if (!state)
            {
                result = false;
                break;          //skacze do końca iteracji(linijka 156)
            }
        }
        //czyli tu
        Console.WriteLine($"Iloczyn wynosi: {result}");
    }


    //Oblicz alternatywę dla tablicy states
    public static void Task5()
    {
        bool[] states = { false, false, true, true, true, true, true };
        bool result = true;
        foreach (var state in states)
        {
            if (state)
            {
                result = false;
                break;
            }
        }
        Console.WriteLine($"Iloczyn wynosi: {result}");
    }
}


