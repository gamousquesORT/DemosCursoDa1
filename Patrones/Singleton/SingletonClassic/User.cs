using System;

namespace SingletonClassic;

public class User 
{
    private string _name;
    private string _id;
    
    public User(string id = null, string name = null)
    {
        ID = id ?? throw new ArgumentNullException(nameof(id));
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }
    
    public string ID
    {
        set => _id = value; 
        get => _id; 
    }
    public string Name 
    { 
        set => _name = value;
        get => _name; 
    }

    public bool Equals(User other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _id == other._id;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((User) obj);
    }

    public override int GetHashCode()
    {
        return (_id != null ? _id.GetHashCode() : 0);
    }
    
}