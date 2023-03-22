namespace DollarCoder.Models
{
    public class ItemShop
    {
        public List<FoodItems> FoodItems = new List<FoodItems>();
        public ItemShop()
        {
            FoodItems.Add(new FoodItems("Redbull", 20, 25, "./img/redbull.png"));
            FoodItems.Add(new FoodItems("CoffeToGo", 8, 8, "./img/coffetogo.jpeg"));
            FoodItems.Add(new FoodItems("Coffe", 5, 5, "./img/coffecup.jpeg"));
        }
    }
}
