using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    internal class CheckArrays
    {
        public List<string> MatchArrays(int[] arr1, int[] arr2)
        {
            List<string> list = new List<string>();
            Random random = new Random();

            for(int i=0; i<arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    list.Add("Bull");
                }
                else
                {
                    for(int j = 0; j < arr2.Length; j++)
                    {
                        if (arr1[i] == arr2[j])
                        {
                            list.Add("Cow");
                        }
                    }
                }
            }

            // Randomize the order of elements in the list
            for (int i = list.Count - 1; i > 0; i--)
            {
                int randomIndex = random.Next(i + 1);
                string temp = list[i];
                list[i] = list[randomIndex];
                list[randomIndex] = temp;
            }

            return list;
        }
    }

}
