using System;
using System.Collections.Generic;
namespace Open_Houseproj
{
    class Room
    {
        public string Name { get; set; }
        public bool HasHardwoods { get;  set; }
        public int NumberOfWindows { get; set; }
        public List<string> Descriptions { get; set; } = new List<string>();

        public Room(string name, bool hasHardwoods, int numberOfWIndows)
        {
            Name = name;
            HasHardwoods = hasHardwoods;
            NumberOfWindows = numberOfWIndows;
        }

        public void ShowRoom()
        {
            string answer = Program.GetUserResponse("Would you like to see the " + Name + "?");
            if (Program.IsAffirmative(answer))
            {
                if (HasHardwoods)
                {
                    Console.WriteLine("It has hardwood floors.");
                }
                else
                {
                    Console.WriteLine("It does not have hardwood floors.");
                }
                Console.WriteLine("It has " + NumberOfWindows + " windows.");

                foreach (string description in Descriptions)
                {
                    Console.WriteLine(description);
                }
            }
        }
    }
}
