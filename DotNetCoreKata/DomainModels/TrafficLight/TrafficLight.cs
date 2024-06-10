using DotNetCoreKata.Services.TrafficLight;

namespace DotNetCoreKata.DomainModels.TrafficLight;

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
            Car.Drive();
        }
        else if (Color() == "Red")
        {
            Car.Stop();
        }
        else if (Color() == "Yellow")
        {
            Car.Stop();
        }
    }
}