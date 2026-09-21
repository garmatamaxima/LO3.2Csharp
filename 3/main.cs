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

    static void miniprogram3()
    {
        float car1_v = 0;
        float car2_v = 0;
        float distance = 0;

        Console.WriteLine("\n3.");
        Thread.Sleep(150);

        Console.Write("Введіть Швидкість першої машини у метрах за секунду: ");
        forceReadConsole(out car1_v);
        Console.Write("Введіть Швидкість другої машини у метрах за секунду: ");
        forceReadConsole(out car2_v);
        Console.Write("Введіть відстань між машинами у метрах: ");
        forceReadConsole(out distance);

        float time_to_crash = distance / (car1_v + car2_v);

        // обираємо правильний суфікс для слова
        if (time_to_crash > 1 || time_to_crash < 1)
        {
            Console.WriteLine($"\nЧас до зіткнення = {time_to_crash} сек.\n");
        }
    }

    static int Main()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        miniprogram3();
        return 0;
    }
}