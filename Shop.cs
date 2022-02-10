using System;
using System.Collections.Generic;
using ItemShop.Items;
using static System.Console;

namespace ItemShop{
    public class Shop
    {
        Player player;
        List<Item> Items;
        public string Name { get; private set; }

        public Shop(Player p,string name = "Joe's")
        {
            Items = new List<Item>();
            player = p;
            Name = name;
        }
        // Adds single item in the list
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        // Adds items in Items' List
        public void AddItems(params Item[] items)
        {
            foreach(var item in items)
            {
                Items.Add(item);
            }
        }
        // Displays contents of the shop
        public void DisplayItems()
        {
            WriteLine($">> Welcome to {Name} shop! <<");
            foreach(var item in Items)
            {
                item.DisplayInfo();
            }
        }

        // Selling items and removing balance from Player
        public void SellItem(Item i)
        {
            if(player.Balance >= i.Price)
            {
                player.RemoveBalance(i.Price);
                Items.Remove(i);
                ForegroundColor = Item.SetColor(i);
                Write(i.Name); ResetColor();
                WriteLine(" sold...");
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Unsufficent balance...");
                ResetColor();
            }
        }

        public void Run()
        {
            List<Item> temp = Items;
            DisplayItems();
            for(int i = 0; i < temp.Count;i++)
            {
                var item = temp[i];
                WriteLine($"Your balance {player.Balance:C2}");
                Write("Do you want to buy");
                ForegroundColor = Item.SetColor(item);
                WriteLine($" >> {item.Name}?");
                ResetColor();
                WriteLine(">> if you want type (Y), otherwise (N)");
                
                    string agreement = ReadLine();
                    if(agreement != ""){
                        agreement = agreement.ToUpper();

                        if(agreement[0] == 'Y')
                        {   
                            i--;
                            SellItem(item);
                        }
                        else
                        {
                            Write("Ah, I guess you don't want to buy ");
                            ForegroundColor = Item.SetColor(item); 
                            Write(item.Name); ForegroundColor = ConsoleColor.Yellow;
                            WriteLine($" at {item.Price:C2}"); ResetColor(); 
                        }
                    }
                
            }
        }
    }
}