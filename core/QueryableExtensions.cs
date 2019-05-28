using System;
using System.Linq;
using cloudscribe.Pagination.Models;

namespace aspnet_paging.core
{
  public static class QueryableExtensions
  {
    public static PagedResult<T> GetPaged<T>(this IQueryable<T> query, int pageNumber, int pageSize) where T : class
    {
      var currentPageNum = pageNumber;
      var offset = (pageSize * currentPageNum) - pageSize;

      var pagedResult = new PagedResult<T>
      {
        Data = query
          .Skip(offset)
          .Take(pageSize)
          .ToList(),
        PageNumber = currentPageNum,
        PageSize = pageSize,
        TotalItems = query.Count()
      };

      return pagedResult;
      
    }
    
  }
  
}