using System;
using System.Media;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PlayAudio(n);
        }

        public static void PlayAudio(int n )
        {
            string response = string.Empty;

            switch (n)
            {
                case 1:
                    SoundPlayer sound = new SoundPlayer("terrM1.wav");
                    sound.Play();
                    response = Console.ReadLine();
                    break;
                case 2:
                    sound = new SoundPlayer("terrM2.wav");
                    sound.Play();

                    response = Console.ReadLine();
                    break;
                case 3:
                    sound = new SoundPlayer("terrM3.wav");
                    sound.Play();

                    response = Console.ReadLine();
                    break;
                default: Console.WriteLine("Error"); break;
            }
        }
    }
}