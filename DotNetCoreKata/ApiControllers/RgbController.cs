using DotNetCoreKata.Enums;

namespace DotNetCoreKata.ApiControllers;

public class RgbController
{
    private readonly HashSet<Color> _lights = [];

    public Color Display()
    {
        if (_lights.Count == 1)
        {
            return _lights.First();
        }
        
        if (_lights.Count == 3)
        {
            return Color.White;
        }
        
        if (_lights.Count == 2)
        {
            if (_lights.Contains(Color.Red) && _lights.Contains(Color.Green))
            {
                return Color.Yellow;
            }

            if (_lights.Contains(Color.Red) && _lights.Contains(Color.Blue))
            {
                return Color.Violet;
            }

            return Color.Cyan;
        }

        return Color.Black;
    }

    public void TurnOnLight(Color color)
    {
        _lights.Add(color);
    }
}