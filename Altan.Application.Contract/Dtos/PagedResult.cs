using System.Collections.Generic;

namespace Altan.Application.Contract.Dtos
{
    public class PagedResult<T>
    {
        public int TotalCount { get; set; }

        public IReadOnlyList<T> Items { get; set; }

        public PagedResult()
        {
        }

        public PagedResult(int totalCount, IReadOnlyList<T> items)
        {
            TotalCount = totalCount;
            Items = items;
        }
    }
}