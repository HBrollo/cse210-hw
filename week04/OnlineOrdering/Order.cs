public class Order()
{
    private List<Product> productList = new List<Product>();
    private Customer newCustomer;

    public void setCustomer(Customer customer)
    {
        newCustomer = customer;
    }
    public void addProduct(Product newProduct)
    {
        productList.Add(newProduct);
    }
    public int totalCost()
    {
        int productSum = 0;
        foreach (Product productItem in productList)
        {
            productSum += productItem.totalPrice();
        }
        int shippingCost;
        if (newCustomer.customerInUsa())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return productSum + shippingCost;
    }

    public void packingLabel()
    {
        Console.WriteLine("Packing Label: ");
        foreach (Product productItem in productList)
        {
           Console.WriteLine(productItem.NameId());
        }

    }
    private void shippingLabel()
    {
        Console.WriteLine($"Shipping Label: Name: {newCustomer.getName()}. Address: {newCustomer.addressString()}");
        
    }

    public void displayOrder()
    {
        shippingLabel();
        packingLabel();
        Console.WriteLine($"Total cost: ${totalCost()}");
    }
}
/*Order

    Contains a list of products and a customer. 

    Can calculate the total cost of the order. 
    The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
    
    Can return a string for the shipping label.
    A shipping label should list the name and address of the customer

    Can return a string for the packing label. 
    A packing label should list the name and product id of each product in the order.
    
   

    This company is based in the USA. 
    If the customer lives in the USA, then the shipping cost is $5. 
    If the customer does not live in the USA, then the shipping cost is $35.
*/