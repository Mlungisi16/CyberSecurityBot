using System;
using System.Threading;

namespace CyberSecurityBot
{
    public class Logo
    {
        public Logo()
        {
            ShowHeader();
        }

        private void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            string logo = @"
========================================
   CYBERSECURITY AWARENESS BOT
========================================

        🔐 STAY SAFE ONLINE 🔐

========================================
";

            TypeText(logo);
            Console.ResetColor();
        }

        public static void TypeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(5);
            }
            Console.WriteLine();
        }
    }
}