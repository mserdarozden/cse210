public class Adress
{
    private string _streeAdress;
    private string _city;
    private string _stateProvince;
    public string _country;

    public Adress()
    {

    }
    public Adress(string streetAdress, string city, string stateProvince, string country)
    {
        _streeAdress = streetAdress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public string CreateFullAdress()
    {
        return _streeAdress + "\n" + _city + "\n" + _stateProvince + "\n" + _country;
    }
}