namespace Ambev.DeveloperEvaluation.Domain.Events
{
    public class SaleCreated
    {
        public int SaleNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public string Customer { get; set; }
    }

    public class SaleModified
    {
        public int SaleNumber { get; set; }
    }

    public class SaleCancelled
    {
        public int SaleNumber { get; set; }
    }

    public class ItemCancelled
    {
        public int SaleNumber { get; set; }
        public string Product { get; set; }
    }
}
