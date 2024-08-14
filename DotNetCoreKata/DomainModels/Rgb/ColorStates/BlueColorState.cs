using DotNetCoreKata.Enums;
using DotNetCoreKata.Services.Rgb;

namespace DotNetCoreKata.DomainModels.Rgb.ColorStates;

public class BlueColorState(RgbMonitor rgbMonitor): IColorState
{
    public Color Display()
    {
        return Color.Blue;
    }

    public void TurnOnRedLight()
    {
        rgbMonitor.ToMagentaColorState();
    }

    public void TurnOnGreenLight()
    {
        rgbMonitor.ToCyanColorState();
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
        // Do nothing
    }

    public void TurnOffBlueLight()
    {
        rgbMonitor.ToBlackColorState();
    }
}