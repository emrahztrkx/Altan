using System.Collections.Generic;
using System.Threading.Tasks;
using Altan.Application.Contract.Dtos;
using Altan.Application.Contract.Organizations.Dto;
using Altan.Application.Contract.Organizations.Dto.Transactions;

namespace Altan.Application.Contract.Organizations
{
    public interface IOrganizationAppService 
    {
        Task Create(CreateOrganizationInput input);

        Task Update(UpdateOrganizationInput input);

        Task Delete(BaseEntityDto input);

        Task ChangeStatus(ChangeStatusInput input);

        Task AcceptSubscriptionRequest(BaseEntityDto input);

        Task RejectSubscriptionRequest(BaseEntityDto input);

        Task<IReadOnlyList<OrganizationDto>> GetOrganizations();

        Task<PagedResult<TransactionDto>> GetTransactions(GetAllTransactionsInput input);
    }
}