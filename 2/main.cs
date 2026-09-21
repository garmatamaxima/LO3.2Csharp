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

    static void miniprogram2()
    {
        float candy_gr = 0;
        float cookie_gr = 0;
        float apple_gr = 0;


        Console.WriteLine("2.");
        Thread.Sleep(150);

        Console.Write("Вартість цукерок 54 - грн за кілограм\nВартість печива - 33 гривні за кілограм\nВартість яблук - 60 грн за кілограм");

        Console.Write("\n\nВведіть вагу ваших цукерок у грамах: ");
        forceReadConsole(out candy_gr);
        Console.Write("\n\nВведіть вагу вашого печива у грамах: ");
        forceReadConsole(out cookie_gr);
        Console.Write("\n\nВведіть вагу ваших яблук у грамах: ");
        forceReadConsole(out apple_gr);

        Console.Write($"Сума ціни продуктів = {(apple_gr / 1000 * 60) + (cookie_gr / 1000 * 33) + (candy_gr / 1000 * 54)} гривень.\n");
    }

    static int Main()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        miniprogram2();

        return 0;
    }
}