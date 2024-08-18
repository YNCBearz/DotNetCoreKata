using DotNetCoreKata.Enums;
using DotNetCoreKata.Services.Rgb;

namespace DotNetCoreKata.DomainModels.Rgb;

public class WhiteColorState(IRgbMonitor rgbMonitor): IColorState
{
    public Color Display()
    {
        return Color.White;
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
        // Do nothing
    }

    public void TurnOffRedLight()
    {
        rgbMonitor.ToCyanColorState();
    }

    public void TurnOffGreenLight()
    {
        rgbMonitor.ToMagentaColorState();
    }

    public void TurnOffBlueLight()
    {
        rgbMonitor.ToYellowColorState();
    }
}