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

        }
    }
}