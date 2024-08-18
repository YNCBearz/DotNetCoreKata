using DotNetCoreKata.Enums;

namespace DotNetCoreKata.Services.Rgb;

public interface IRgbMonitor
{
    Color Display();
    void TurnOnLight(RgbColor rgbColor);
    void TurnOffLight(RgbColor rgbColor);
    void ToBlackColorState();
    void ToRedColorState();
    void ToGreenColorState();
    void ToBlueColorState();
    void ToYellowColorState();
    void ToMagentaColorState();
    void ToCyanColorState();
    void ToWhiteColorState();
}