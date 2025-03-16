using System.Text.RegularExpressions;

namespace CustomerApp;

public class Customer
{
    private string _name;
    private string _address;
    private string _email;

    public Customer()
    {
        _name = "";
        _address = "";
        _email = "me@example.com";
    }
    public Customer(string name, string address, string email)
    {
        _name = name;
        _address = address;
        _email = email;
    }
    
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public string Address
    {
        get => _address;
        set => _address = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public string Email
    {
        get => _email;
        set { 
            if (IsEmailValid(value))
                _email = value;
            else
                throw new ArgumentException($"El formato del mail no es correcto \" {value} \""); }
    }
    
    private bool IsEmailValid(string email)
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        return (Regex.IsMatch(email, pattern));
    } 
}