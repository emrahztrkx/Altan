#nullable enable
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Altan.Core.Users;

namespace Altan.Core.Common
{
    public class FullAuditedEntity : BaseEntity
    {
        public DateTime? CreationTime { get; set; }

        public int CreatorUserId { get; set; }

        public DateTime? ModifiedTime { get; set; }

        public int? ModifierUserId { get; set; }


        // navigation props

        [ForeignKey(nameof(CreatorUserId))] public User CreatorUser { get; set; }

        [ForeignKey(nameof(ModifierUserId))] public User? ModifierUser { get; set; }
    }
}