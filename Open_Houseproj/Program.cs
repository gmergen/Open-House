using System;

namespace Open_Houseproj
{
    class Program
    {
        static string GetUserResponse(string question) 
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            return response;
        }

        static bool IsAffirmative(string userResponse) 
        {
            userResponse = userResponse.ToUpper();

            if (userResponse == "YES" || userResponse == "YEAH" || userResponse == "PLEASE")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Thank you for coming to our open house today!");

            string name = GetUserResponse("What is your name?"); 

            Console.WriteLine("It's nice to meet you, " + name + ".");

            string answer = GetUserResponse("Would you like to see the house?"); 

            if (IsAffirmative(answer)) 
            {
                answer = GetUserResponse("Would you like to start with the kitchen first?");

                if (IsAffirmative(answer))
                {
                    Console.WriteLine("It has lovely granite countertops");
                    Console.WriteLine("Also, plenty of room to cook your meals!");

                    Console.WriteLine("Will you be needing a refridgerator?");
                    answer = Console.ReadLine();

                    if (IsAffirmative(answer))
                    {
                        Console.WriteLine("Sorry, it doesn't come with the house!");
                    }
                    else
                    {
                        Console.WriteLine("Good, because it does not come with the house!");
                    }
                Console.WriteLine("Here is the living room! Plenty of room for the whole family!");
                Console.WriteLine("Do you plan on starting a family here?");
                        answer = Console.ReadLine();
                    if (IsAffirmative(answer))
                    {
                        Console.WriteLine("That's great! There is an extra bedroom for kids in the future!");
                    }
                    else
                    {
                        Console.WriteLine("Well there is an extra bedroom if you ever have any guests stay with you!");
                    }

                }
                else
                {
                    Console.WriteLine("Okay, we shall start with a different room!");
                    Console.WriteLine("Here is the living room! Plenty of room for the whole family!");
                    Console.WriteLine("Do you plan on starting a family here?");
                    answer = Console.ReadLine();
                    if (IsAffirmative(answer))
                    {
                        Console.WriteLine("That's great! There is an extra bedroom for kids in the future!");
                    }
                    else
                    {
                        Console.WriteLine("Well there is an extra bedroom if you ever have any guests stay with you!");
                    }
                }
                Console.WriteLine("Let's take a look at the master bedroom!");
                Console.WriteLine("The master bathroom consists of his and hers vanities and a walk in shower and a large bath tub!");
                Console.WriteLine("Lastly, we will go downstairs and checkout the finished basement! Would you like to see it?");
                answer = Console.ReadLine();
                if (IsAffirmative(answer))
                {
                    Console.WriteLine("Great! Lets head down there!");
                    Console.WriteLine("There are three finished rooms perfect for anything you can imagine! Like a home theatre or home gym, the possiblities are endless!");
                }
                else
                {
                    Console.WriteLine("That's fine! We will let you be surprised by it!");
                }
                Console.WriteLine("Well, that is that! Thank you for coming to the open house! We look forward to hearing from you!");
                Console.WriteLine("Should I go ahead and start the paper work for you?");
                answer = Console.ReadLine();
                if (IsAffirmative(answer))
                {
                    Console.WriteLine("Fantastic! I had a good feeling about you! You won't regret it!");
                }
                else
                {
                    Console.WriteLine("That is okay! Take a few days and sleep on it! Have a good day!");
                }
            }
            else
            {
                Console.WriteLine("Oh okay, well it was nice to meet you!");

                Console.WriteLine("Would you like to take a one-sheet?");
                answer = Console.ReadLine();

                if (IsAffirmative(answer))
                {
                    Console.WriteLine("Here you go! Tell your friends about it!");
                }
                else
                {
                    Console.WriteLine("Alright, that's fine! Have a nice day!");
                }
            }

            Console.ReadLine();
        }
    }
}
