using System.Collections.Generic;
using System.Threading.Tasks;
using Altan.Application.Contract.Dtos;
using Altan.Application.Contract.Organizations;
using Altan.Application.Contract.Organizations.Dto;
using Altan.Application.Contract.Organizations.Dto.Transactions;
using Altan.Core;
using Altan.Core.Shared.Exceptions;
using Altan.Core.Transactions;

namespace Altan.Application.Organizations
{
    public class OrganizationAppService : AppService, IOrganizationAppService
    {
        private readonly IRepository<Transaction> _transactionRepository;

        public OrganizationAppService(IRepository<Transaction> transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public Task Create(CreateOrganizationInput input)
        {
            throw new UserFriendlyException();
        }

        public Task Update(UpdateOrganizationInput input)
        {
            throw new UserFriendlyException();
        }

        public Task Delete(BaseEntityDto input)
        {
            throw new UserFriendlyException();
        }

        public Task ChangeStatus(ChangeStatusInput input)
        {
            throw new UserFriendlyException();
        }

        public Task AcceptSubscriptionRequest(BaseEntityDto input)
        {
            throw new UserFriendlyException();
        }

        public Task RejectSubscriptionRequest(BaseEntityDto input)
        {
            throw new UserFriendlyException();
        }

        public Task<IReadOnlyList<OrganizationDto>> GetOrganizations()
        {
            var transactions = _transactionRepository.GetAll();

            throw new UserFriendlyException();
        }

        public Task<PagedResult<TransactionDto>> GetTransactions(GetAllTransactionsInput input)
        {
            throw new UserFriendlyException();
        }
    }
}