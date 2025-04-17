
/* problem of the day..
 * Print the triangle after reading the height */

namespace Triangle_PS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height: ");
            int h = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < h; i++)
            {
                // spacing for center alignment
                Console.Write(new string (' ', (h - 1 -i)*2));

                int val = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(val + "  ");
                    val *= 2;
                }

                val /= 4;
                for (int j = 0; j < i; j++)
                { 
                    Console.Write(val + "  ");
                    val /= 2;
                }

                Console.WriteLine();
            }
        }
    }
}
