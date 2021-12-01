using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // RandomArray();
            // CoinFlip();
            // TossMultipleCoins(8);
            Names();
        }

        public static void RandomArray()
        {
            //10 random int between 5-25
            Random rand = new Random();
            int[] randomArray = new int[10];
            int arraySum = 0;
            int arrayMin = 25;
            int arrayMax = 5;

            foreach (int i in randomArray)
            {
                int randomNum = rand.Next(5,26);
                randomArray[i] = randomNum;
                arraySum += randomArray[i];
                Console.WriteLine(randomArray[i]);
                if (randomArray[i]<arrayMin)
                {
                    arrayMin = randomArray[i];
                }
                else if (randomArray[i]>arrayMax)
                {
                    arrayMax = randomArray[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"The smallest number in the array is {arrayMin} and the largest number in the array is {arrayMax}. The sum of the array is {arraySum}");
        }


        public static int CoinFlip()
        {
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int randomBool = rand.Next(2); 
            // 0 = false, 1 = true;
            if(randomBool == 0)
            {
                Console.WriteLine("Heads");
                return randomBool;
            }
            else{
                Console.WriteLine("Tails");
                return randomBool;
            }
        }

        public static double TossMultipleCoins(int num)
        {
            int heads = 0;
            int tails = 0;

            for (int i = 0; i <= num; i++)
            {
                int flip = CoinFlip();
                if (flip == 0)
                {
                    heads += 1;
                }
                else
                {
                    tails += 1;
                }
            }
            double ratio = (double)heads / (double)tails;

            Console.WriteLine($"There were {heads} heads, {tails} tails, with a ratio of {ratio}");
            return ratio;
        }


        public static List<string> Names()
        {
        List<string> names = new List<string>{"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
        for (int i = 0; i < names.Count; i++)
        {
            Random rand = new Random();
            string nameatidx = names[i];
            int randidx = rand.Next(0,names.Count);
            names[i] = names[randidx];
            names[randidx] = nameatidx;
        }
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        for (int i = 0; i < names.Count; i++)
        {
            if (names[i].Length <= 5)
            {
                names.RemoveAt(i);
            }
        }
        return names;
        }
    }
}
