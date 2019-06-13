using System;
using System.Collections.Generic;

namespace PizzaStore.Shared
{
    public class Basket
    {
        public Customer Customer { get; set; } = new Customer();
        public List<int> Orders { get; set; } = new List<int>();
        public bool HasPaid { get; set; } = false;

        public void Add(int pizzaId)
        {
            Console.WriteLine($"adding {pizzaId} to the card");
            Orders.Add(pizzaId);
        }

        public void RemoveAt(int index)
        {
            Orders.RemoveAt(index);
        }
    }
}
