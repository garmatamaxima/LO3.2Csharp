// ====== завдання з L03.2C#_t рябова максима  ======

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
        int a1 = 0; // одиниці
        int a2 = 0; // десятки
        int b = 0;

        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("Введіть десятки числа a: ");
        boundaryRead(ref a2, 9, 1);

        Console.WriteLine("Введіть одиниці числа a: ");
        boundaryRead(ref a1, 9, 1);

        Console.WriteLine("Введіть одиниці числа b: ");
        boundaryRead(ref b, 9, 1);

        Console.WriteLine($"сума = {a1 + a2 * 10 + b}");

        return 0;
    }
}