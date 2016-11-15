using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectExample2
{
    public class ShoppingCart
    {
        private List<Item> contents;

        public ShoppingCart()
        {
            contents = new List<Item>();
        }

        public void AddItem(Item i)
        {
            contents.Add(i);
        }

        public double GetTotal()
        {
            double total = 0;
            foreach(Item i in contents)
            {
                total += i.ItemPrice;
            }
            return total;
        }

        public List<Item> GetItems()
        {
            return contents;
        }


    }
}
