using System;
using static System.Console;

namespace ItemShop.Items{
    public interface Iitem
    {
        void DisplayInfo();
    }
    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }

    public class Item : Iitem
    {
        public string Name { get;private set;}
        public string Description { get;private set;}
        public decimal Price { get;private set;}
        Rarity rarity;
        
        public Item(string name,string desc,decimal price,Rarity r)
        {
            Name = name;
            Description = desc;
            Price = price;
            rarity = r;
        }

        public void DisplayInfo()
        {
            ForegroundColor = SetColor(this);
            WriteLine(Name);
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("== Description ==\n");
            WriteLine(Description + "\n");
            WriteLine("=================");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"> Price {Price:C2}\n");
            ResetColor();
        }
        public static ConsoleColor SetColor(Item i)
        {
            switch(i.rarity){
                case Rarity.Common:
                    return ConsoleColor.White;
                case Rarity.Uncommon:
                    return ConsoleColor.Green;
                case Rarity.Rare:
                    return ConsoleColor.Blue;
                case Rarity.Epic:
                    return ConsoleColor.DarkMagenta;
                case Rarity.Legendary:
                    return ConsoleColor.DarkYellow;
            }
            return ConsoleColor.White;
        }
    }
}