using System;
using System.Linq;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the Roulette table.");
            Console.WriteLine("Please press enter to spin");
            Console.ReadLine();

            Random rndm = new Random();
            int rn = rndm.Next(00, 38);


            int[] left = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] center = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] right = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

            int[] black = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] red = new int[] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };

            if (rn <= 36)
            {
                Console.WriteLine($"The winning number is: {rn}");
            }
            else if (rn == 37)
            {
                Console.WriteLine("The winning number is 00");
            }
            if (rn % 2 == 0)
            {
                Console.WriteLine("The EVEN/ODD winner is: Even");
            }
            else
            {
                Console.WriteLine("The EVEN/ODD winner is: Odd");
            }
            if (red.Contains(rn))
            {
                Console.WriteLine("The Red/BLACK winner is: Red");
            }
            else if (black.Contains(rn))
            {
                Console.WriteLine("The RED/BLACK winner is: Black");
            }
            if (rn <= 18)
            {
                Console.WriteLine("The HIGH/LOW winner is: Low");
            }
            else if (rn >= 19)
            {
                Console.WriteLine("The HIGH/LOW winner is: High");
            }
            if (rn > 0 || rn <= 12)
            {
                Console.WriteLine("The Dozens winner is: Lower Third");
            }
            else if (rn > 12 || rn <= 24)
            {
                Console.WriteLine("The Dozens winner is: Middle Third");
            }
            else if (rn > 24 || rn <= 36)
            {
                Console.WriteLine("The Dozens winner is: Upper Third");
            }
            if (left.Contains(rn))
            {
                Console.WriteLine("The Column winner is: First Column");
                Console.WriteLine($"The Street winner is: {rn} {rn + 1} {rn + 2}");
            }
            else if (center.Contains(rn))
            {
                Console.WriteLine("The Column winner is: Second Column");
                Console.WriteLine($"The Street winner is: {rn - 1} {rn} {rn + 1}");
            }
            else if (right.Contains(rn))
            {
                Console.WriteLine("The Column winner is: Third Column");
                Console.WriteLine($"The Street winner is: {rn - 2} {rn - 1} {rn}");
            }
            if (left.Contains(rn) && rn == 1)
            {
                Console.WriteLine("6 Numbers winner is: 1, 2, 3, 4, 5, 6");
            }
            else if (left.Contains(rn) && rn == 34)
            {
                Console.WriteLine("6 Numbers winner is: 31, 32, 33, 34, 35, 36");
            }
            else if (left.Contains(rn) && rn != 1 && rn != 34)
            {
                Console.WriteLine($"6 Numbers winner is: {rn}, {rn + 1}, {rn + 2}, {rn + 3}, {rn + 4}, {rn + 5}");
            }
            if (center.Contains(rn) && rn == 2)
            {
                Console.WriteLine("6 Numbers winner is: 1, 2, 3, 4, 5, 6");
            }
            else if (center.Contains(rn) && rn == 35)
            {
                Console.WriteLine("6 Numbers winner is: 31, 32, 33, 34, 35, 36");
            }
            else if (center.Contains(rn) && rn != 2 && rn != 35)
            {
                Console.WriteLine($"6 Numbers winner is: {rn - 1}, {rn}, {rn + 1}, {rn + 2}, {rn + 3}, {rn + 4}");
            }
            if (right.Contains(rn) && rn == 3)
            {
                Console.WriteLine("6 Numbers winner is: 1, 2, 3, 4, 5, 6");
            }
            else if (right.Contains(rn) && rn == 36)
            {
                Console.WriteLine("6 Numbers winner is: 31, 32, 33, 34, 35, 36");
            }
            else if (right.Contains(rn) && rn != 3 && rn != 36)
            {
                Console.WriteLine($"6 Numbers winner is: {rn - 2}, {rn - 1}, {rn}, {rn + 1}, {rn + 2}, {rn + 3}");
            }
            if (left.Contains(rn) && rn == 1)
            {
                Console.WriteLine("The Split bet is: 1/2 & 1/4");
            }
            else if (left.Contains(rn) && rn == 34)
            {
                Console.WriteLine("The Split bet is: 34/35 & 34/31");
            }
            else if (left.Contains(rn) && rn != 1 && rn != 34)
            {
                Console.WriteLine($"Split bet is: {rn}/{rn - 3} & {rn}/{rn + 1} & {rn}/{rn + 3}");
            }
            if (center.Contains(rn) && rn == 2)
            {
                Console.WriteLine("The Split bet is: 2/1 & 2/3 & 2/5");
            }
            else if (center.Contains(rn) && rn == 35)
            {
                Console.WriteLine("The Split bet is: 35/34 & 35/36 & 35/32");
            }
            else if (center.Contains(rn) && rn != 2 && rn != 35)
            {
                Console.WriteLine($"Split bet is: {rn}/{rn - 3} & {rn}/{rn + 1} & {rn}/{rn - 1} & {rn}/{rn + 3}");
            }
            if (right.Contains(rn) && rn == 3)
            {
                Console.WriteLine("Split bet is: 3/2 & 3/6");
            }
            else if (right.Contains(rn) && rn == 36)
            {
                Console.WriteLine("Split bet is: 36/35 & 36/33");
            }
            else if (right.Contains(rn) && rn != 3 && rn != 36)
            {
                Console.WriteLine($"Split bet is: {rn}/{rn - 3} & {rn}/{rn - 1} & {rn}/{rn + 3}");
            }
            if (left.Contains(rn) && rn == 1)
            {
                Console.WriteLine("The Corner bet is: 1, 2, 4, 5");
            }
            else if (left.Contains(rn) && rn == 34)
            {
                Console.WriteLine("The Corner bet is: 34, 35, 31, 32");
            }
            else if (left.Contains(rn) && rn != 1 && rn != 34)
            {
                Console.WriteLine($"The Corner bet is: {rn}, {rn + 1}, {rn + 3}, {rn + 4} OR  {rn}, {rn - 3}, {rn - 2}, {rn + 1}");
            }
            if (center.Contains(rn) && rn == 2)
            {
                Console.WriteLine("The Corner bet is: 1, 2, 4, 5 OR 2, 3, 5, 6");
            }
            else if (center.Contains(rn) && rn == 35)
            {
                Console.WriteLine("The Corner bet is: 34, 35, 31, 32 OR 35, 32, 33, 36");
            }
            else if (center.Contains(rn) && rn != 2 && rn != 35)
            {
                Console.WriteLine($"The Corner bet is: {rn}, {rn + 1}, {rn + 3}, {rn + 4} OR {rn}, {rn - 1}, { rn - 3}, { rn - 4} OR {rn}, {rn - 1}, { rn + 3}, { rn + 2} OR {rn}, {rn + 1}, { rn - 2}, { rn - 3}");
            }
            if (right.Contains(rn) && rn == 3)
            {
                Console.WriteLine("The Corner bet is: 2, 3, 5, 6");
            }
            else if (right.Contains(rn) && rn == 36)
            {
                Console.WriteLine("The Corner bet is: 32, 33, 35, 36");
            }
            else if (right.Contains(rn) && rn != 3 && rn != 36)
            {
                Console.WriteLine($"Split Corner is: {rn}, {rn -1}, {rn - 3}, {rn - 4} OR  {rn}, {rn + 3}, {rn + 2}, {rn - 1}");
            }
        }
    }
}
