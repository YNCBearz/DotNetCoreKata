using DotNetCoreKata.DomainModels;
using DotNetCoreKata.DomainModels.Rgb.ColorStates;
using DotNetCoreKata.Enums;

namespace DotNetCoreKata.Services.Rgb;

public class RgbMonitor
{
    private IColorState _state;
    private readonly BlackColorState _blackColorState;
    private readonly RedColorState _redColorState;
    private readonly GreenColorState _greenColorState;
    private readonly BlueColorState _blueColorState;
    private readonly YellowColorState _yellowColorState;
    private readonly VioletColorState _violetColorState;
    private readonly CyanColorState _cyanColorState;
    private readonly WhiteColorState _whiteColorState;

    public RgbMonitor()
    {
        _blackColorState = new BlackColorState(this);
        _redColorState = new RedColorState(this);
        _greenColorState = new GreenColorState(this);
        _blueColorState = new BlueColorState(this);
        _yellowColorState = new YellowColorState(this);
        _violetColorState = new VioletColorState(this);
        _cyanColorState = new CyanColorState(this);
        _whiteColorState = new WhiteColorState(this);
        _state = _blackColorState;
    }

    public Color Display()
    {
        return _state.Display();
    }

    public void TurnOnLight(RgbColor rgbColor)
    {
        var turnOnColorLightMap = new Dictionary<RgbColor, Action>
        {
            {RgbColor.Red, () => _state.TurnOnRedLight()},
            {RgbColor.Green, () => _state.TurnOnGreenLight()},
            {RgbColor.Blue, () => _state.TurnOnBlueLight()}
        };

        turnOnColorLightMap[rgbColor]();
    }

    public void TurnOffLight(RgbColor rgbColor)
    {
        var turnOffColorLightMap = new Dictionary<RgbColor, Action>
        {
            {RgbColor.Red, () => _state.TurnOffRedLight()},
            {RgbColor.Green, () => _state.TurnOffGreenLight()},
            {RgbColor.Blue, () => _state.TurnOffBlueLight()}
        };

        turnOffColorLightMap[rgbColor]();
    }

    public void ToBlackColorState()
    {
        _state = _blackColorState;
    }

    public void ToRedColorState()
    {
        _state = _redColorState;
    }

    public void ToGreenColorState()
    {
        _state = _greenColorState;
    }

    public void ToBlueColorState()
    {
        _state = _blueColorState;
    }

    public void ToYellowColorState()
    {
        _state = _yellowColorState;
    }

    public void ToVioletColorState()
    {
        _state = _violetColorState;
    }

    public void ToCyanColorState()
    {
        _state = _cyanColorState;
    }

    public void ToWhiteColorState()
    {
        _state = _whiteColorState;
    }
}