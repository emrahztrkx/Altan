using System.ComponentModel.DataAnnotations;

namespace Altan.Application.Contract.Dtos
{
    public class PagedAndFilteredInput
    {
        [Range(1, AppConsts.MaxPageSize)]
        public int MaxResultCount { get; set; }

        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }

        public PagedAndFilteredInput()
        {
            MaxResultCount = AppConsts.DefaultPageSize;
        }
    }
}