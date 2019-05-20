using System;

namespace aspnet_paging.models
{
  public class Product
  {
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
  }
}