using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    class Controller : Container
    {
        //стоимость
        public int CostOfBouquet()
        {
            int summ = 0;
            foreach (Bouquet cost in mainList)
            {
                summ += cost.CostOfBouquet;
            }
            return summ;
        }
        //сортировка
        public void Sort()
        {
            for (int i = 0; i < mainList.Count - 1; i++)
            {
                for (int j = 0; j < mainList.Count - i - 1; j++)
                {
                    if (mainList[j].CostOfBouquet > mainList[j + 1].CostOfBouquet)
                    {
                        Bouquet temp = mainList[j];
                        mainList[j] = mainList[j + 1];
                        mainList[j + 1] = temp;
                    }
                }
            }
        }
        //цвет цветка
        public void ColorOfRose(string color)
        {
            bool flag = false;
            foreach (Bouquet col in mainList)
            {
                if (col is Rose)
                {
                    Rose temp = col as Rose;
                    if (temp.ColorOfRose == color)
                    {
                        Console.WriteLine("В букете есть роза выбранного цвета :)");
                        flag = true;
                    }
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Розы такого цвета нет в букете :(");
            }
        }
    }
}
