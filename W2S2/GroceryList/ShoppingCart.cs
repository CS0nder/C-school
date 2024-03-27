

class ShoppingCart
{
    public List<GroupedShopItem> Groceries;
    public ShoppingCart()
    {
        this.Groceries = new();
    }
    public void AddItem(ShopItem item)
    {
        //de new groupedshopitem maakt een nieuwe groupedshopitem opbject aan zodat het in de list kan gaan
        Groceries.Add(new GroupedShopItem(item));
    }
    public void AddItem(ShopItem item, int HowMany)
    {
        for (int i = 0; i < HowMany; i++)
        {
            Groceries.Add(new GroupedShopItem(item));
        }
    }
    public GroupedShopItem? FindItem(ShopItem? item)
    {   
    
        foreach (GroupedShopItem? grocery in Groceries)
        {
            
            return Groceries.Find(x => x.Item.Equals(item));
        }
        
        return null;
    }


    public string Contents()
    {   
        string result = "";
        Dictionary<string, int> dictItem = new Dictionary<String, int>();
        foreach (GroupedShopItem item in Groceries)
        {   
           if(dictItem.ContainsKey(item.Item.Name))
           {
                dictItem[item.Item.Name]++;
           }
           else
           {
                dictItem[item.Item.Name] = 1;
           }
        }
        foreach (var item in dictItem)
        {
            result+= $"{item.Key} x {item.Value}\n";
        }
        return result;
    }

    public double TotalPrice()
    {   

        double total = 0;
        foreach (GroupedShopItem item in Groceries)
        {
            total += item.Item.Price * item.Quantity; 
        }
        return total;
    }
        

}

