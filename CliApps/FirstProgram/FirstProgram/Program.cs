using static System.Net.WebRequestMethods;

namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args){
            //Data Types:
            int age = 29;
            float myFloat = 3.14f;
            double pie = 3.14;
            bool isTrue = true;
            char myInitial = 'W';
            //Strongly typed language and must declare the data type of the variable example: int age = 29;
            //Static typed language means that the data type of the variable is known at compile time non-example: int age = '29'; because 29 is a string
            
            string videoAddress = "https://www.youtube.com/watch?v=ALXpVlPYqYE&list=PLnm8jFW2U530ZjoGmTFK6McFw1ZZ9s4YK&index=16&t=511s";
            string firstName = "Wyatt";
            string book = """""
                This is just a bunch of text
                that spans multiple lines

                and is enclosed in triple quotes.

                It's a great way to write a multi-line string literal.

                And it's also a great way to write a comment.                                           
                           / )
                        ,-(,' ,---.
                       (,-.\,' `  _)-._
                          ,' `(_)_)  ,-`--.
                         /          (      ) 
                        /            `-.,-'|
                       /                |  /
                       |               ,^ /
                      /                   |
                      |                   /
                     /                   /
                     |                   |
                     |                   |
                    /                    \ 
                  ,.|                    |
                (`\ |                    |
                (\  |   --.      /  \_   |
                 (__(   ___)-.   | '' )  /)
                     `---...\\\--(__))/-'-'
        
                """"";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Hello, " + firstName + "!");
            Console.WriteLine("Not a book but.... \n" +book);



            string subString = book.Substring(0, 10); //Substring method takes two arguments, the first is the starting index and the second is the length of the substring
            Console.WriteLine(subString);

            string spongeBob = "sPoNgEbOb";
            Console.WriteLine(spongeBob.ToUpper().Substring(6,3) + " SQUarepants".ToUpper() + "!");

            string patrick = "patrick starfish starthe star star";
            Console.WriteLine(patrick.Replace("star", " jerk "));
            Console.WriteLine(patrick.IndexOf("trick")); // 2

            Console.WriteLine(Math.Pow(2, 8));

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, your name is: " + name + "!");

            //Calculator
            Calculator();
            Calculator();
            Console.WriteLine("Enter your name: ");
            
            string name2 = Console.ReadLine();
            HelloName(name2);
            Console.WriteLine("Hello: "+ GetUserName());

            //Exception handling with divide by zero
            try
            {
                Console.WriteLine("Enter a number dude: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number dude: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This is the finally block");
            }

        }

        static void Calculator(){
            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a math op: e.g. +, -, *, /, %");
            string op = Console.ReadLine();
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "%")
            {
                Console.WriteLine(num1 % num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
        }



        static void HelloName(string name)
        {
            Console.WriteLine("Hello, " + name.ToUpper() + "!" );
        }

        //Overloading the HelloName method...Not a good example of overloading...But hey, different signatures
        static void HelloName(int name)
        {
            Console.WriteLine("Hello, " + name + "!" );
        }

        static string GetUserName()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
    }
}
