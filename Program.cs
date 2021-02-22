using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int phase = 0; // 0 = stocking, 1 = vending, 2 = end

            // stock phase vars
            String inputName;
            int inputQuantity;
            double inputPrice;

            // vending phase vars
            String inputItemBought;
            int itemBought;

            VendingMachine vendingMachine = new VendingMachine();

            // STOCKING PHASE
            while (phase == 0)
            {
                System.Console.Write("Item to stock (NA to end): ");
                inputName = Console.ReadLine();
                if (inputName.Equals("NA"))   // end loop, move on to vending phase
                {
                    phase++;
                    System.Console.WriteLine("\n#################################\n");
                }
                else    // add items to vending machine
                {
                    // input quantity
                    System.Console.Write("Quantity: ");
                    inputQuantity = Convert.ToInt32(Console.ReadLine());

                    // input price
                    System.Console.Write("Price each: ");
                    inputPrice = Convert.ToDouble(Console.ReadLine());

                    // create new item and add to vending machine
                    Item item = new Item(inputName, inputQuantity, inputPrice);
                    vendingMachine.addItem(item);
                }
            }

            // VENDING PHASE
            vendingMachine.printItems();    // let user know what's in the vending machine
            while (phase == 1)
            {
                System.Console.Write("Item to buy (NA to end): ");
                inputItemBought = Console.ReadLine();
                if (inputItemBought.Equals("NA"))   // end loop, move on to vending phase
                {
                    phase++;
                    System.Console.WriteLine("\n#################################\n");
                }
                else    // user bought an item
                {
                    // subtract quantity
                    itemBought = Convert.ToInt32(inputItemBought) - 1;  // OUTPUT IS 1 INDEXED, USER ENTERS 1 FOR 0TH INDEX, -1 TO FIX INDEXING
                    vendingMachine.subtractQuantity(itemBought);

                    // add price
                    vendingMachine.addPrice(itemBought);

                }
            }

            if (phase == 2)
            {
                vendingMachine.printInventory();
            }
        }
    }
}
