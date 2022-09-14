namespace Warehouse
{
    public class Warehouse 
    {
        private List<Stock> stockItems;
        public List<Stock> StockItems
        {
            get
            {
                return new List<Stock> (stockItems);
            }
         
        }
        private List<Transaction> transactions;
        public List<Transaction> Transactions
        {
            get
            {
                return new List<Transaction>(transactions);
            }
        }

        public Warehouse()
        {
            stockItems = new List<Stock>();
            transactions = new List<Transaction>();
        }

        public void AddStock(List<Stock> items)
        {
            stockItems = items;

        }

        public void RemoveStock(Item item, uint quantityToRemove)
        {
            foreach(Stock items in stockItems)
            if(items.Item == item)
            {
                items.Amount -= quantityToRemove;

            }
            
        }

        public void GenerateReport()
        {
            foreach(Stock items in stockItems)
            {
                Console.WriteLine($"{items.Amount} {items.Item.Name} available, priced {items.RetailPriceForItem} each. ");
            }
            
        }

    }

}