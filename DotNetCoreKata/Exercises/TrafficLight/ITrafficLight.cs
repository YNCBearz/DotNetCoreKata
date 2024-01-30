namespace DotNetCoreKata.Exercises.TrafficLight;

public interface ITrafficLight
{
    string Color();
    void Check(Car car);
}