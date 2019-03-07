using System;
namespace Open_Houseproj
{
    class Realtor
    {
        public string Name { get; set; }

        public void Speak(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }

        public string GetResponseFromBuyer(string question)
        {
            Speak(question);
            Console.ForegroundColor = ConsoleColor.White;
            string response = Console.ReadLine();
            return response;
        }

        public void ShowRoom(Room roomToShow)
        {
            string answer = GetResponseFromBuyer("Would you like to see the " + roomToShow.Name + "?");

            if (answer == "yes")
            {
                Speak("Great! This is the " + roomToShow.Name);
            }
            else
            {
                Speak("Okay, let's keep going then.");
            }
        }
    }
}