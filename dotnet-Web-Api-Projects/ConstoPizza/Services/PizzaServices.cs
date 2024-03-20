using ConstoPizza.Models;

namespace ConstoPizza.Services
{
    public class PizzaServices
    {
        static int id = 0;
        static List<Pizza> Pizzas { get;}
        static PizzaServices()
        {
            Pizzas=new List<Pizza>
            {
                new Pizza {Id=++id, Name="Margherita", IsGlutenFree=false},
                new Pizza {Id=++id, Name="Pepperoni", IsGlutenFree=false},
                new Pizza {Id=++id, Name="Hawaiian", IsGlutenFree=false},
                new Pizza {Id=++id, Name="Veggie", IsGlutenFree=true},
                new Pizza {Id=++id, Name="Vegan", IsGlutenFree=true}
            };
        }
        public static List<Pizza> GetAllPizzas()
        {
            return Pizzas;
        }
        public static Pizza GetPizzaById(int id)
        {
            return Pizzas.FirstOrDefault(p=>p.Id==id);
        }

        public static void AddPizza(Pizza pizza)
        {
            pizza.Id=++id;
            Pizzas.Add(pizza);
        }
        public static void DeletePizza(int id)
        {
            var pizza = Pizzas.FirstOrDefault(p=>p.Id==id);
            if(pizza!=null)
            {
                Pizzas.Remove(pizza);
            }
        }
        public static void UpdatePizza(Pizza pizza)
        {
            var oldPizza = Pizzas.FirstOrDefault(p=>p.Id==pizza.Id);
            if(oldPizza!=null)
            {
                oldPizza.Name=pizza.Name;
                oldPizza.IsGlutenFree=pizza.IsGlutenFree;
            }
        }
    }
}
