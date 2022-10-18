namespace Shop.Data.Models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Car _car { get; set; }
        public int _price { get; set; }

        public string ShopCartId { get; set; }

    }

}
