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

    }
}
