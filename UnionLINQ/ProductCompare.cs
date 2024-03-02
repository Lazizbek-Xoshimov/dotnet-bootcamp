using ProductAndSale;
using System.Diagnostics.CodeAnalysis;

public class ProductCompare : EqualityComparer<Product>
{
    public override bool Equals(Product? product, Product? anotherProduct)
    {
        return (product?.Id == anotherProduct?.Id &&
            product?.Name == anotherProduct?.Name &&
            product?.Color == anotherProduct?.Color);
    }

    public override int GetHashCode([DisallowNull] Product product)
    {
        return $"{product.Id}{product.Name}{product.Color}".GetHashCode();
    }
}