namespace DotNetCoreKata.Models;

public class BuyChickenAnswer(int RoasterCount, int HenCount, int ChickCount)
{
    public int RoasterCount { get; } = RoasterCount;
    public int HenCount { get; } = HenCount;
    public int ChickCount { get; } = ChickCount;
}