using InvoiceManagementSystem.DAL.Entities;
using InvoiceManagementSystem.DAL.Enums;

namespace InvoiceManagementSystem.BLL.Interfaces
{
    public interface IInvoiceService
    {
        Task<Invoice> CreateInvoiceAsync(Invoice invoice);

        Task<List<Invoice>> GetAllInvoicesAsync();

        Task<Invoice?> GetInvoiceByIdAsync(int id);

        Task AddPaymentAsync(int invoiceId, decimal amount, string paymentMethod);

        Task ChangeInvoiceStatusAsync(int invoiceId, InvoiceStatus newStatus);

        Task GenerateAgingReportAsync();

        Task UpdateOverdueInvoicesAsync();

        Task CalculateDsoAsync();
    }
}

