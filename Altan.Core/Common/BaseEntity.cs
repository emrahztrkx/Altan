using System;
using System.ComponentModel.DataAnnotations;

namespace Altan.Core.Common
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}