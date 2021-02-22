using System;
using System.Collections.Generic;

namespace Assignment
{
    class VendingMachine
    {
        private List<Item> inventory = new List<Item>();
        private double totalPrice;


        // Add item to the inventory
        public void addItem(Item item)
        {
            inventory.Add(item);
        }

        public void subtractQuantity(int index)
        {
            inventory[index].setQuantity(inventory[index].getQuantity() - 1);
        }

        public void addPrice(int index)
        {
            totalPrice += inventory[index].getPrice();
        }

        // Return the inventory
        public List<Item> getInventory()
        {
            return inventory;
        }

        // prints out all of the items in the vending machine
        public void printItems()
        {
            for (int i = 1; i <= inventory.Count; i++)
            {
                System.Console.WriteLine($"{i} - {inventory[i - 1].getName()} {inventory[i - 1].getPrice()}");

            }
        }

        // prints out stock and the total price of all bought items
        public void printInventory()
        {
            System.Console.WriteLine("Inventory in Vending Machine");
            for (int i = 0; i < inventory.Count; i++)
            {
                System.Console.WriteLine($"{inventory[i].getQuantity()} {inventory[i].getName()}");
            }
            System.Console.WriteLine($"{totalPrice:C} collected from sales");
        }

    }
}