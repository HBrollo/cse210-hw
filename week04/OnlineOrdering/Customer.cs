public class Customer
{
    private string name;
    public void setName(string setName)
    {
        name = setName;
    }
    private Address customerAddress;

    public void setAddress(Address address)
    {
        customerAddress = address;
    }

    public bool customerInUsa()
    {
        return customerAddress.usaLocation();
    }

    public string getName()
    {
        return name;
    }

    public string addressString()
    {
        return customerAddress.getFullLocation();
    }

}
/*Customer

    The customer contains a name and an address.
    The name is a string, but the Address is a class.
    The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
*/