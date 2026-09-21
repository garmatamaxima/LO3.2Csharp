// ====== завдання з L03.2C#_t рябова максима НОМЕР 4 ======

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

    static void miniprogram4()
    {
        float deg_celsius = 0;

        Console.WriteLine("\n4.");
        Thread.Sleep(150);

        Console.WriteLine("Введіть значення у цельсіях для переведення у фаренгейти: ");
        forceReadConsole(out deg_celsius);
        Console.WriteLine($"У фаренгейтах -  {deg_celsius * 1.8 + 32}");
    }

    static int Main()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        miniprogram4();
        return 0;
    }
}