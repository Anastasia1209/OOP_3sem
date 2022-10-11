using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    static class StatisticOperation
    {
        public static string SumOfSet(this MySet first)
        {
            string sumSet = "";
            foreach(string sum in first.collection)
            {
                sumSet += sum;
            }
            return sumSet;
        }

        public static int DiffMaxMin(this MySet first)
        {
            int maxLen = 0;
            int minLen = 0;
            foreach(string num in first.collection)
            {
                if (num.Length > maxLen)
                {
                    maxLen = num.Length;
                }
                if (num.Length < minLen)
                {
                    minLen = num.Length;
                }
            }
            return  maxLen - minLen;
        }

        public static int NumOfElem(this MySet first)
        {
            int numOfEl = 0;
            foreach(string numEl in first.collection)
            {
                numOfEl++;
            }
            return numOfEl;
        }

    }
}
