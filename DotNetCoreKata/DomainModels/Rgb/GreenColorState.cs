using DotNetCoreKata.Enums;
using DotNetCoreKata.Services.Rgb;

namespace DotNetCoreKata.DomainModels.Rgb;

internal class GreenColorState(IRgbMonitor rgbMonitor) : IColorState
{
    public Color Display()
    {
        return Color.Green;
    }

    public void TurnOnRedLight()
    {
        rgbMonitor.ToYellowColorState();
    }

    public void TurnOnGreenLight()
    {
        // Do nothing
    }

    public void TurnOnBlueLight()
    {
        rgbMonitor.ToCyanColorState();
    }

    public void TurnOffRedLight()
    {
        // Do nothing
    }

    public void TurnOffGreenLight()
    {
        rgbMonitor.ToBlackColorState();
    }

    public void TurnOffBlueLight()
    {
        // Do nothing
    }
}