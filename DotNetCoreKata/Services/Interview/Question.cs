namespace DotNetCoreKata.Services.Interview;

public class Question
{
    public static bool IsPowerOfTwo(int input)
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

    public static int SingleDigit(int i)
    {
        var sum = 0;
        while (i.ToString().Length > 1)
        {
            var array = i.ToString().ToArray();

            foreach (var element in array)
            {
                sum += int.Parse(element.ToString());
            }

            i = sum;
            sum = 0;
        }

        return i;
    }
}