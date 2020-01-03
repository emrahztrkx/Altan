using Altan.Core.Organizations;

namespace Altan.Application.Contract.Organizations.Dto
{
    public class CreateOrganizationInput
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public OrganizationAccessType AccessType { get; set; }
    }
}