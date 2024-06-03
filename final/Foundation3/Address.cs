public class Address
{
    private string _streeAdress;
    private string _city;
    private string _stateProvince;
    public string _country;

    public Address(string streetAdress, string city, string stateProvince, string country)
    {
        _streeAdress = streetAdress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public string CreateFullAdress()
    {
        return _streeAdress + "\n" + _city + "\n" + _stateProvince + "\n" + _country;
    }
}