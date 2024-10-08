﻿using DotNetCoreKata.Enums;
using DotNetCoreKata.Services.Rgb;

namespace DotNetCoreKata.DomainModels.Rgb;

public class BlackColorState(IRgbMonitor rgbMonitor) : IColorState
{
    public Color Display()
    {
        return Color.Black;
    }

    public void TurnOnRedLight()
    {
        rgbMonitor.ToRedColorState();
    }

    public void TurnOnGreenLight()
    {
        rgbMonitor.ToGreenColorState();
    }

    public void TurnOnBlueLight()
    {
        rgbMonitor.ToBlueColorState();
    }

    public void TurnOffRedLight()
    {
        // Do nothing
    }

    public void TurnOffGreenLight()
    {
        // Do nothing
    }

    public void TurnOffBlueLight()
    {
        // Do nothing
    }
}