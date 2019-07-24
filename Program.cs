using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetToKnowClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool goAgain = true;
            //while
            //try
            string[] student = { "Bob", "Joe", "Jim" };
            string[] food = { "Burger", "Avocado", "Tea" };
            string[] homeTown = { "Detroit", "Chicago", "New York" };

            bool go = true;
            while (go)
            {
                try
                {
                    Console.WriteLine("Which student would you like to know about? (enter a number)\n");
                    DisplayPeoples(student);
                    int input = UserInput();
                    //DisplayInfo(input, student, hometown, food);
                    //DisplayHomeTownAndFood(input,student,food,homeTown);


                    //make another display method
                    Console.WriteLine($"\n{student[input - 1]}! I like {student[input - 1]}. ");
                    Console.WriteLine($"\nWhat would you like to know more about {student[input - 1]}?\n");
                    Console.WriteLine("\nHometown? or Food?\n");
                    string input2 = Console.ReadLine().ToLower();
                    if (input2 == "hometown")
                    {
                        Console.WriteLine($"\n{student[input - 1]} is from {homeTown[input - 1]}\n");
                    }
                    else if (input2 == "food")
                    {
                        Console.WriteLine($"\n{student[input - 1]} really likes {food[input - 1]}");
                    }
                    else
                    {
                        go = Proceed();
                    }
                } 
                catch (FormatException) //format try catch
                //index: range of three people
                //anything that's not 0,1,2 is a index exception (if they type number out of range when people 
                //try catch 2, put two parameters 
                {
                    Console.WriteLine("\nYou messed up, try again.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("\nYour numbers are out of range.");
                }
            }

        }

        /*public static void DisplayHomeTownAndFood(int input, string[]student, string[]food, string[]homeTown)
        {
            bool go = true;
            while (go)
            {


                Console.WriteLine($"Great, you selected the wonderful and amazing {student[input - 1]}");
                Console.WriteLine($"What would you like to know more about {student[input - 1]}");
                Console.WriteLine("Hometown? or Food?");
                string input2 = Console.ReadLine().ToLower();
                if (input2 == "hometown")
                {
                    Console.WriteLine($"{student[input - 1]} is from {homeTown[input - 1]}");
                }
                else if (input2 == "food")
                {
                    Console.WriteLine($"{student[input - 1]} really likes {food[input - 1]}");
                }
               
            }
        }
        */
        public static void DisplayPeoples(string[] peoples)
        {
            for (int i = 0; i < peoples.Length; i++)

            {
                Console.WriteLine($"{i + 1}: {peoples[i]}"); //i+1 to make 0 come out as 1
            }
        }


        public static int UserInput()
        {
            return int.Parse(Console.ReadLine());
        }

        public static bool Proceed()
        {
            Console.WriteLine($"{"{y}"} to continue {"n"} to quit");

            char response = Console.ReadKey(true).KeyChar;

            if (response == 'y')
            {
                return true;
            }

            else if (response != 'y')
            {
                return false;
            }
            else
            {
                return Proceed();
            }
        }
    }

}
    

