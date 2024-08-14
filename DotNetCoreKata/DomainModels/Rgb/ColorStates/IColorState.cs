using DotNetCoreKata.Enums;

namespace DotNetCoreKata.DomainModels.Rgb.ColorStates;

public interface IColorState
{
    public Color Display();
    public void TurnOnRedLight();
    public void TurnOnGreenLight();
    public void TurnOnBlueLight();
    public void TurnOffRedLight();
    public void TurnOffGreenLight();
    public void TurnOffBlueLight();
}