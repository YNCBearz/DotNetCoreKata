namespace DotNetCoreKata.Services.TrafficLight;

public static class TrafficLightSystem
{
    public static ITrafficLight NextColor(ITrafficLight trafficLight)
    {
        if (trafficLight.Color() == "Red")
        {
            return new Services.TrafficLight.TrafficLight("Green");
        }
        else if (trafficLight.Color() == "Green")
        {
            return new Services.TrafficLight.TrafficLight("Yellow");
        }
        else if (trafficLight.Color() == "Yellow")
        {
            return new Services.TrafficLight.TrafficLight("Red");
        }

        return trafficLight;
    }
}