using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class CreateSaleHandler : IRequestHandler<CreateSaleCommand, CreateSaleResult>
    {
        private readonly ISaleRepository _saleRepository;

        public CreateSaleHandler(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        public async Task<CreateSaleResult> Handle(CreateSaleCommand request, CancellationToken cancellationToken)
        {
            // Criar a entidade Sale a partir do comando
            var sale = new Sale
            {
                Id = Guid.NewGuid(),
                SaleDate = DateTime.UtcNow,
                Customer = request.Customer,
                TotalSaleAmount = CalculateTotalAmount(request.Items),
                Branch = request.Branch,
                Items = request.Items.Select(item => new SaleItem
                {
                    Product = item.Product,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    // Discount and TotalAmount will be calculated in SaleItem
                }).ToList()
            };

            // Salvar a venda no repositório
            await _saleRepository.AddSaleAsync(sale);

            return new CreateSaleResult
            {
                SaleId = sale.Id,
                Customer = sale.Customer,
                TotalAmount = sale.TotalSaleAmount,
                CreatedAt = sale.SaleDate
            };
        }

        private decimal CalculateTotalAmount(IEnumerable<SaleItemCommand> items)
        {
            return items.Sum(item => item.Quantity * item.UnitPrice * (1 - CalculateDiscount(item.Quantity)));
        }

        private decimal CalculateDiscount(int quantity)
        {
            if (quantity >= 10 && quantity <= 20)
                return 0.20m; // 20% discount
            else if (quantity >= 4)
                return 0.10m; // 10% discount
            return 0; // No discount
        }
    }
}
