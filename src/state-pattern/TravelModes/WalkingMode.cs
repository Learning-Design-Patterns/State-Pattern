public class WalkingMode : ITravelMode
{
    public object GetDirection()
    {
        return "This the Direction for Walking Mode!";
    }

    public object GetEta()
    {
        return "This the ETA for Walking Mode!";
    }
}