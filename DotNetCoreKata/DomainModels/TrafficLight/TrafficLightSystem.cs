namespace DotNetCoreKata.DomainModels.TrafficLight;

public static class TrafficLightSystem
{
    public static ITrafficLight NextColor(ITrafficLight trafficLight)
    {
        if (trafficLight.Color() == "Red")
        {
            return new TrafficLight("Green");
        }
        else if (trafficLight.Color() == "Green")
        {
            return new TrafficLight("Yellow");
        }
        else if (trafficLight.Color() == "Yellow")
        {
            return new TrafficLight("Red");
        }

        return trafficLight;
    }
}