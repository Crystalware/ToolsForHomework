using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanishConjugationTool
{
    class MainClass
    {

        /**
         * 'AR' verbs
         */
        public const string I_AR = "o";
        public const string YOU_AR = "as";
        public const string SINGULAR_AR = "a";
        public const string WE_AR = "amos";
        public const string YOU2_AR = "áis";
        public const string MULTI_AR = "an";

        /**
         * 'ER' verbs
         */
        public const string I_ER = "o";
        public const string YOU_ER = "es";
        public const string SINGULAR_ER = "e";
        public const string WE_ER = "emos";
        public const string YOU2_ER = "éis";
        public const string MULTI_ER = "en";

        /**
         * 'IR' verbs
         */
        public const string I_IR = "o";
        public const string YOU_IR = "es";
        public const string SINGULAR_IR = "e";
        public const string WE_IR = "imos";
        public const string YOU2_IR = "ís";
        public const string MULTI_IR = "en";

        public static string[] detect = { "ar", "er", "ir" };

        static void Main()
        {
            while (true)
            {
            fallback:
                Msg("Spanish Verb Conjugation Automation Tool (Auto-Detect)\n" +
                    "Insert your Spanish verb > ", ConsoleColor.Blue, false);
                char[] input = Console.ReadLine().ToCharArray();
                if (input == null || input.Length < 2)
                {
                    Msg("Invalid input.", ConsoleColor.Red, true);
                    goto fallback;
                }
                char[] baseWord = new char[input.Length - 2];
                for (int i = 0; i < input.Length - 2; i++)
                    baseWord[i] = input[i];
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(input[input.Length - 2]);
                stringBuilder.Append(input[input.Length - 1]);
                string end = stringBuilder.ToString().ToLower();
                string baseWordStr = Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(baseWord));
                if (detect.Contains(end))
                {
                    switch (end)
                    {
                        case "ar":
                            {
                                Msg("Detected conjugation: ar\n" +
                                    "Yo - " + baseWordStr + I_AR + "\n" +
                                    "Tú - " + baseWordStr + YOU_AR + "\n" +
                                    "Él, Ella, Usted - " + baseWordStr + SINGULAR_AR + "\n" +
                                    "Nosotros - " + baseWordStr + WE_AR + "\n" +
                                    "Vosotros - " + baseWordStr + YOU2_AR + "\n" +
                                    "Ellos, Ellas, Ustedes - " + baseWordStr + MULTI_AR + "\n" +
                                    "Finished.", ConsoleColor.Green, true);
                                break;
                            }
                        case "er":
                            {
                                Msg("Detected conjugation: er\n" +
                                    "Yo - " + baseWordStr + I_ER + "\n" +
                                    "Tú - " + baseWordStr + YOU_ER + "\n" +
                                    "Él, Ella, Usted - " + baseWordStr + SINGULAR_ER + "\n" +
                                    "Nosotros - " + baseWordStr + WE_ER + "\n" +
                                    "Vosotros - " + baseWordStr + YOU2_ER + "\n" +
                                    "Ellos, Ellas, Ustedes - " + baseWordStr + MULTI_ER + "\n" +
                                    "Finished.", ConsoleColor.Green, true);
                                break;
                            }
                        case "ir":
                            {
                                Msg("Detected conjugation: ir\n" +
                                    "Yo - " + baseWordStr + I_IR + "\n" +
                                    "Tú - " + baseWordStr + YOU_IR + "\n" +
                                    "Él, Ella, Usted - " + baseWordStr + SINGULAR_IR + "\n" +
                                    "Nosotros - " + baseWordStr + WE_IR + "\n" +
                                    "Vosotros - " + baseWordStr + YOU2_IR + "\n" +
                                    "Ellos, Ellas, Ustedes - " + baseWordStr + MULTI_IR + "\n" +
                                    "Finished.", ConsoleColor.Green, true);
                                break;
                            }
                    }
                }
                else
                    Msg("Could not detect a conjugation.", ConsoleColor.Red, true);
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