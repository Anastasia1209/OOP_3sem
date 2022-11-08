using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    static class StatisticOperation
    {
        //сумма элементов
        public static string SumOfSet(this MySet first)
        {
            string sumSet = "";
            foreach(string sum in first.collection)
            {
                sumSet += sum;
            }
            return sumSet;
        }

        //разница между макс и мин элементами
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

        //количество элементов
        public static int NumOfElem(this MySet first)
        {
            int numOfEl = 0;
            foreach(string numEl in first.collection)
            {
                numOfEl++;
            }
            return numOfEl;
        }

        //точка в конце строки
        public static MySet AddDot(this MySet first)
        {
            foreach(string strDot in first.collection)
            {
                strDot.Insert(strDot.Length - 1, ".");
            }
            return first;
        }
        //перегрузка
        public static string AddDot(this string first)
        {
            first.Insert(first.Length - 1, ".");
            return first;
        }
        //удаление пустого элемента
        public static MySet DeleteNull(this MySet first)
        {
            foreach(string strNull in first.collection)
            {
                if(strNull == "")
                {
                    first.collection.Remove(strNull);
                }
            }
            return first;
        }
    }
}
