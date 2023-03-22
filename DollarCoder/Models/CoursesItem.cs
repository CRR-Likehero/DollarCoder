namespace DollarCoder.Models
{
    public class CoursesItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string LocalImg { get; set; } //TODO

        public CoursesItem(int id, string name, int price, string localimg)
        {
            Id = id;
            Name = name;
            Price = price;
            LocalImg = localimg;
        }

    }
}
