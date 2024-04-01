namespace Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To My Pyramid Drawing App!");
            //Take user input
            Console.WriteLine("Enter the number of rows for the pyramid: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            DrawPyramid(num);
            DrawInvertedPyramid(num);


            Console.ReadLine();
        }

        private static void DrawPyramid(int num)
        {
            for (int i = 0; i < num; i++)
            {
                //Hyphens on left
                for(int j=0;j< (num- i -1); j++)
                {
                    Console.Write("-");
                }

                //The Pyramid
                for (int k=0;k<((i*2)-1) ;k++)
                {
                    Console.Write("#");
                }

                //Hyphens on right
                for (int l = 0; l < (num - i - 1); l++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("");

            }
        }
        private static void DrawInvertedPyramid(int num)
        {
            for (int i = num - 1; i > 0; i--)
            {
                // Hyphens on left
                for (int j = 0; j < (num - i -1); j++)
                {
                    Console.Write("-");
                }

                // The Pyramid
                for (int k = 0; k < ((i * 2) - 1); k++)
                {
                    Console.Write("#");
                }

                // Hyphens on right
                for (int l = 0; l < (num - i -1); l++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }

    }
}
