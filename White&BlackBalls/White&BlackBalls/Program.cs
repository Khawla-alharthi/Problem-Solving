/* given two integers white and black representingthe count of white and black balls. 
 * return the maximum height of the triangle that can be achived. 
 * - each triangle should start with white
   - NOTE: each row should have the same color 

 Ex: white = 4 & black = 2 => output = 3 
 Ex: white = 1 & black = 2 => output = 2
 Ex: white = 1 & black = 1 => output = 1 
 Ex: white = 10 & black = 1 => output = 2 */

using System;

namespace White_BlackBalls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of white balls: ");
            int white = int.Parse(Console.ReadLine());

            Console.Write("Enter number of black balls: ");
            int black = int.Parse(Console.ReadLine());

            // Calculate the maximum triangle height
            int maxHeight = MaxTriangleHeight(white, black);
            Console.WriteLine("Maximum triangle height: " + maxHeight);
        }

        static int MaxTriangleHeight(int white, int black)
        {
            int height = 0; // current height of the triangle
            int balls = 1; // Number of balls needed 

            // this will keep building rows until we run out of balls
            while (true)
            {
                if (height % 2 == 0) // White row
                {
                    if (white >= balls)
                        white -= balls;
                    else
                        break;
                }
                else // Black row
                {
                    if (black >= balls)
                        black -= balls;
                    else
                        break;
                }

                height++;
                balls++;
            }

            return height;
        }
    }
}

/* OUTPUT==>>>
Enter number of white balls: 4
Enter number of black balls: 2
Maximum triangle height: 3 */

