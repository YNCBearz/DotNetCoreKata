namespace DotNetCoreKata.Services.Interview;

public class Question
{
    public bool IsPowerOfTwo(int input)
    {
        // if (input <= 0)
        // {
        //     return false;
        // }
        //
        // return (input & (input - 1)) == 0;

        var numberToTwo = Convert.ToString(input, 2);
        return numberToTwo.Count(x => x == '1') == 1;
    }
}