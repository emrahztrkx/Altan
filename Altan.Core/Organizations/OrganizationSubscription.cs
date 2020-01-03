using System.ComponentModel.DataAnnotations.Schema;
using Altan.Core.Common;
using Altan.Core.Users;

namespace Altan.Core.Organizations
{
    public class OrganizationSubscription : FullAuditedEntity
    {
        public OrganizationSubscriptionStatus SubscriptionStatus { get; set; }
    }
}