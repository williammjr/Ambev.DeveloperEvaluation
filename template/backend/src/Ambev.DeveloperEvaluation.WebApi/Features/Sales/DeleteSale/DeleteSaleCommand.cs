using MediatR;

public class DeleteSaleCommand : IRequest<bool>
{
    public int SaleNumber { get; set; }
}
