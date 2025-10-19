
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        // FIRST SOLUTION
        // int lastNumberOfTheArray = digits[digits.Length - 1];
        // int lastNumberOfTheArrayPlusOne = lastNumberOfTheArray + 1;
        // bool allNine = false;
        // int[] newDigits = new int[digits.Length + 1];

        // // Case all 9
        // foreach (var digit in digits)
        // {
        //     if (digit != 9)
        //     {
        //         allNine = false;
        //         break;
        //     }
        //     else
        //     {
        //         allNine = true;
        //     }
        // }

        // if (allNine)
        // {
        //     newDigits[0] = 1;
        //     for (int i = 1; i < newDigits.Length; i++)
        //     {
        //         newDigits[i] = 0;
        //     }

        //     return newDigits;
        // }

        // for (int i = digits.Length - 1; i >= 0; i--)
        // {

        //     // Last number not a 9
        //     if (digits[i] != 9)
        //     {
        //         digits[i] = digits[i] + 1;
        //         return digits;
        //     }
        //     else
        //     {
        //         // 9+1 = 10
        //         if (digits.Length == 1) // 9+1 = 10
        //         {
        //             newDigits[0] = 1;
        //             newDigits[1] = 0;

        //             return newDigits;
        //         }


        //         if (i - 1 >= 0)
        //         {
        //             for (int j = i - 1; j >= 0; j--)
        //             {
        //                 // 49
        //                 if (digits[j] != 9)
        //                 {

        //                     digits[i] = 0;
        //                     digits[j] = digits[j] + 1;

        //                     return digits;
        //                 }
        //                 // 499
        //                 else
        //                 {
        //                     digits[i] = 0;
        //                     digits[j] = 0;
        //                 }
        //             }
        //         }
        //         else
        //         {
        //             digits[i] = 0;
        //             digits[i - 1] = digits[i - 1] + 1;
        //         }

        //         return digits;
        //     }

        // }

        // return digits;

        // SECOND SOLUTION
        bool allNine = true;

        foreach (int digit in digits)
        {
            if (digit != 9)
            {
                allNine = false;
                break;
            }
        }

        if (allNine)
        {
            int[] result = new int[digits.Length + 1];
            result[0] = 1;

            return result;
        }

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i] = digits[i] + 1;
                return digits;
            }
            else
            {
                digits[i] = 0;
            }
        }

        return digits;
    }


    static void Main(string[] args)
    {
        Solution s = new Solution();

        // int[] digits1 = [1, 2, 3];
        // Console.WriteLine(string.Join(", ", s.PlusOne(digits1)));

        // int[] digits2 = [8, 9];
        // Console.WriteLine(string.Join(", ", s.PlusOne(digits2)));

        int[] digits3 = [9];
        Console.WriteLine(string.Join(", ", s.PlusOne(digits3)));

        // int[] digits4 = [9, 9, 9];
        // Console.WriteLine(string.Join(", ", s.PlusOne(digits4)));

        // int[] digits5 = [4, 9, 9];
        // Console.WriteLine(string.Join(", ", s.PlusOne(digits5)));

        // int[] digits6 = [4, 9];
        // Console.WriteLine(string.Join(", ", s.PlusOne(digits6)));

        // int[] digits7 = [7, 9, 9, 9, 9];
        // Console.WriteLine(string.Join(", ", s.PlusOne(digits7)));

        // int[] digits8 = [4,6,2];
        // Console.WriteLine(string.Join(", ", s.PlusOne(digits8)));

    }
}

