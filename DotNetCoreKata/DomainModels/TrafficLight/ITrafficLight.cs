﻿namespace DotNetCoreKata.DomainModels.TrafficLight;

public interface ITrafficLight
{
    string Color();
    void Check(Car car);
}