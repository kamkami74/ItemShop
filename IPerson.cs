using System;
using static System.Console;

namespace ItemShop{
    public interface IPerson
    {
        public string UserName { get; }
        public decimal Balance { get; }

        public void AddBalance(decimal item);
        public void RemoveBalance(decimal item);
    }
}