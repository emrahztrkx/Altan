using Altan.Application.Contract.Dtos;

namespace Altan.Application.Contract.Organizations.Dto.Transactions
{
    public class GetAllTransactionsInput : PagedInput
    {
        public int OrganizationId { get; set; }
    }
}