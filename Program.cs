
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int lastNumberOfTheArray = digits[digits.Length - 1];
        int lastNumberOfTheArrayPlusOne = lastNumberOfTheArray + 1;

        if (lastNumberOfTheArray == 9)
        {
            int[] newDigits = new int[digits.Length + 1];
            for (int i = 0; i < digits.Length -1; i++)
            {
                newDigits[i] = digits[i];
            }
            newDigits[newDigits.Length - 2] = 1;
            newDigits[newDigits.Length - 1] = 0;

            return newDigits;
        }
        else
        {
              digits[digits.Length - 1] = lastNumberOfTheArrayPlusOne;
        }
      

        return digits;
    }


    static void Main(string[] args)
    {
        Solution s = new Solution();

        // int[] digits1 = [1, 2, 3];
        // Console.WriteLine(string.Join(", ", s.PlusOne(digits1)));

        int[] digits2 = [8, 9];
        Console.WriteLine(string.Join(", ", s.PlusOne(digits2)));
    }
}

