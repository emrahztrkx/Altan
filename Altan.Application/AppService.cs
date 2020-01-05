using Altan.Application.Contract;
using Altan.Core;

namespace Altan.Application
{
    public class AppService : IAppService
    {
        // current user or something else

        protected readonly IUnitOfWork _unitOfWork;

        public AppService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}