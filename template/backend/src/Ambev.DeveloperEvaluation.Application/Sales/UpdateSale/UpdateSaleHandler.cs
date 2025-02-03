using Ambev.DeveloperEvaluation.Common.Exceptions;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale
{
    public class UpdateSaleHandler : IRequestHandler<UpdateSaleCommand, UpdateSaleResult>
    {
        private readonly ISaleRepository _saleRepository;

        public UpdateSaleHandler(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        public async Task<UpdateSaleResult> Handle(UpdateSaleCommand request, CancellationToken cancellationToken)
        {
            var sale = await _saleRepository.GetSaleByIdAsync(request.SaleNumber);
            if (sale == null)
                throw new NotFoundException("Sale not found");

            // Atualize a venda com os dados do comando
            // Se estiver lidando com itens da venda, pode ser necessário fazer mais lógica aqui
            foreach (var item in sale.Items)
            {
                if (item.Product == request.Product)
                {
                    item.Quantity = request.Quantity;
                    item.UnitPrice = request.UnitPrice;
                    item.Discount = request.Discount;
                }
            }

            await _saleRepository.UpdateSaleAsync(sale); // Certifique-se de que UpdateAsync está implementado

            return new UpdateSaleResult { Success = true };
        }
    }
}
