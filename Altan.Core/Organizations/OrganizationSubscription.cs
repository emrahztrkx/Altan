using System.ComponentModel.DataAnnotations.Schema;
using Altan.Core.Common;
using Altan.Core.Users;

namespace Altan.Core.Organizations
{
    public class OrganizationUser : FullAuditedEntity
    {
        public int OrganizationId { get; set; }

        public int UserId { get; set; }

        // navigation props
        [ForeignKey(nameof(UserId))] public virtual User User { get; set; }

        [ForeignKey(nameof(OrganizationId))] public virtual Organization Organization { get; set; }
    }
}