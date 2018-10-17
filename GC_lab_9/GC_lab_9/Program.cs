using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        public static string charName;
        public static int indexNumber, characterInput, collectionLength;


        //create database for each Character. in the order of: name, voiced by, favorite color, best friend
        public static List<List<string>> collection = new List<List<string>> {
        new List<string> { "Marcaline", "Olivia Olson", "Red", "PB" },
        new List<string> { "Princess Bubble Gum", "Hynden Walch", "Pink", "Marcy" },
        new List<string> { "Finn the Human", "Jeremy Shada", "Blue", "Jake", },
        new List<string> { "Jake the Dog", "John DiMaggio", "Yellow", "Finn", },
        new List<string> { "Ice King", "Tom Kenny", "Whatever color princesses are, dude", "Gunter", },
        new List<string> { "Lumpy Space Princess", "Pendleton Ward", "Oh my glob, its purple", "Turtle Princess", },
        new List<string> { "The Lich", "Ron Perlman", "black", "The Lich doesn't have friends, duh", },
        new List<string> { "Earl of Lemongrab", "Justin Roiland", "COLORS ARE UNACCEPTABLE", "Lemongrab 2", },
        new List<string> { "Flame Princess", "Jessica DiCicco", "Orange", "Cinnamon Bun", },
        new List<string> { "Prismo", "Kumail Nanjani", "Pickle Green", "Cosmic Owl", },
        new List<string> { "BMO", "Niki Yang", "Green", "Football", },
        new List<string> { "Magic Man", "Tom Kenny", "What color is magic?", "Magic Man doesn't have friends because he's a jerk", },
        new List<string> { "N.E.P.T.R", "Andy Milonakis", "Brown, the color of pies", "BMO", },
        new List<string> { "Peppermint Buttler", "Steve Little", "Grey", "Princess Bubblegum if you consider servitude the same as friendship", },
        new List<string> { "Cosmic Owl", "M. Emmet Walsh", "Cosmic violet", "Prismo", } };

        static void Main(string[] args)

        {
            //foreach (string x in collection[0])
            //{
            //    Console.WriteLine(x);
            //}

            Console.WriteLine("Welcome to the Land of OOO.");
            Chose();


        }

        static void Chose()
        {
            while (true)
            {
                try
                {
                    collectionLength = (collection.Count);
                    // prompt user to ask about a student
                    Console.WriteLine($"Choose a number between 1 and {collectionLength} to learn about a Character: ");
                    characterInput = int.Parse(Console.ReadLine()) - 1;
                    charName = collection[characterInput][0];
                    Console.WriteLine(charName);
                    Decision();
                    Console.Clear();
                    AddToCollection();
                    Console.Clear();
                    ReRun();
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Number out of range, please pick a number between 1 and 15");

                }
                catch (FormatException)
                {
                    Console.WriteLine("Input not correct, please try again");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("You are out of range.");
                }


            }
        }
        static void ReRun()
        {
            Console.WriteLine("Would you like to learn about a different character? y/n: ");
            string goAgain = Console.ReadLine().ToLower();
            if (goAgain == "yes" || goAgain == "y")
            {
                Console.Clear();
                Chose();
            }
            if (goAgain == "no" || goAgain == "n")
            {
                Console.WriteLine("Goodbye");
                Environment.Exit(0);

            }
        }

        static void Decision()
        {
            while (true)
            {

                try
                {
                    Console.WriteLine($"Would you like to learn more about {charName}?");
                    Console.WriteLine("What else would you like to know? Type \"1\" for voice actor, \"2\" for Favorite color and \"3\" for best friend\nType \"4\" to go to the main menu: ");
                    indexNumber = int.Parse(Console.ReadLine());

                    if (indexNumber == 1)
                    {
                        Console.WriteLine($"{charName}\'s voice actor is {collection[characterInput][indexNumber]}");
                        continue;

                    }

                    if (indexNumber == 2)
                    {
                        Console.WriteLine($"{charName}\'s favorite color is {collection[characterInput][indexNumber]}");
                        continue;
                    }

                    if (indexNumber == 3)
                    {
                        Console.WriteLine($"{charName}\'s best friend is {collection[characterInput][indexNumber]}");
                        continue;
                    }
                    if (indexNumber == 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Input is invalid");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input not correct, please try again");
                }
            }

            //Console.WriteLine(collection[0].IndexOf( "Red"));
            //Console.WriteLine(collection[0][1]);
            //Console.ReadKey();

            // take that input and validate the data 
            // give proper responses according to what user asked for 
            // ask if user would like to learn about another student

            //create the original lists in alphabetical order by student name
            //when the user adds a character, insert them in alphabetically
            //
        }
        static void AddToCollection()
        {
            // give the option to add a student
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Would you like to add a character? y/n");
                string charAdd = Console.ReadLine();

                if (charAdd == "y" || charAdd == "yes")
                {
                    string nameAdd = PleaseValidateMe("Enter the name of the Character you would like to add: ");
                    string voiceAdd = PleaseValidateMe("Enter the voice actor of the Character");
                    string colorAdd = PleaseValidateMe("Enter the character's favorite color");
                    string bfAdd = PleaseValidateMe("Enter the character's best friend");
                    collection.Add(ListBuilder(nameAdd, voiceAdd, colorAdd, bfAdd));
                    continue;
                }
                if (charAdd == "n" || charAdd == "no")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid, please type y or n");
                }
            }
        }
        static List<string> ListBuilder(string nameAdd, string voiceAdd, string colorAdd, string bfAdd)
        {

            List<string> tempList = new List<string> { nameAdd, voiceAdd, colorAdd, bfAdd };
            return tempList;

        }
        static string PleaseValidateMe(string message)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine();
            while (input == " " && input == "")
            {
                Console.WriteLine("I'm sorry. " + message);
                input = Console.ReadLine();
            }
            return input;
        }

       
    }
 }

