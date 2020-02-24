public class DirectionService
{
    private readonly ITravelMode _travelMode;

    public DirectionService(ITravelMode travelMode)
    {
        _travelMode = travelMode;
    }

    public object GetDirection()
    {
        return _travelMode.GetDirection();
    }

    public object GetEta()
    {
        return _travelMode.GetEta();
    }
}