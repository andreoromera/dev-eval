using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct;

/// <summary>
/// Validator for CreateProductCommand that defines validation rules for product creation command.
/// </summary>
public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateProductCommandValidator with defined validation rules.
    /// </summary>
    public CreateProductCommandValidator()
    {
        RuleFor(product => product.Title).NotEmpty().Length(3, 100);
        RuleFor(product => product.Description).NotEmpty().Length(3, 1000);
        RuleFor(product => product.Category).NotEmpty().Length(3, 100);
        RuleFor(product => product.Image).NotEmpty();
        RuleFor(product => product.Price).NotEmpty().GreaterThan(0);
    }
}