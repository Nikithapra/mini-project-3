public class Item
{
    public Item(string producttype, string productBrand, string productModel, string offices, DateTime purchaseDate, double price, string currency, float localPrice)
    {
        Producttype = producttype;
        ProductBrand = productBrand;
        ProductModel = productModel;
        Offices = offices;
        PurchaseDate = purchaseDate;
        Price = price;
        Currency = currency;
        LocalPrice = localPrice;
    }

    public string Producttype { get; set; }
    public string ProductBrand { get; set; }
    public string ProductModel { get; set; }
    public string Offices { get; set; }
    public DateTime PurchaseDate { get; set; }
    public double Price { get; set; }
    public string Currency { get; set; }
    public float LocalPrice { get; set; }
     public string Test1()
       {
        return "string1";
       }

}


public class Computer : Item //inheriting parent class Item
{
    public Computer(string producttype, string productBrand, string productModel, string offices, DateTime purchaseDate, double price, string currency, float localPrice) : base(producttype, productBrand, productModel, offices, purchaseDate, price, currency, localPrice)
    {
    }
}
public class Mobile : Item  //inheriting parent class Item
{
    public Mobile(string producttype, string productBrand, string productModel, string offices, DateTime purchaseDate, double price, string currency, float localPrice) : base(producttype, productBrand, productModel, offices, purchaseDate, price, currency, localPrice)
    {
    }
}





