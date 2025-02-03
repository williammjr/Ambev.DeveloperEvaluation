using Ambev.DeveloperEvaluation.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ISaleRepository
    {
        Task<Sale> GetSaleByIdAsync(int saleNumber);
        Task<IEnumerable<Sale>> GetAllSalesAsync();
        Task AddSaleAsync(Sale sale);
        Task UpdateSaleAsync(Sale sale);
        Task DeleteSaleAsync(int saleNumber);
    }
}
