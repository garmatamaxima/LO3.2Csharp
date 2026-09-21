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
        int hours = 0;
        int minutes = 0;
        int seconds = 0;

        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("Введіть час у годинах: ");
        boundaryRead(ref hours, 23, 1);

        Console.WriteLine("Введіть час у хвилинах: ");
        boundaryRead(ref minutes, 59, 1);

        Console.WriteLine("Введіть час у секундах: ");
        boundaryRead(ref seconds, 59, 1);

        Console.WriteLine($"годинна стрілка - {(360.0f / 24.0f) * hours} градусів");
        Console.WriteLine($"хвилинна стрілка - {(360.0f / 60.0f) * minutes} градусів");
        Console.WriteLine($"секундна стрілка - {(360.0f / 60.0f) * seconds} градусів");
        return 0;
    }
}