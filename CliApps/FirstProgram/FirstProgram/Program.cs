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



            Console.WriteLine("Hello, " + firstName + "!");
            Console.WriteLine("Not a book but.... \n" +book);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            //List Data Structure
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(10);
            //numbers.Remove(5); //Removes the number 5 from the which is at index 4 
            numbers.RemoveAt(5); //Removes the number at index 5 which is 6
            //numbers.Clear(); //Removes all the numbers from the list
            Console.WriteLine("Total count in list: "+ numbers.Count); //Returns the number of elements in the list
            //Print out the list
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //Create a User object //public User(string firstName, string lastName, int age, string email, string password, string address, string city, string state, string zip, string phoneNumber, string creditCard, string expirationDate, string cvv, string billingAddress, string billingCity, string billingState, string billingZip, string billingPhoneNumber)
            User Wyatt = new User(
                            "Wyatt", // firstName
                            "B", // lastName
                            29, // age
                            "W@gmail.com", // email
                            "cupcake", // password
                            "123 Maple Street", // address
                            "Anytown", // city
                            "Anystate", // state
                            "12345", // zip
                            "555-1234", // phoneNumber
                            "1111 2222 3333 4444", // creditCard
                            "12/27", // expirationDate
                            "123", // cvv
                            "123 Maple Street", // billingAddress
                            "Anytown", // billingCity
                            "Anystate", // billingState
                            "12345", // billingZip
                            "555-1234" // billingPhoneNumber
                        );
            Console.WriteLine("Wyatt's phone: " + Wyatt.PhoneNumber);



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
