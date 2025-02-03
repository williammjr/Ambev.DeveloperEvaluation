using Ambev.DeveloperEvaluation.WebApi.Sales.CreateSale;

public class UpdateSaleRequest
{
    public DateTime SaleDate { get; set; }
    public string Customer { get; set; }
    public string Branch { get; set; }
    public List<SaleItemRequest> Items { get; set; }
}
