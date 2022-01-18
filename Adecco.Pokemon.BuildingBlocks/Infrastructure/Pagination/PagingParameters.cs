using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adecco.Pokemon.BuildingBlocks.Infrastructure.Pagination
{
    public class PagingParameters
    {
        /// <summary>
        /// MaxPageSize.
        /// </summary>
        private const int MaxPageSize = 20;

        private int _pageNumber = 1;
        private int _pageSize = MaxPageSize;

        /// <summary>
        /// Gets or sets pageNumber: by default set to 1.
        /// </summary>
        [FromQuery(Name = "pageNumber")]
        public int PageNumber
        {
            get
            {
                return _pageNumber;
            }
            set
            {
                _pageNumber = (value < 1) ? 1 : value;
            }
        }

        /// <summary>
        /// Gets or sets pageSize: by default set to 100 (max page size).
        /// </summary>
        [FromQuery(Name = "pageSize")]
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value < 0) || (value > MaxPageSize) ? MaxPageSize : value;
            }
        }
    }
}
