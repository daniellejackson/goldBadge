using BadgesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThreeBadges
{
    class ProgramUI
    {
        private readonly BadgeRepo _badgeRepo = new BadgeRepo();
        private Dictionary<int, Badge> _badgeDatabase = new Dictionary<int, Badge>();

        public void Run()
        {
            Seed();
            RunApp();
        }

        private void RunApp()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Komodo Badges: What would you like to do?\n" +
                    "1. Add a badge\n" +
                    "2. Edit a badge\n" +
                    "3. Show all badges\n");
                string AdminInput = Console.ReadLine();
                switch (AdminInput)
                {
                    case "1":
                        AddABadge();
                        break;
                    case "2":
                        EditABadge();
                        break;
                    case "3":
                        ShowAllBadges();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }

        }


        private void AddABadge()
        {
            //light blue = being used
            //greyed out blue = not used
            Badge number = new Badge();
            List<string> badge = new List<string>();
            Console.WriteLine("What is the number on the badge");

            int AdminInput = int.Parse(Console.ReadLine());
            number.BadgeID = AdminInput;

            Console.WriteLine("What doors would you like to have access to");
            string AdminInputDoor = Console.ReadLine();
            badge.Add(AdminInputDoor);
            number.Doors = badge;
        }

        private void EditABadge()
        {
            //ask the questions
            Console.WriteLine("What Badge do you want to edit");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("What would you like to do\n" +
                "1.Delete a door\n" +
                "2. Add a door");
            string adminInputDoor = Console.ReadLine();
            if (adminInputDoor == "1")
            {
                Console.WriteLine("which door would you like to delete");
                string admintInputDelete = Console.ReadLine();
                _badgeRepo.DeleteDoor(userInput, admintInputDelete);
                Console.WriteLine("Door removed successfully");
            }
            
            if(adminInputDoor == "2")
            {
                Console.WriteLine("Which door would you like to add");
                string admintInputAddDoor = Console.ReadLine();
                foreach (var item in _badgeDatabase)
                {
                    if (item.Key== Int16.Parse(adminInputDoor))
                    {
                        item.Value.Doors.Add(admintInputAddDoor);
                        Console.WriteLine("Door added successfully");
                    }
                    else
                        Console.WriteLine("Door add failed");
                }

            }








            //return the badge
            Dictionary<int, Badge> anything = _badgeRepo.GetAllAbadges();
            foreach (KeyValuePair<int, Badge> item in anything)
            {
                if (item.Key == userInput)
                {
                    Console.WriteLine(item.Key);
                    foreach (string item2 in item.Value.Doors)
                    {
                        Console.WriteLine(item2);
                    }
                }
            }

        }

        private void ShowAllBadges()
        {
            Console.WriteLine("All Badges");
            Console.WriteLine($"{"Badge #: ",-5} {"Door Access:",-22}");
            //Console.WriteLine("Badge #:\t\tDoor Access:");
            Dictionary<int, Badge> badge = _badgeRepo.GetAllAbadges();
            foreach (KeyValuePair<int, Badge> item in badge)
            {
                Console.Write($"{item.Key,-11}");
                //Console.Write($"{item.Key}\t\t");
                foreach (string door in item.Value.Doors)
                {
                    Console.Write($"{door,-22}");
                }

            }
            Console.ReadLine();
        }

        private void Seed()
        {

            Badge badge1 = new Badge(12345, new List<string> { "A7" });
            Badge badge2 = new Badge(22345, new List<string> { "A1", "A4", "B1", "B2" });
            Badge badge3 = new Badge(32345, new List<string> { "A4", "A5" });


            _badgeRepo.AddBadgeToDatabase(badge1);
            _badgeRepo.AddBadgeToDatabase(badge2);
            _badgeRepo.AddBadgeToDatabase(badge3);




        }

    }
}
