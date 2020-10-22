using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spanish_Tool_lol
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Msg("Spanish Verb Conjugation Automation Tool - 'ar' Verbs Only\n" +
                    "Insert your Spanish verb > ", ConsoleColor.Blue, false);
                char[] var = Console.ReadLine().ToCharArray();
                char[] baseForm = new char[var.Length - 2];
                for (int i = 0; i < var.Length - 2; i++)
                    baseForm[i] = var[i];
                string baseFormStr = Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(baseForm));
                string varStr = Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(var));
                Msg("Your word: " + varStr + "\n" +
                    "Base form: " + baseFormStr + "\n" +
                    "Output:\n" +
                    "Yo - " + baseFormStr + "o\n" +
                    "Tú - " + baseFormStr + "as\n" +
                    "Él, Ella, Usted - " + baseFormStr + "a\n" +
                    "Nosotros - " + baseFormStr + "amos\n" +
                    "Vosotros - " + baseFormStr + "áis\n" +
                    "Ellos, Ellas, Ustedes - " + baseFormStr + "an\n" +
                    "Done.", ConsoleColor.Blue, true);
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
