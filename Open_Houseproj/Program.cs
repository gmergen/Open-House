using System;

namespace Open_Houseproj
{
    class Program
    {
        public static string GetUserResponse(string question) 
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            return response;
        }

        public static bool IsAffirmative(string userResponse) 
        {
            userResponse = userResponse.ToUpper();

            if (userResponse == "YES" || userResponse == "YEAH" || userResponse == "PLEASE" || userResponse == "YEA" || userResponse == "SURE" || userResponse == "OF COURSE" || userResponse == "YEP")
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
            Room livingRoom = new Room("Living Room", false, 4);
            livingRoom.Descriptions.Add("Plenty of space for the family!");
            livingRoom.Descriptions.Add("Also has a perfect view of the pool!");
           
            Room diningRoom = new Room("Dining Room", true, 6);
            diningRoom.Descriptions.Add("The perfect room to have an ellegant meal!");

            Room kitchen = new Room("Kitchen", false, 2);
            kitchen.Descriptions.Add("The kitchen is fully loaded with appliances, great for cooking meals!");

            Room masterBedroom = new Room("Master Bedroom", true, 3);
            masterBedroom.Descriptions.Add("The ideal place to escape all of your worldly problems, complete relaxation!");

            Room homeOffice = new Room("Home Office", false, 2);
            homeOffice.Descriptions.Add("A nice quiet place to buckle down and focus on some... coding maybe? It's a great skill to have!");

            Console.WriteLine("Welcome! Thank you for coming to our open house today!");

            string name = GetUserResponse("What is your name?"); 
            Console.WriteLine("It's nice to meet you, " + name + ".");
            string answer = GetUserResponse("Would you like to see the house?");

            if (IsAffirmative(answer))
            {
                livingRoom.ShowRoom();
                diningRoom.ShowRoom();
                kitchen.ShowRoom();
                masterBedroom.ShowRoom();
                homeOffice.ShowRoom();
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

            Console.WriteLine("Well that's about it! A nice quaint little house if I do say so myself!");
            Console.WriteLine("Should I go ahead and start the paperwork? :D");
            answer = Console.ReadLine();

            if (IsAffirmative(answer))
            {
                Console.WriteLine("Great! I knew I had a good feeling about you!");
            }
            else
            {
                Console.WriteLine("That's okay! Take a few days to think on it!");
                Console.WriteLine("Have a nice day!");
            }
            Console.ReadLine();
        }
    }
}
