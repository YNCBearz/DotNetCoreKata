﻿namespace DotNetCoreKata.DomainModels.AgeOfEmpires;

public class Legs : ITransportation
{
    public string Mode()
    {
        return "legs";
    }
}