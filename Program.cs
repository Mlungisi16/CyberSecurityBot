
using System;

namespace CyberSecurityBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Voice greeting
            new voice_greeting();

            // ASCII Logo
            new Logo();

            // Start chatbot
            human_text bot = new human_text();
            bot.Start();
        }
    }
}