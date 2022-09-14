namespace Warehouse
{
    public class Transaction  
    {
        public DateTime TimeStamp { get; }

        public List<Stock> Items { get; }

        public decimal TotalAmount
        {
            get
            {
                decimal total =0;
                foreach(Stock stockItem in Items)
                {
                    total += stockItem.TotalValue;
                }
                return total;
            }
            
        }
        public bool IsRetail { get; }
        public string AccountId { get; }
        public string TransactionId { get; }

        public Transaction
        (
            DateTime timeStamp,
            List<Stock> items,
            bool isRetail,
            string accountId,
            string transactionId
        )
        {
            TimeStamp = timeStamp;
            Items = items;
            IsRetail = isRetail;
            AccountId = accountId;
            TransactionId = transactionId;
        }
    }
}
