/*********************************************************************************************************************
 * Project: Password Generator
 * Auteur: Delshad Mohammed
 * Date: 15.12.2017
 * Classe: 1M4I1C
 * Version: Visual Studio Pro 2017
 * OS: Windows 10 Pro
 * Goal : Generate randomly password
  *********************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_generator
{
    class Program
    {





        static char[] uppercaseChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        static char[] lowercaseChar = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        static char[] numbers = "0123456789".ToCharArray();
        static char[] symbols = "!@#$%^&*()[]{};:'\",.<>/?\\|_+-=`~".ToCharArray();

        static string keyboard = "`1234567890-=qwertyuiop[]\\asdfghjkl;'zxcvbnm,./";
        static string KEYBOARD = "~!@#$%^&*()_+QWERTYUIOP{}|ASDFGHJKL:\"ZXCVBNM<>?";

        static void Main(string[] args)
        {

            int length = 0;
            int numberOfPass = 1;
            bool uppercase = false;
            bool lowercase = false;
            bool num = false;
            bool sym = false;
            bool ASCII = false;
            bool again = true;

            while (again)
            {
                // the head
                Console.Clear();
                Console.WriteLine(@"██████╗  █████╗ ███████╗███████╗██╗    ██╗ ██████╗ ██████╗ ██████╗      ██████╗ ███████╗███╗   ██╗███████╗██████╗  █████╗ ████████╗ ██████╗ ██████╗");
                Console.WriteLine(@"██╔══██╗██╔══██╗██╔════╝██╔════╝██║    ██║██╔═══██╗██╔══██╗██╔══██╗    ██╔════╝ ██╔════╝████╗  ██║██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██╔═══██╗██╔══██╗");
                Console.WriteLine(@"██████╔╝███████║███████╗███████╗██║ █╗ ██║██║   ██║██████╔╝██║  ██║    ██║  ███╗█████╗  ██╔██╗ ██║█████╗  ██████╔╝███████║   ██║   ██║   ██║██████╔╝");
                Console.WriteLine(@"██╔═══╝ ██╔══██║╚════██║╚════██║██║███╗██║██║   ██║██╔══██╗██║  ██║    ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝  ██╔══██╗██╔══██║   ██║   ██║   ██║██╔══██╗");
                Console.WriteLine(@"██║     ██║  ██║███████║███████║╚███╔███╔╝╚██████╔╝██║  ██║██████╔╝    ╚██████╔╝███████╗██║ ╚████║███████╗██║  ██║██║  ██║   ██║   ╚██████╔╝██║  ██║");
                Console.WriteLine(@"╚═╝     ╚═╝  ╚═╝╚══════╝╚══════╝ ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═╝╚═════╝      ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝");
                Console.WriteLine("*****************************************");
                Console.WriteLine("**                                     **");
                Console.WriteLine("**  Welcome to the Password Generator  **");
                Console.WriteLine("**                                     **");
                Console.WriteLine("*****************************************");
                Console.WriteLine("=========================================");
                Console.WriteLine("*****************************************");
                Console.WriteLine("**        Programmed by D3lsh4d        **");
                Console.WriteLine("*****************************************");

                // few modifiable questions 
                AskInt("How long would you like your password to be", ref length, 1, 30);
                AskInt("How many passwords would you like to generate", ref numberOfPass, 1, 20);

                if (!ASCII)
                {
                    Console.WriteLine();
                    AskBool("uppercase characters", ref uppercase);
                    AskBool("lowercase characters", ref lowercase);
                    AskBool("numbers", ref num);
                    AskBool("symbols", ref sym);
                }

                generatePassword(ASCII, uppercase, lowercase, num, sym, length, numberOfPass);
                AskBool("this tool again", ref again);


            }
            Console.WriteLine("Goodbye!");
        }

        static void ShowArray(string name, char[] array)
        {
            StringBuilder sb = new StringBuilder(80);
            sb.Append(name);
            sb.Append(":\t");

            for (int i = 0; i < array.Length; i++)
                sb.Append(array[i]);

            Console.WriteLine(sb.ToString());
        }
        static void AskBool(string subject, ref bool test)
        {
            Console.Write("Would you like to use {0}? (y/n): ", subject);

            ConsoleKeyInfo key = Console.ReadKey(true);

            while (key.Key != ConsoleKey.Y && key.Key != ConsoleKey.N)
                key = Console.ReadKey(true);

            Console.WriteLine(key.Key);

            test = key.Key == ConsoleKey.Y;
        }
        static void AskInt(string question, ref int response, int lower, int upper)
        {
            if (upper > lower) // Make sure a coder hooking into this library doesn't accidently create an infinite loop.  Defensive coding!
            {
                Console.WriteLine("\n{0}? (Valid Range: {1}-{2})", question, lower, upper);

                while (!Int32.TryParse(Console.ReadLine(), out response) || response > upper || response < lower)
                {
                    Console.WriteLine("That input don't make any sense.  Please type a numeric value between {0} and {1} !!", lower, upper);
                }
            }
            else
                throw new Exception("AskInt requires that your upper bound be higher than your lower bound.");
        }
        static void generatePassword(bool ASCII, bool upper, bool lower, bool num, bool sym, int length, int numOfPass)
        {
            StringBuilder sb = new StringBuilder();
            Random r = new Random();
            int RandomLength = 0;
            char[] charset;

            if (length > 0 && length < 33 && (ASCII || upper || lower || num || sym)) // Length should never be either of these values, but this is good defensive coding.  You never know when someone else might mess up your main method.
            {
                for (int j = 0; j < numOfPass; j++)
                {
                    if (ASCII)
                    {
                        RandomLength = 255;

                        for (int i = 0; i < length; i++)
                        {
                            sb.Append((char)(r.Next(RandomLength) + 1)); // 0 is NULL terminator, and not alt-able. 255 total values, 1-255.
                        }
                    }
                    else
                    {
                        RandomLength = 0;
                        RandomLength += upper ? uppercaseChar.Length : 0;
                        RandomLength += lower ? lowercaseChar.Length : 0;
                        RandomLength += num ? numbers.Length : 0;
                        RandomLength += sym ? symbols.Length : 0;

                        charset = new char[RandomLength];
                        int curLength = 0;

                        BuildCharset(upper, ref curLength, ref charset, ref uppercaseChar);
                        BuildCharset(lower, ref curLength, ref charset, ref lowercaseChar);
                        BuildCharset(num, ref curLength, ref charset, ref numbers);
                        BuildCharset(sym, ref curLength, ref charset, ref symbols);

                        for (int i = 0; i < length; i++)
                        {
                            int pos = r.Next(RandomLength);
                            sb.Append(charset[pos]);
                        }
                    }

                    Console.WriteLine("\nYour generated password is:", ASCII ? KeyCombo(sb.ToString()) : sb.ToString());
                    Console.WriteLine("\n******************************************>>");
                    Console.WriteLine("**");
                    Console.WriteLine("**         {0}", ASCII ? KeyCombo(sb.ToString()) : sb.ToString());
                    Console.WriteLine("**");
                    Console.WriteLine("******************************************>>\n");
                    if (!ASCII)

                        sb.Clear();
                }



            }
            else
            {
                Console.WriteLine("\nNo valid passwords could be generated. Check your criteria, and try again.\n");
            }
        }

        static string KeyCombo(string password)
        {
            StringBuilder sb = new StringBuilder(80);

            for (int i = 0; i < password.Length; i++)
            {
                char c = password.Substring(i, 1).ToCharArray()[0];
                int k = keyboard.IndexOf(c);
                int K = KEYBOARD.IndexOf(c);

                if (k > 0)
                    sb.Append(string.Format("{0}  ", keyboard.Substring(k, 1).ToUpper()));
                else if (K > 0)
                    sb.Append(string.Format("Shift+{0}  ", keyboard.Substring(K, 1).ToUpper()));
                else if (c == ' ')
                    sb.Append("Spacebar  ");
                else
                    sb.Append(string.Format("Alt+{0}  ", (byte)c));
            }

            return sb.ToString();
        }



        static void BuildCharset(bool test, ref int curLength, ref char[] charset, ref char[] chars)
        {
            if (test)
            {
                chars.CopyTo(charset, curLength);
                curLength += chars.Length;
            }
        }
    }
}
