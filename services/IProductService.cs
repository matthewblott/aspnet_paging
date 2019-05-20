using aspnet_paging.models;
using cloudscribe.Pagination.Models;

namespace aspnet_paging.services
{
  public interface IProductService
  {
    PagedResult<Product> Find(int pageNumber);
    
  }
}