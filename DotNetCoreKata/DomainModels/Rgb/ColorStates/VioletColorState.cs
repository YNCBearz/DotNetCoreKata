using DotNetCoreKata.Enums;
using DotNetCoreKata.Services.Rgb;

namespace DotNetCoreKata.DomainModels.Rgb.ColorStates;

public class VioletColorState(RgbMonitor rgbMonitor): IColorState
{
    public Color Display()
    {
        return Color.Violet;
    }

    public void TurnOnRedLight()
    {
        // Do nothing
    }

    public void TurnOnGreenLight()
    {
        rgbMonitor.ToWhiteColorState();
    }

    public void TurnOnBlueLight()
    {
        // Do nothing
    }

    public void TurnOffRedLight()
    {
        rgbMonitor.ToBlueColorState();
    }

    public void TurnOffGreenLight()
    {
        // Do nothing
    }

    public void TurnOffBlueLight()
    {
        rgbMonitor.ToRedColorState();
    }
}