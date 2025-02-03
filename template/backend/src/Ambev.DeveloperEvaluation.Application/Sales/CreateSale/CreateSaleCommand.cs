using MediatR;
using System.Collections.Generic;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class CreateSaleCommand : IRequest<CreateSaleResult>
    {
        public string Customer { get; set; } = string.Empty;
        public string Branch { get; set; } = string.Empty; // Adicionando a propriedade Branch
        public List<SaleItemCommand> Items { get; set; } = new List<SaleItemCommand>();
    }

    public class SaleItemCommand
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
    }
}
