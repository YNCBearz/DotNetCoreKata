﻿using DotNetCoreKata.DomainModels.Rgb.ColorStates;
using DotNetCoreKata.Enums;
using DotNetCoreKata.Services.Rgb;

namespace DotNetCoreKata.DomainModels;

public class RedColorState(RgbMonitor rgbMonitor) : IColorState
{
    public Color Display()
    {
        return Color.Red;
    }

    public void TurnOnRedLight()
    {
        // Do nothing
    }

    public void TurnOnGreenLight()
    {
        rgbMonitor.ToYellowColorState();
    }

    public void TurnOnBlueLight()
    {
        rgbMonitor.ToVioletColorState();
    }

    public void TurnOffRedLight()
    {
        rgbMonitor.ToBlackColorState();
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