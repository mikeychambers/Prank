using System;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace PrankyPrank
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread speachText = new Thread(SpeechText);
            Thread mouseShake = new Thread(MouseShake);
            Thread textWrite = new Thread(TextWrite);
            speachText.Start();
            textWrite.Start();
            mouseShake.Start();
        }
        static void SpeechText()
        {
            while (true)
            {
                SpeechSynthesizer voice = new SpeechSynthesizer();
                voice.Speak(Environment.UserName + " You have been pwned");
            }
        }

        static void TextWrite()
        {
            while (true)
            {
                Console.WriteLine("Deleting {0} ", Environment.SystemDirectory);

            }
        }
        static void MouseShake()
        {
            while (true)
            {
                Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
                Cursor.Position = new Point(Cursor.Position.X + 50, Cursor.Position.Y + 50);
            }

        }


    }
}
