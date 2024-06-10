namespace DotNetCoreKata.Services.TrafficLight;

public interface ITrafficLight
{
    string Color();
    void Check(Car car);
}