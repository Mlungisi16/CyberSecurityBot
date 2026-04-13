using System;
using System.Diagnostics;
using System.IO;

namespace CyberSecurityBot
{
    public class voice_greeting
    {
        public voice_greeting()
        {
            PlaySound();
        }

        private void PlaySound()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");

                if (!File.Exists(path))
                {
                    Console.WriteLine("⚠ greeting.wav not found.");
                    return;
                }

                // Use Windows to play the sound (no library needed)
                Process.Start(new ProcessStartInfo()
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠ Could not play sound: " + ex.Message);
            }
        }
    }
}