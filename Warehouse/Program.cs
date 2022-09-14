using System;

namespace Warehouse
{
    class Program 
    {
        public static void Main ()
        {
        Warehouse warehouse = new Warehouse();

        Item bike = new Item("bike");
        Item car = new Item ("car");

        List<Stock> items = new List<Stock> 
        {
            new Stock(bike, 500M, 2),
            new Stock(car, 85000M, 3)
        };

        warehouse.AddStock(items);

        Console.WriteLine(" ======= Before: =======");
        Console.WriteLine("====== Items =======");
        warehouse.GenerateReport();
        Console.WriteLine();

        warehouse.RemoveStock(car, 1);

        Console.WriteLine(" ======= After: =======");
        Console.WriteLine("====== Items =======");
        warehouse.GenerateReport();
        }
    }
}
