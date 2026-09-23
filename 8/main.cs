using System;
using System.Text;

class Program
{
    static void forceReadConsole(out int data)
    {
        while (!(Int32.TryParse(Console.ReadLine(), out data)))
        {
            // pass this execution
        }

    }
    static void forceReadConsole(out float data)
    {
        while (!(float.TryParse(Console.ReadLine(), out data)))
        {
            // pass this execution
        }

    }

    static void boundaryRead(ref int data, int upper_limit = 10, int lower_limit = 0)
    {
        forceReadConsole(out data);
        while (data > upper_limit || data < lower_limit)
        {
            Console.WriteLine("введено число за межами!! ");
            forceReadConsole(out data);
        }
    }

    static int Main()
    {
        int b = 0;
        int a = 0;

        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // функція forceReadConsole() використовує логічні умови, але це для безпечного вводу у консоль
        Console.WriteLine("Введіть число a");
        forceReadConsole(out a);

        Console.WriteLine("Введіть число b");
        forceReadConsole(out b);
        //

        bool checkDivAB = (a % b) == 0;
        bool checkDivBA = (b % a) == 0;

        Console.WriteLine($"a/b - {checkDivAB}");
        Console.WriteLine($"b/a - {checkDivBA}");

        return 0;
    }
}
