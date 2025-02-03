using MediatR;

public class GetSaleCommand : IRequest<GetSaleResponse>
{
    public int SaleNumber { get; set; }
}
