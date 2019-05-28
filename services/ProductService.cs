using System.Collections.Generic;
using System.Linq;
using aspnet_paging.models;
using cloudscribe.Pagination.Models;
using aspnet_paging.core;

namespace aspnet_paging.services
{
  public class ProductService : IProductService
  {
    private const int DefaultPageSize = 10;
    private readonly IQueryable<Product> _products;

    public ProductService() => _products = CreateProducts();

    public PagedResult<Product> Find(int p) => _products.GetPaged(p, DefaultPageSize);
    
    private static IQueryable<Product> CreateProducts()
    {
      var categories = new string[3] { "Shoes", "Electronics", "Food" };
      
      // 65 to 90, 97 to 122
      
      // Create a list of products. 50% of them are in the Shoes category, 25% in the Electronics 
      // category and 25% in the Food category.
      var products = new List<Product>();

      var letter = 65;
      
      for (var i = 0; i < 527; i++)
      {
        var product = new Product {Name = "Product " + (i + 1)};
        
        var categoryIndex = i % 4;
        
        if (categoryIndex > 2)
        {
          categoryIndex -= 3;
        }

        product.Sku = $"{(char)letter}{i:D8}";
        product.Category = categories[categoryIndex];
        products.Add(product);

        letter += 1;

        if (letter == 90)
        {
          letter = 65;
        }
        
      }

      return products.AsQueryable();
      
    }
    
    public PagedResult<Product> FindByLetter(int p, string q)
    {
      var q0 =
        from p0 in _products
        where p0.Sku.StartsWith(q)
        select p0;
      
      return q0.GetPaged(p, DefaultPageSize);

    }

  }
  
}