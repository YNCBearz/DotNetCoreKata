using DotNetCoreKata.DomainModels.TrafficLight;

namespace DotNetCoreKata.Services.TrafficLight;

public static class TrafficLightSystem
{
    public static ITrafficLight NextColor(ITrafficLight trafficLight)
    {
        if (trafficLight.Color() == "Red")
        {
            return new DomainModels.TrafficLight.TrafficLight("Green");
        }
        else if (trafficLight.Color() == "Green")
        {
            return new DomainModels.TrafficLight.TrafficLight("Yellow");
        }
        else if (trafficLight.Color() == "Yellow")
        {
            return new DomainModels.TrafficLight.TrafficLight("Red");
        }

        return trafficLight;
    }
}