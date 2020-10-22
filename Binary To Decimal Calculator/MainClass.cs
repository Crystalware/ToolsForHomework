using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class MainClass
    {
        static void Main()
        {
            while (true)
            {
fallback:
                Msg("Binary to Decimal Calculator\n" +
                    "Specify your 8 digit binary code > ", ConsoleColor.Blue, false);
                char[] binary = Console.ReadLine().ToCharArray();
                int startingBits = 128;
                int value = 0;
                if (binary.Length != 8)
                {
                    Msg("Invalid input.", ConsoleColor.Red, true);
                    goto fallback;
                }
                for (int i = 0; i < binary.Length; i++)
                {
                    if (binary[i] == '1')
                        value += startingBits;
                    else if (binary[i] != '1' && binary[i] != '0') {
                        Msg("Invalid input.", ConsoleColor.Red, true);
                        goto fallback;
                    }
                    startingBits = startingBits / 2;
                }
                string binaryStr = Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(binary));
                Msg("Specified 8 digit binary code: " + binaryStr + "\nDecimal calculation: " + value + "\nFinished.", ConsoleColor.Blue, true);
            }
        }

        static void Msg(string text, ConsoleColor color, bool newline)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text + (newline ? "\n" : string.Empty));
            Console.ForegroundColor = oldColor;
        }
    }
}
