using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuRepository
{
    public class MenuRepo
    {
        

        private readonly List<Menu> _menuContent = new List<Menu>();
        private int _Count = 0;

        public bool AddMenuContent(Menu menu)
        {
            _Count++;
            menu.MealNumber = _Count;
            _menuContent.Add(menu);
            return true;
        }

        public List<Menu> ShowMenuItems()
        {
            return _menuContent;
        }

        public bool DeleteMenuContent(int mealNumber)
        {
            foreach (Menu item in _menuContent)
            {
                if (item.MealNumber == mealNumber)
                {
                    _menuContent.Remove(item);
                    return true;
                }


            }
            return false;
        }


    }
}
