namespace VideoStreamRentalApp;

public class VideoTypeRegistry
{
    enum MovieType
    {
        Regular,
        Children,
    };

    private static Dictionary<string, MovieType> _movieInfo = new Dictionary<string, MovieType>();

    static VideoTypeRegistry()
    {
        _movieInfo.Add("Regular Title", MovieType.Regular);
        _movieInfo.Add("Children Title", MovieType.Children);
    }


    public static Movie GetMovie(string movie)
    {
        switch (_movieInfo[movie])
        {
            case MovieType.Regular:
                return new RegularMovie(movie);
            case MovieType.Children:
                return new ChildrenMovie(movie);
            default:
                return null;
        }
    }
}