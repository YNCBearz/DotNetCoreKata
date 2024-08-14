using DotNetCoreKata.Enums;
using DotNetCoreKata.Services.Rgb;

namespace DotNetCoreKata.DomainModels.Rgb.ColorStates;

public class YellowColorState(RgbMonitor rgbMonitor): IColorState
{
    public Color Display()
    {
        return Color.Yellow;
    }

    public void TurnOnRedLight()
    {
        // Do nothing
    }

    public void TurnOnGreenLight()
    {
        // Do nothing
    }

    public void TurnOnBlueLight()
    {
        rgbMonitor.ToWhiteColorState();
    }

    public void TurnOffRedLight()
    {
        rgbMonitor.ToGreenColorState();
    }

    public void TurnOffGreenLight()
    {
        rgbMonitor.ToRedColorState();
    }

    public void TurnOffBlueLight()
    {
        // Do nothing
    }
}