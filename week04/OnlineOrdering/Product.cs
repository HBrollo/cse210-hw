public class Product
{
    private string name;
    private int id;
    private int price;
    private int quantity;

    public void setProduct(string setName, int setId, int setPrice, int setQuantity)
    {
        name = setName;
        id = setId;
        price = setPrice;
        quantity = setQuantity;
    }
    public int totalPrice()
    {
        return price * quantity;
    }

    public string NameId()
    {
        return $"Product name: {name}. Id: {id}";
    }

    
}
/*Product

    Contains the name, product id, price, and quantity of each product.
    The total cost of this product is computed by multiplying the price per unit and the quantity. (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
*/