using DotNetCoreKata.Enums;

namespace DotNetCoreKata.Services.Rgb;

public class RgbMonitor
{
    private readonly HashSet<RgbColor> _lights = [];

    public Color Display()
    {
        if (_lights.Count == 3)
        {
            return Color.White;
        }

        if (_lights.Count == 2)
        {
            if (_lights.Contains(RgbColor.Red) && _lights.Contains(RgbColor.Green))
            {
                return Color.Yellow;
            }

            if (_lights.Contains(RgbColor.Red) && _lights.Contains(RgbColor.Blue))
            {
                return Color.Violet;
            }

            return Color.Cyan;
        }

        if (_lights.Count == 1)
        {
            return _lights.First() switch
            {
                RgbColor.Red => Color.Red,
                RgbColor.Green => Color.Green,
                RgbColor.Blue => Color.Blue,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        return Color.Black;
    }

    public void TurnOnLight(RgbColor rgbColor)
    {
        _lights.Add(rgbColor);
    }

    public void TurnOffLight(RgbColor rgbColor)
    {
        _lights.Remove(rgbColor);
    }
}