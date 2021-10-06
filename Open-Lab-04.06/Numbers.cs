using System;
using System.Collections;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            ArrayList arrayList = new ArrayList(numbers);

            for (int write = 0; write < numbers.Length; write++)
            {
                if (numbers[write] % 2 != 0)
                {
                    arrayList.Remove(numbers[write]);
                }
            }
            numbers = arrayList.ToArray(typeof(int)) as int[];
            return numbers;
        }
    }
}
