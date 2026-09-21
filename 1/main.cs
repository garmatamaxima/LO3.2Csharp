// ====== завдання з L03.2C#_t рябова максима  ======

using System;
using System.Text;
using System.Threading;

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

    static void miniprogram1()
    {
        int citizen_amount = 0;
        int country_size = 0;

        Console.WriteLine("1.");
        Thread.Sleep(150);

        Console.Write("Введіть кількість жителів: ");
        forceReadConsole(out citizen_amount);
        Console.Write("Введіть площу вашої країни у кілометрах: ");

        forceReadConsole(out country_size);
        Console.WriteLine($"\nКількість осіб на квадратний кілометр: {(float)(citizen_amount) / (float)(country_size)}\n");
    }

    static int Main()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        miniprogram1();
        return 0;
    }
}

