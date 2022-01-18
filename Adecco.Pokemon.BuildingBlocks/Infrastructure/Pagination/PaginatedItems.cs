using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adecco.Pokemon.BuildingBlocks.Infrastructure.Pagination
{
    /// <summary>
    /// Adjust data that need to be shown.
    /// </summary>
    /// <typeparam name="T">Object type.</typeparam>
    public class PaginatedItems<T>
        where T : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedItems{T}"/> class.
        /// </summary>
        /// <param name="pageNumber">Page number.</param>
        /// <param name="pageSize">Page size.</param>
        /// <param name="totalCount">Number of total items.</param>
        /// <param name="data">Items that need to be shown.</param>
        public PaginatedItems(int pageNumber, int pageSize, long totalCount, IEnumerable<T> data)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalCount = totalCount;
            Data = data;
        }

        /// <summary>
        /// Gets page number.
        /// </summary>
        public int PageNumber { get; private set; }

        /// <summary>
        /// Gets page size.
        /// </summary>
        public int PageSize { get; private set; }

        /// <summary>
        /// Gets number of total items.
        /// </summary>
        public long TotalCount { get; private set; }

        /// <summary>
        /// Gets data that needs to be shown.
        /// </summary>
        public IEnumerable<T> Data { get; private set; }
    }
}
