using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectExample2
{
    public class Display
    {
        //get items
        //display the list of items
        //get the total

        ShoppingCart cart;

        public Display()
        {
            cart = new ShoppingCart();
            GetItems();
            ShowItems();
            ShowTotal();
            PauseIt();
        }

        private void GetItems()
        {
            Console.WriteLine("Enter how many items");
            int number = int.Parse(Console.ReadLine());

            for(int i = 0;i<number; i++)
            {
                Item item = new Item();
                Console.WriteLine("Enter Item Name");
                item.ItemName = Console.ReadLine();
                Console.WriteLine("Enter Item Price");
                item.ItemPrice = double.Parse(Console.ReadLine());
                cart.AddItem(item);
            }
        }

        private void ShowItems()
        {
            List<Item> stuff = cart.GetItems();
            Console.Clear();
            foreach(Item i in stuff)
            {
                Console.WriteLine("{0}   {1}", i.ItemName, i.ItemPrice);
            }
        }

        private void ShowTotal()
        {
            Console.WriteLine("The total is {0}", cart.GetTotal());
        }

        private void PauseIt()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
