namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;

/// <summary>
/// API response model for GetProduct operation
/// </summary>
public class GetProductResponse
{
    /// <summary>
    /// Product title
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Product description
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Product category
    /// </summary>
    public string Category { get; set; } = string.Empty;

    /// <summary>
    /// Product image
    /// </summary>
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// Product price
    /// </summary>
    public decimal Price { get; set; }
}
