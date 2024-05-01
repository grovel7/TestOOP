using System;
namespace SwinAdv
{
    public class Program
    {
        public static void Main(String[] args)
        {
            string userName, userDescription;
            Console.WriteLine("Please Enter Name");
            userName = Console.ReadLine();

            Console.WriteLine("Please Enter description");
            userDescription = Console.ReadLine();

            //create a new player
            Player player1 = new Player(userName, userDescription);

            //create two items and add them to the inventory
            Item stone = new Item(new string[] { "stone" }, "a stone", $"hit em hard! {player1.Name}" );
            Item stick = new Item(new string[] { "stick" }, "a stick", "this is a long stick");

            //create inventory
            Inventory myInventory = new Inventory();

            player1.Inventory.Put(stone);
            player1.Inventory.Put(stick);
            

            //create a new bag
            Bag myBag = new Bag(new string[] {"bag"} , $"{player1.Name}'s Bag", $"this is bag");
            player1.Inventory.Put(myBag);

            //create another item and add it to the bag
            Item blade = new Item(new string[] {"blade"} , "a blade" , "this is a blade");
            //player1.Inventory.Put(blade);
            myBag.Inventory.Put(blade);

            //loop reading commands ftom the user and gwtting the look command to execute them
            //command input from the user

            LookCommand look = new LookCommand();
            string inputCommand;
            Console.Write("COMMAND::::::");
            while(true)
            {
                Console.WriteLine("enter the command ");
                inputCommand = Console.ReadLine();

                if(inputCommand == "quit" || inputCommand == "close")
                {
                    break;
                }
                Console.WriteLine(look.Execute(player1, inputCommand.Split()));
                
            }

           



        }
    }
}



