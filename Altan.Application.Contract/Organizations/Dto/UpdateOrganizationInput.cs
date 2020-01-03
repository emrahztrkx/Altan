using Altan.Application.Contract.Dtos;
using Altan.Core.Organizations;

namespace Altan.Application.Contract.Organizations.Dto
{
    public class UpdateOrganizationInput : BaseEntityDto
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public OrganizationAccessType AccessType { get; set; }
    }
}