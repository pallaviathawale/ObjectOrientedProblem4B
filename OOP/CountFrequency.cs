using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticeproblems
{
    internal class CountFrequency
    {

        public void FrequencyOfElement()
        {
            int[] array = { 1, 1,2, 0, 10, 7,25,17,8 };

            Array.Sort(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                int count = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine("Element: " + array[i] + " with frequency: " + count);
                }

            }
        }
        
    }
    
}
