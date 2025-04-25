namespace VideoStreamRentalApp;

public class VideoTypeRegistry
{
    enum MovieType
    {
        Regular,
        Children,
    }; 

    private Dictionary<string, MovieType> _movieInfo = new Dictionary<string, MovieType>();

    public VideoTypeRegistry()
    {
        _movieInfo.Add("Regular Movie", MovieType.Regular);
        _movieInfo.Add("Children Movie", MovieType.Children);       
    }
    
    public bool IsRegular(string movie)
    {
        return _movieInfo[movie] == MovieType.Regular;       
    }
}