using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
        int b = 0;
        int a = 0;

        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("Введіть число a");
        forceReadConsole(out a);

        Console.WriteLine("Введіть число b");
        forceReadConsole(out b);

        if (a%b == 0 || b%a == 0 )
        {
            Console.WriteLine($"діляться націло");
        }
        else
        { 
            Console.WriteLine($"НЕ діляться націло");
        }

        return 0;
    }
}