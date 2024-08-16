using DotNetCoreKata.Enums;
using DotNetCoreKata.Services.Rgb;

namespace DotNetCoreKata.DomainModels.Rgb;

public class CyanColorState(RgbMonitor rgbMonitor): IColorState
{
    public Color Display()
    {
        return Color.Cyan;
    }

    public void TurnOnRedLight()
    {
        rgbMonitor.ToWhiteColorState();
    }

    public void TurnOnGreenLight()
    {
        // Do nothing
    }

    public void TurnOnBlueLight()
    {
        // Do nothing
    }

    public void TurnOffRedLight()
    {
        // Do nothing
    }

    public void TurnOffGreenLight()
    {
        rgbMonitor.ToBlueColorState();
    }

    public void TurnOffBlueLight()
    {
        rgbMonitor.ToGreenColorState();
    }
}