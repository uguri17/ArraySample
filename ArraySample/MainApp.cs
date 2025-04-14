using System;
using static System.Formats.Asn1.AsnWriter;

namespace ArraySample
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 10;
            scores[1] = 20;
            scores[2] = 30;
            scores[3] = 40;
            scores[4] = 50;
            
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"scores[{i}]: {scores[i]}");
            }
              
                          
            int sum = 0;            
            foreach (int score in scores)
            {
                sum += score;
            }
            Console.WriteLine($"Total: {sum}");
            int average = sum / scores.Length;

            Console.WriteLine($"Average Score : {average}");
        }
    }
}