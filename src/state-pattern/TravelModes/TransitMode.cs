public class TransitMode : ITravelMode
{
    public object GetDirection()
    {
        return "This the Direction for Transit Mode!";
    }

    public object GetEta()
    {
        return "This the ETA for Transit Mode!";
    }
}