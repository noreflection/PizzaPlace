using System.Linq;
using System.Collections.Generic;

namespace PizzaStore.Shared
{
    public class Menu
    {
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public Pizza GetPizza(int id) =>
            Pizzas.SingleOrDefault(pizza => pizza.Id == id);
    }
}
