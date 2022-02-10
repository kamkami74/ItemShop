using System;
using ItemShop.Items;

namespace ItemShop{

    class Program
    {
        static void Main(string[] args)
        {
            Item i = new Item("Broken Sword","IDK",15.5M,Rarity.Epic);
            Item i1 = new Item("Shield","This item was found in my garage",42.5M,Rarity.Rare);

            Player p = new Player("Givi");
            p.AddBalance(500);
            System.Console.WriteLine(p.UserName);

            Shop shop = new Shop(p);
            shop.AddItems(i,i1);
            shop.Run();
        }
    }
}