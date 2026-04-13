using System;
using System.Threading;

namespace CyberSecurityBot
{
    public class human_text
    {
        private string userName;

        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==============================================");
            TypeEffect("Cyber Security Awareness Bot Online...");
            Console.WriteLine("==============================================\n");

            AskName();

            ShowWelcome();


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nAsk me something: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I didn't receive any input. Please try again.");
                    continue;
                }

                string response = GetResponse(input.ToLower());

                Console.ForegroundColor = ConsoleColor.Green;
                TypeEffect(response);
            }
        }

        // ===== NAME INPUT =====
        private void AskName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "User";
            }
        }

        // ===== WELCOME SCREEN =====
        private void ShowWelcome()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("\n==============================================");
            TypeEffect($"Welcome, {userName}!");
            TypeEffect("I am your Cyber Security Awareness Assistant.");
            TypeEffect("Ask me anything about online safety.");
            Console.WriteLine("==============================================\n");
        }

        // ===== BASIC RESPONSE SYSTEM =====
        private string GetResponse(string input)
        {
            if (input.Contains("how are you"))
                return "I am operating securely and ready to assist you.";

            if (input.Contains("your purpose"))
                return "My purpose is to teach you cyber security safety and awareness.";

            if (input.Contains("what can i ask"))
                return "You can ask about passwords, phishing, safe browsing, and online threats.";

            if (input.Contains("password"))
                return "Use strong passwords with letters, numbers, and symbols. Never reuse them.";

            if (input.Contains("phishing"))
                return "Phishing is when attackers trick you into giving personal information. Always verify links.";

            if (input.Contains("browsing"))
                return "Use secure websites (HTTPS) and avoid suspicious downloads.";

            return "I didn't quite understand that. Could you rephrase?";
        }

        // ===== TYPING EFFECT =====
        private void TypeEffect(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }
    }
}