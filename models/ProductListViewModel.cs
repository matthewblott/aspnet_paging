using cloudscribe.Pagination.Models;

namespace aspnet_paging.models
{
  public class ProductListViewModel
  {
    public PagedResult<Product> Products { get; set; } = null;
    
    public ProductListViewModel() => Products = new PagedResult<Product>();

    public string Query { get; set; } = string.Empty;
    
  }
  
}