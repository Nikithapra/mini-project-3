
Console.WriteLine("Asset Tracking");
//creating list items
List<Item> items = new List<Item>();
LoadTest();
while (true)
{
    Console.Write("Enter  Type: ");
    string ProductType = Console.ReadLine();

    Console.Write("Enter  Brand: ");
    string ProductBrand = Console.ReadLine();

    Console.Write("Enter  Model: ");
    string ProductModel = Console.ReadLine();

    Console.WriteLine("Enter  office:(India/Sweden/Germany/Norway) ");
    string Offices = Console.ReadLine();

    Console.WriteLine("Enter  Price in USD: ");
    double Price = Double.Parse(Console.ReadLine());

    //calculating local price based on Currency
    string Currency=null;
    float LocalPrice = 0;

    if (Offices == "India"|| Offices == "india")
    {
        Currency = "RUPEE";
        LocalPrice = (float)(Price * 79.5);
    }

    if (Offices == "Germany"|| Offices == "Spain"|| Offices == "germany" || Offices == "spain")
    {
        Currency = "EUR";
        LocalPrice = (float)(Price * 1.003);
    }
    if (Offices== "Sweden"|| Offices == "sweden")
    {
        Currency = "SEK";
        LocalPrice = (float)(Price * 10.68);
    }
    if (Offices == "Norway"|| Offices == "norway")
    {
        Currency = "NOK";
        LocalPrice = (float)(Price * 10.17);
    }

    Console.WriteLine("Enter Purchase date: ");
    string PurchaseDate = Console.ReadLine();

    DateTime date = Convert.ToDateTime(PurchaseDate);//converting to dateformat

    //creating object for class1 Item
    Item item = new Item(ProductType, ProductBrand, ProductModel,
                             Offices, date, Price, Currency, LocalPrice);

    items.Add(item); //adding to list items

    //checking exit criteria
    Console.WriteLine("do you want to continue Y/exit");
    string next = Console.ReadLine();

    if (next.ToLower().Trim() == "exit")
    {
        break;

    }

}

//sorting list by Producttype,Offices,purchasedate 
List<Item> sortitems = items.OrderBy(it => it.Producttype)
                             .ThenBy(it => it.Offices)
                             .ThenBy(it => it.PurchaseDate)
                             .ToList();

//displaying list
Console.WriteLine("-------------------------------------------------------------------------------");
Console.WriteLine("Type".PadRight(9) + "Brand".PadRight(7) + "Model".PadRight(8) +
          "Office".PadRight(10) + "PDate".PadRight(13) +"Price($)".PadRight(10) +
          "Currency".PadRight(10) + "LocPrice tdy".PadRight(10) );

Console.WriteLine("-------------------------------------------------------------------------------");




void LoadTest()
{
    Item b = new Item("Computer", "Asus", "W234", "India", DateTime.Parse("11.10.2019"), 500.00f, "RUPEE", 39784.00f);
    items.Add(b);

    b = new Item("Mobile", "Sams", "s10", "Sweden", DateTime.Parse("20.10.2019"), 1000.00f, "SEK", 10688.00f);
    items.Add(b);
    b = new Item("Mobile", "Iphone", "X", "Spain", DateTime.Parse("12.12.2020"), 500.00f, "EUR", 502.80f);
    items.Add(b);

    b = new Item("Computer", "HP", "h2", "Germany", DateTime.Parse("1.3.2020"), 900.00f, "EUR", 902.80f);
    items.Add(b);
    //creating object for 2nd class computer
    Computer c = new Computer("Computer", "lenova", "Y73", "India", DateTime.Parse("12.11.2019"), 600.00f, "RUPEE", 47700.00f);
    items.Add(c);
    //creating object for 3rd class Mobile
    Mobile m = new Mobile("Mobile", "Nokia", "n22", "Norway", DateTime.Parse("20.12.2019"), 1200.00f, "NOK", 12720.00f);
    items.Add(m);
}


foreach (var t in sortitems)
{
    var myvar = t.Test1();
    var purchasedate = t.PurchaseDate;
    var todaydate = DateTime.Now;
    var diffdate = todaydate - purchasedate;

    //checking condition for 3 years
    if (diffdate.TotalDays >= 915 && diffdate.TotalDays <= 1005) //less than 6months
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    }
    else if (diffdate.TotalDays >= 1005 && diffdate.TotalDays <= 1095)
    {
        Console.ForegroundColor = ConsoleColor.Red;//less than 3 months
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
    }

    Console.WriteLine( t.Producttype.PadRight(10) + t.ProductBrand.PadRight(7) +
         t.ProductModel.PadRight(7) + t.Offices.PadRight(10) + t.PurchaseDate.ToString("yyyy-MM-dd").PadRight(14) +
         t.Price.ToString().PadRight(10) + t.Currency.PadRight(10) +
         t.LocalPrice.ToString().PadRight(7));
}
Console.ResetColor();