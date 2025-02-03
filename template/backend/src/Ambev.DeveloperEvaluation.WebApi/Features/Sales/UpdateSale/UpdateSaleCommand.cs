using Ambev.DeveloperEvaluation.Application.Sales;
using MediatR;

public class UpdateSaleCommand : IRequest<bool>
{
    public int SaleNumber { get; set; }
    public DateTime SaleDate { get; set; }
    public string Customer { get; set; }
    public string Branch { get; set; }
    public List<SaleItemCommand> Items { get; set; }
}
