using Altan.Application.Contract.Dtos;

namespace Altan.Application.Contract.Organizations.Dto
{
    public class GetAllTransactionsInput : PagedInput
    {
        public int OrganizationId { get; set; }
    }
}