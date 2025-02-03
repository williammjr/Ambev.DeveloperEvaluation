namespace Ambev.DeveloperEvaluation.WebApi.Sales.CreateSale;

public class CreateSaleRequest
{
    public DateTime SaleDate { get; set; }
    public string Customer { get; set; }
    public string Branch { get; set; }
    public List<SaleItemRequest> Items { get; set; }
}

public class SaleItemRequest
{
    public string Product { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}
