public class GetSaleResponse
{
    public int SaleNumber { get; set; }
    public DateTime SaleDate { get; set; }
    public string Customer { get; set; }
    public string Branch { get; set; }
    public List<SaleItemResponse> Items { get; set; }
}
