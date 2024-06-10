namespace DotNetCoreKata.Services.TrafficLight;

public class TrafficLight(string color) : ITrafficLight
{
    public string Color()
    {
        return color;
    }

    public void Check(Car car)
    {
        if (Color() == "Green")
        {
            car.Drive();
        }
        else if (Color() == "Red")
        {
            car.Stop();
        }
        else if (Color() == "Yellow")
        {
            car.Stop();
        }
    }
}