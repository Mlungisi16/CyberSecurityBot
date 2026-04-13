using System;
using System.Drawing;
using System.IO;
using System.Threading;

namespace CyberSecurityBot   // make sure this matches Program.cs
{
    public class Logo1
    {
        public Logo1()
        {
            ShowHeader();
        }

        private void ShowHeader()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CyberSecurity.jpg");

            if (!File.Exists(path))
            {
                Console.WriteLine("Image not found: " + path);
                return;
            }

            Bitmap image = new Bitmap(path);

            int width = 75;
            int height = 35;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            Console.ForegroundColor = ConsoleColor.Cyan;
            string asciiChars = "@#S%?*+;:,. ";

            for (int y = 0; y < resized.Height; y++)
            {
                for (int x = 0; x < resized.Width; x++)
                {
                    Color pixel = resized.GetPixel(x, y);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    int index = (gray * (asciiChars.Length - 1)) / 255;

                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();
            }
        }

        public static void TypeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
        }
    }
}