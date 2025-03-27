using DotNetCoreKata.Models;

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

    public static bool IsClosure(HashSet<int> set, Func<int, int, int> operation)
    {
        foreach (var a in set)
        {
            foreach (var b in set)
            {
                if (!set.Contains(operation(a, b)))
                {
                    return false;
                }
            }
        }

        return true;
    }

    public List<BuyChickenAnswer> BuyChicken()
    {
        const int budget = 100;
        var result = new List<BuyChickenAnswer>();

        for (var roasterCount = 20; roasterCount >= 0; roasterCount--)
        {
            for (var henCount = 33; henCount >= 0; henCount--)
            {
                if (roasterCount + henCount > 100 || roasterCount * 5 + henCount * 3 > 100)
                {
                    continue;
                }
                
                var chickCount = 100 - roasterCount - henCount;

                if (chickCount % 3 != 0)
                {
                    continue;
                }

                var price = roasterCount * 5 + henCount * 3 + chickCount * 1/3;

                if (price == budget)
                {
                    result.Add(new BuyChickenAnswer(roasterCount, henCount, chickCount));
                }
            }
        }

        return result;
    }
}