using System;
using System.Collections.Generic;
using ItemShop.Items;
using static System.Console;

namespace ItemShop{
    public class Merchand : IPerson
    {
        public string UserName {get; private set;}
        public decimal Balance {get; private set;}
        
        public Merchand(string userName)
        {
            UserName = userName;
            Balance = 0;
        }

        public void AddBalance(decimal item)
        {
            
        }

        public void RemoveBalance(decimal item)
        {

        }
    }
}