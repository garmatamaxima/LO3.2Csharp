// ====== завдання з L03.2C#_t рябова максима  ======

using System;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Threading;

class Functions
{
    public static void swap2(ref int x)
    {
        int tens = (x % 10) * 10;
        int ones = x / 10;
        x = tens + ones;
    }

    public static void magicTransform(ref int x)
    {
        int magic = x / 10;
        Functions.swap2(ref magic);
        magic *= 10;
        x = magic + (x % 10);
    }
}

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

    static void miniprogram5()
    {
        int input = 0;

        Console.WriteLine("\n\n5.");
        Thread.Sleep(150);

        Console.WriteLine("Введіть тризначне число для магічних перетворень: ");

        forceReadConsole(out input);
        while (input < 100 || input > 999 || input % 10 == 0)
        {
            if (input > 999 || input < 100)
            {
                Console.Write("\nвведене число більше або менше за тризначні числа. ");
            }
            if (input % 10 == 0)
            {
                Console.Write("\nвведене число має останню цифру що дорівнює нулю..  ");
            }
            forceReadConsole(out input);
        }

        int temp = input;

        Functions.magicTransform(ref temp);
        Console.WriteLine($"n = {temp}\nтепер використаємо алгоритм знову...");
        Functions.magicTransform(ref temp);
        Console.WriteLine($"n = {temp}, алгоритм зворотній\n");

    }

    static int Main()
    {
        bool repeat = false;
        string exitStatus = "";

        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        
        while (exitStatus != "закінчити")
        { 
            miniprogram5();
            Console.Write("закінчити роботу програми, введіть - закінчити | щоб повторити цикл введіть - будь що =)  : ");
            exitStatus = Console.ReadLine();
        }
        return 0;
    }
}