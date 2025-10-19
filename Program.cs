
using System.Reflection.Metadata;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int lastNumberOfTheArray = digits[digits.Length - 1];
        int lastNumberOfTheArrayPlusOne = lastNumberOfTheArray + 1;
        // bool allNine = false; ;

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

        // 499

        for (int i = digits.Length - 1; i >= 0; i--)
        {

            if (digits[i] != 9)
            {
                digits[i] = digits[i] + 1;
                return digits;
            }
            else
            {
                if (digits.Length == 1) // 9+1 = 10
                {
                    int[] newDigits = new int[2];
                    newDigits[0] = 1;
                    newDigits[1] = 0;

                    return newDigits;
                }

                // Partir un forloop (int j = i) pour vérifier s'il y a des 9 avant et ajuster
                if (i - 1 >= 0)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        // code

                        // ajuster le i
                    }
                }
                else
                {
                    digits[i] = 0;
                    digits[i - 1] = digits[i - 1] + 1;
                }


            }

            return digits;
        }

        return digits;
        // int[] arrayOfNine = [digits.Length];
        // for (int i = 0; i < digits.Length - 1; i++)
        // {
        //     if (digits[i] == 9)
        //     {
        //         arrayOfNine[i] = 1;
        //     }
        //     else
        //     {
        //         arrayOfNine[i] = 0;
        //     }
        // }

        //     if (allNine)
        //     {
        //         int[] newDigits = new int[digits.Length + 1];

        //         newDigits[0] = 1;
        //         for (int i = 1; i < newDigits.Length - 1; i++)
        //         {
        //             newDigits[i] = 0;
        //         }

        //         return newDigits;
        //     }

        // if (lastNumberOfTheArray == 9)
        //     {


        //         int[] newDigits = new int[digits.Length + 1];
        //         for (int i = 0; i < digits.Length - 1; i++)
        //         {
        //             newDigits[i] = digits[i];
        //         }
        //         newDigits[newDigits.Length - 2] = 1;
        //         newDigits[newDigits.Length - 1] = 0;

        //         return newDigits;
        //     }
        //     else
        //     {
        //         digits[digits.Length - 1] = lastNumberOfTheArrayPlusOne;
        //     }


        // return digits;
    }


    static void Main(string[] args)
    {
        Solution s = new Solution();

        // int[] digits1 = [1, 2, 3];
        // Console.WriteLine(string.Join(", ", s.PlusOne(digits1)));

        // int[] digits2 = [8, 9];
        // Console.WriteLine(string.Join(", ", s.PlusOne(digits2)));

        // int[] digits3 = [9];
        // Console.WriteLine(string.Join(", ", s.PlusOne(digits3)));

        // int[] digits4 = [9, 9, 9];
        // Console.WriteLine(string.Join(", ", s.PlusOne(digits4)));

        // int[] digits5 = [4, 9, 9];
        // Console.WriteLine(string.Join(", ", s.PlusOne(digits5)));
    }
}

