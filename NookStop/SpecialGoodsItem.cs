namespace NookStop
{
    public class SpecialGoodsItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int ItemsLeft { get; set; }

        public SpecialGoodsItem(string name, int price, int itemsLeft)
        {
            Name = name;
            Price = price;
            ItemsLeft = itemsLeft;
        }
    }
}