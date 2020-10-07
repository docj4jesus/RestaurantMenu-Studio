using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        //have a menu items list set to public...iterate through in program later

        public DateTime LastUpdated { get; }
        public List<MenuItem> Items { get; set; }

        public Menu(DateTime dateUpdated, List<MenuItem> item)
        {
            LastUpdated = dateUpdated;
            Items = item;
        }


    }
}
