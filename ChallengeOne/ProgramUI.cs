using MenuRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOneCafe
{
    public class ProgramUI
    {
        private readonly MenuRepo _menuRepo = new MenuRepo();

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
                Console.WriteLine("Komodo Cafe Menu\n" +
                    "1.Add New Menu Items\n" +
                    "2. Delete menu items\n" +
                    "3. View all menu items\n" +
                    "4. Close App\n");

                string OwnerInput = Console.ReadLine();

                switch (OwnerInput)
                {
                    case "1":
                        AddNewMenuItems();
                        break;
                    case "2":
                        DeleteMenuItems();
                        break;
                    case "3":
                        ViewAllMenuItems();
                        break;

                    default:
                        break;
                }
                Console.Clear();

            }
        }

        private void AddNewMenuItems()
        {
            Console.WriteLine("Add new menu item");
            Menu item = new Menu();

            Console.WriteLine("Input meal name");
            string OwnerInput = Console.ReadLine();
            item.Name = OwnerInput;

            Console.WriteLine("Add description");
            string OwnerInputDesc = Console.ReadLine();
            item.Description = OwnerInputDesc;


            Console.WriteLine("Add ingredients");
            string OwnerInputIng = Console.ReadLine();
            item.Ingredients = OwnerInputIng;

            Console.WriteLine("Enter Price");
            int OwnerInputPrice = int.Parse(Console.ReadLine());
            item.Price = OwnerInputPrice;

            bool isSuccessful = _menuRepo.AddMenuContent(item);
            if (isSuccessful == true)
            {
                Console.WriteLine("new item created");
            }
            else
            {
                Console.WriteLine("new item creation failed");
            }


            Console.ReadKey();


        }

        private void DeleteMenuItems()
        {
            Console.WriteLine("Select meal number to delete");
            int OwnerInputDelete = int.Parse(Console.ReadLine());

            bool isSuccessful = _menuRepo.DeleteMenuContent(OwnerInputDelete);
            if (isSuccessful)
            {
                Console.WriteLine($"Item number {OwnerInputDelete} was deleted");
            }
            else
            {
                Console.WriteLine("Item number {OwnerInputDelete} was not found");
            }
            Console.ReadKey();
        }

        private void ViewAllMenuItems()
        {

            List<Menu> listOfItems = _menuRepo.ShowMenuItems();
            foreach (Menu item in listOfItems)
            {
                Console.WriteLine($"MealNumber:{item.MealNumber}\n" +
                    $"MealName:{item.Name}\n" +
                    $"Price:{item.Price}\n");

            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
        //private void ViewItems()
        //{



        //    foreach (Menu item in _menuRepo.ShowMenuItems())
        //    {

        //    }


        //}
        //private void ShowMenuDetails(Menu item)
        //{
        //    Console.WriteLine();
        //}


        private void Seed()
        {
            Menu item1 = new Menu("Spaghetti Squash", "vegan spaghetti", 10, "pasta, sauce, vegatables");
            Menu item2 = new Menu("Hummus and Pita Chips", "homemade pinenut hummus and vegan pita bread", 8, "chickpeas, pita bread");
            Menu item3 = new Menu("Fried BBQ Cauliflower", "crispy fresh fried cauliflower", 7, "organic cauliflower fried in vegatable oil");

            _menuRepo.AddMenuContent(item1);
            _menuRepo.AddMenuContent(item2);
            _menuRepo.AddMenuContent(item3);


        }
    }
}
