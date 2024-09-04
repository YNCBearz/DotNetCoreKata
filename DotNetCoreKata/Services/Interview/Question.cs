namespace DotNetCoreKata.Services.Interview;

public class Question
{
    public bool IsPowerOfTwo(int input)
    {
        if (input <= 0)
        {
            return false;
        }
        
        return (input & (input - 1)) == 0;
    }
}