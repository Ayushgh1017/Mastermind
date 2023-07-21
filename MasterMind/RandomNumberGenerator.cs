using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    internal class RandomNumberGenerator
    {
        public int Random()
        {
            Random random = new Random();
            while (true)
            {
                int number = random.Next(1000, 9999);
                if (CheckDuplicate(number))
                {
                    return number;
                }
            }
        }

        private bool CheckDuplicate(int number)
        {
            string num = number.ToString();
            Dictionary<char,int> map = new Dictionary<char,int>();
            foreach (char c in num)
            {
                if (map.ContainsKey(c))
                {
                    map[c] = map[c]+1;
                }
                else
                {
                    map.Add(c, 1);
                }
            }
            foreach (char c in map.Keys)
            {
                if (map[c] <= 2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
