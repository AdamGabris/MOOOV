using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;

namespace MOOOV
{
    public class Program
    {     

        public static void Main()
        {          
            string[] colors = { "black", "yellow", "red", "blue", "green" };
            string randomColor;

            ArrayList sequence = new ArrayList();

            do
            {
                randomColor = FetchColor(colors, sequence);
                sequence.Add(randomColor);
                Console.WriteLine(randomColor);
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }

        public static string FetchColor(string[] colors, ArrayList sequence)
        {
            int index;
            string randomColor;

            do
            {
                index = new Random().Next(colors.Length);
                randomColor = colors[index];
            } while (sequence.Count > 0 && sequence[sequence.Count - 1] == randomColor);

            return randomColor;
        }*/
    }
}
