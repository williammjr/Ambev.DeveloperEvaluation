namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Sale
    {
        public int SaleNumber { get; set; }
        public Guid Id { get; set; }
        public DateTime SaleDate { get; set; }
        public string Customer { get; set; }
        public decimal TotalSaleAmount { get; set; }
        public string Branch { get; set; }
        public List<SaleItem> Items { get; set; } = new List<SaleItem>();
        public bool IsCancelled { get; set; }

        public void Cancel()
        {
            IsCancelled = true;
        }

        public void AddItem(SaleItem item)
        {
            if (item.Quantity > 20) throw new Exception("Cannot sell more than 20 items");
            if (item.Quantity < 4) item.Discount = 0;
            else if (item.Quantity >= 10) item.Discount = 0.2m;
            else if (item.Quantity >= 4) item.Discount = 0.1m;

            Items.Add(item);
        }
    }

    public class SaleItem
    {
        public int SaleNumber { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount => Quantity * UnitPrice * (1 - Discount / 100);
    }

}
