using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

/// <summary>
/// Validator for CreateProductRequest that defines validation rules for product creation.
/// </summary>
public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateProductRequestValidator with defined validation rules.
    /// </summary>
    public CreateProductRequestValidator()
    {
        RuleFor(product => product.Title).NotEmpty().Length(3, 100);
        RuleFor(product => product.Description).NotEmpty().Length(3, 1000);
        RuleFor(product => product.Category).NotEmpty().Length(3, 100);
        RuleFor(product => product.Image).NotEmpty();
        RuleFor(product => product.Price).NotEmpty().GreaterThan(0);
    }
}