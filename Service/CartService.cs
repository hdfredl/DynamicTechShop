using DynamicTechShop.Model;

namespace DynamicTechShop.Service;

public class CartService
{
    private List<ProductModel> cartItems = new List<ProductModel>();

    public IReadOnlyList<ProductModel> CartItems => cartItems.AsReadOnly(); // En Readonly lista, typ som TravelPal. Allt sparas statiskt i en session bara.

    public void AddToCart(ProductModel product)
    {
        if (product != null)
        {
            product.OrderedTime = DateTime.Now;
            cartItems.Add(product); // lagrar inget i en Db, hålls bara här i session
        }
    }

    // Räkna ut alla prices
    public double CalculateTotalPrice()
    {
        return cartItems.Sum(item => item.Price);
    }

    public List<int> GetAllItemIds()
    {
        return cartItems.Select(item => item.Id).ToList();
    }

    public List<ProductModel> FetchCartItems(List<int> itemIds)
    {
        return cartItems.Where(item => itemIds.Contains(item.Id)).ToList();
    }

}
