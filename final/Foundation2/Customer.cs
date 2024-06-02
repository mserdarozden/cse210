public class Customer
{
    private string _name;
    private Adress _adress;
    

    public Customer(string name, Adress adress)
    {
        _name = name;
        _adress = adress;
    }

    public string GetName()
    {
        return _name;
    }

    public string getAdress()
    {
        return _adress.CreateFullAdress();
    }


    public bool IsInUSA()
    {
        return _adress.IsInUSA();
    }

}