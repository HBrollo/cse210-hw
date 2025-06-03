public class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public void setAddress(string setAdd, string setCity, string setState, string setCountry)
    {
        streetAddress = setAdd;
        city = setCity;
        state = setState;
        country = setCountry;
    }
    public bool usaLocation()
    {
        if (country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string getFullLocation()
    {
        string fullLocation = $"{streetAddress}, {city}, {state}, {country}";
        return fullLocation;
    }
}

/*Address
    
    The address contains a string for the street address, the city, state/province, and country.
    The address should have a method that can return whether it is in the USA or not.
    The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
*/