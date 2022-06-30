using FinalPizzaProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalPizzaProject.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
        new PizzasModel() { ImageTitle="mo", PizzaName="Magerita", BasePrice=2, TomatoSauce=true, Cheese=true, FinalPrice=155 },
        new PizzasModel() { ImageTitle = "images", PizzaName="Bologness", BasePrice=2, TomatoSauce=true, Cheese=true, Beef= true, FinalPrice=150},
        new PizzasModel() { ImageTitle = "ro", PizzaName="Hawaiian", BasePrice=2, TomatoSauce=true, Cheese=true, Ham= true, Pineapple = true ,FinalPrice=159},
        new PizzasModel() { ImageTitle = "nedladdning", PizzaName="Carbonara", BasePrice=2, TomatoSauce=true, Cheese=true, Ham= true, Mushroom = true , FinalPrice=160},
        new PizzasModel() { ImageTitle = "nedladdning1", PizzaName="Mushroom", BasePrice=2, TomatoSauce=true, Cheese=true, Ham= true, Beef= true, Mushroom = true , FinalPrice=160},
        new PizzasModel() { ImageTitle = "nedladdning3", PizzaName="Pepperoni", BasePrice=2, TomatoSauce=true, Cheese=true, Ham= true, Beef= true,Peperoni= true, Mushroom = true , FinalPrice=165},
        new PizzasModel() { ImageTitle = "pizza", PizzaName="Vetgetarian", BasePrice=2, TomatoSauce=true, Cheese=true, Ham= true, Peperoni= true, Mushroom = true , FinalPrice=169},
        new PizzasModel() { ImageTitle = "pizzatime", PizzaName="Pizza sausage", BasePrice=2, TomatoSauce=true, Cheese=true, Ham= true, Peperoni= true , FinalPrice=169},
        new PizzasModel() { ImageTitle = "bestpizza", PizzaName="Pizza kebab", BasePrice=2, TomatoSauce=true, Cheese=true, Beef= true, Peperoni= true , FinalPrice=169}
        };
        public void OnGet()
        {
        }
    }
}
