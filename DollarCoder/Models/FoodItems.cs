namespace DollarCoder.Models
{
    public class FoodItems
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int EnergyBonus { get; set; }

        public string LocalImg { get; set; }
        public FoodItems(string name, int price, int energyBonus, string localImg)
        {
            Name = name;
            Price = price;
            EnergyBonus = energyBonus;
            LocalImg = localImg;
        }
    }
}
