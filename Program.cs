
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int lastNumberOfTheArray = digits[digits.Length - 1];
        int lastNumberOfTheArrayPlusOne = lastNumberOfTheArray + 1;

        digits[digits.Length - 1] = lastNumberOfTheArrayPlusOne;

        return digits;
    }


    static void Main(string[] args)
    {
        Solution s = new Solution();

        int[] digits1 = [1, 2, 3];
        Console.WriteLine(string.Join(", ", s.PlusOne(digits1))); 
    }
}

