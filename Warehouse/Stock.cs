namespace Warehouse
{
    public class Stock
    {
        public Item Item { get; }
        public uint Amount { get; set; }
        private decimal retailPriceForItem;

        public decimal RetailPriceForItem
        {
             get
             {
                return retailPriceForItem;

             } 
             set
             {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException("value",value,"must be non-negative");
                }
                
                retailPriceForItem = value;
             } 
        }

        public decimal TotalValue
        {
            get
            {
                return Amount*retailPriceForItem;
            }
        }

        public Stock ( Item item, decimal retailPriceForItem, uint amount)
        {
            Item = item;
            RetailPriceForItem =retailPriceForItem;
            Amount = amount;
        }

        public Stock( Item item, decimal retailPriceForItem) : this( item, retailPriceForItem, 0) { }
               
        
    }

}