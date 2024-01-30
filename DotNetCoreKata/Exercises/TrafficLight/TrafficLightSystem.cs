namespace DotNetCoreKata.Exercises.TrafficLight;

public static class TrafficLightSystem
{
    public static ITrafficLight NextColor(ITrafficLight trafficLight)
    {
        if (trafficLight.Color() == "Red")
        {
            return new Exercises.TrafficLight.TrafficLight("Green");
        }
        else if (trafficLight.Color() == "Green")
        {
            return new Exercises.TrafficLight.TrafficLight("Yellow");
        }
        else if (trafficLight.Color() == "Yellow")
        {
            return new Exercises.TrafficLight.TrafficLight("Red");
        }

        return trafficLight;
    }
}