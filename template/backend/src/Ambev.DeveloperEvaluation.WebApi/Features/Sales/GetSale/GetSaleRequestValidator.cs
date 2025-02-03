using FluentValidation;

public class GetSaleRequestValidator : AbstractValidator<GetSaleRequest>
{
    public GetSaleRequestValidator()
    {
        RuleFor(x => x.SaleNumber).GreaterThan(0);
    }
}
