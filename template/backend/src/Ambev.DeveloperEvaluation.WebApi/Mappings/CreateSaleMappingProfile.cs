using Ambev.DeveloperEvaluation.Application.Sales;
using Ambev.DeveloperEvaluation.WebApi.Sales.CreateSale;
using AutoMapper;

public class CreateSaleMappingProfile : Profile
{
    public CreateSaleMappingProfile()
    {
        CreateMap<CreateSaleRequest, CreateSaleCommand>()
            .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));

        CreateMap<SaleItemRequest, SaleItemCommand>();
    }
}
