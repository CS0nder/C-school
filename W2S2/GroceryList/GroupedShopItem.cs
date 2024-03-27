
class GroupedShopItem
{
    public ShopItem Item;
    public int Quantity = 1;
    public GroupedShopItem(ShopItem shopitem)
    {
        this.Item = shopitem;
    }
}