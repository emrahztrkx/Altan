using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Altan.Core.Common;
using Altan.Core.Users;

namespace Altan.Core.Organizations
{
    public class Organization : FullAuditedEntity
    {
        private List<OrganizationSubscription> _subscriptions = new List<OrganizationSubscription>();
        private OrganizationAccessType _organizationAccessType = CoreConsts.OrganizationAccessType;
        private bool _isActive = CoreConsts.OrganizationIsActive;

        protected Organization()
        {
        }

        public Organization(List<OrganizationSubscription> subscriptions)
        {
            _subscriptions = subscriptions;
        }


        public string Name { get; set; }

        public bool IsActive => _isActive;

        public OrganizationAccessType AccessType => _organizationAccessType;

        public void ChangeAccessType(OrganizationAccessType type)
        {
            // check rules...

            _organizationAccessType = type;
        }

        public void ChangeStatus(bool isActive)
        {
            _isActive = isActive;
        }

        // navigation props
        public IReadOnlyCollection<OrganizationSubscription> Subscriptions => _subscriptions;
    }
}