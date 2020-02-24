public class DrivingMode : ITravelMode
{
    public object GetDirection()
    {
        return "This the Direction for Driving Mode!";
    }

    public object GetEta()
    {
        return "This the ETA for Driving Mode!";
    }
}