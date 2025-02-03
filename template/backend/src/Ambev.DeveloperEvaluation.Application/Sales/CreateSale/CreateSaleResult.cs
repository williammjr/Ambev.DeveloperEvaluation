namespace Ambev.DeveloperEvaluation.Application.Sales
{
    /// <summary>
    /// Represents the result of a create sale operation.
    /// </summary>
    public class CreateSaleResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the created sale.
        /// </summary>
        public Guid SaleId { get; set; }

        /// <summary>
        /// Gets or sets the customer associated with the sale.
        /// </summary>
        public string Customer { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the total amount of the sale.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the sale was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}
