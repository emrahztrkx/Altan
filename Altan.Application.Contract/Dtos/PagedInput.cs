using System.ComponentModel.DataAnnotations;

namespace Altan.Application.Contract.Dtos
{
    public class PagedInput
    {
        [Range(1, AppConsts.MaxPageSize)]
        public int MaxResultCount { get; set; }

        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }

        public PagedInput()
        {
            MaxResultCount = AppConsts.DefaultPageSize;
        }
    }
}