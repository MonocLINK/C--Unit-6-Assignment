using System;

namespace Assignment
{
    class Item
    {
        private String name;
        private int quantity;
        private double price;

        public Item(String name, int quantity, double price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        // Return name
        public String getName()
        {
            return name;
        }
        // Return quantity
        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int num)
        {
            quantity = num;
        }

        // Return price
        public double getPrice()
        {
            return price;
        }
    }
}