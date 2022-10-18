namespace Shop.Data.Models
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public ushort price { get; set; }
        public string descriptionLong { get; set; }
        public string descriptionShort { get; set; }
        public string image { get; set; }
        public bool isFavourite { get; set; }
        public bool isAvailable { get; set; }
        public int categoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
