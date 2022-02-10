using System;
using static System.Console;

namespace ItemShop{
    
    public class Player : IPerson
    {
        public string UserName {get;private set;}
        public decimal Balance {get;private set;}

        public Player(string userName)
        {
            UserName = userName;
            Balance = 0;
        }

        public void AddBalance(decimal item)
        {
            ForegroundColor = ConsoleColor.Yellow;
            Balance += item;
            System.Console.WriteLine($"> Your balance has raised up by {item:C2}\nCurrent Balance {this.Balance:C2}");
            ResetColor();
        }
        public void RemoveBalance(decimal item)
        {
            ForegroundColor = ConsoleColor.Red;
            Balance -= item;
            System.Console.WriteLine($"> Your balance has lowered down by {item:C2}\nCurrent Balance {this.Balance:C2}");
            ResetColor();
        }
    }
}