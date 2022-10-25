using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var recHeightParse = 0;
            var recWidthParse = 0;
            var checkParseHeight = false;
            var checkParseWidth = false;

            while (!checkParseWidth)
            {
                Console.Write("Введите ширину прямоугольника: ");
                var recWidth = Console.ReadLine();

                if (!(checkParseWidth = int.TryParse(recWidth, out recWidthParse)))
                {
                    Console.WriteLine("Ошибка ввода ширины!");
                }
            }

            string recLine = new String('█', recWidthParse);

            while (!checkParseHeight)
            {
                Console.Write("Введите высоту прямоугольника: ");
                var recHeight = Console.ReadLine();

                if (!(checkParseHeight = int.TryParse(recHeight, out recHeightParse)))
                {
                    Console.WriteLine("Ошибка ввода высоты!");
                }
            }

            var y = (Console.WindowHeight - recHeightParse) / 2;
            var x = (Console.WindowWidth - recWidthParse) / 2;

            for (var i = 0; i < recHeightParse; i++)
            {
                Console.SetCursorPosition(x, y++);
                Console.WriteLine(recLine);
            }
        }
    }
}
