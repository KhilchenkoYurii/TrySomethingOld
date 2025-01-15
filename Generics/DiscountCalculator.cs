namespace Generics;

public class DiscountCalculator<TProduct> where TProduct : Product
{
    public float CalculationDiscount(TProduct product)
    {
        return product.Price;
    }
}