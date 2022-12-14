using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace Lab06
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
        public  Container GetContainer()
        {
            string path = "lab5.txt";
            StreamReader reader = new StreamReader(path);
            string? line;
            Container container = new Container();
            while((line = reader.ReadLine()) != null)
            {
                string[] arr = line.Split(' ');
                switch (arr[0])
                {
                    case "Rose":
                        Rose rose4 = new Rose(arr[1], Convert.ToInt32(arr[2]));
                        container.Add(rose4);
                        break;
                    case "Gladiolus":
                        Gladiolus gladiolus4 = new Gladiolus(Convert.ToInt32(arr[1]), Convert.ToInt32(arr[2]));
                        container.Add(gladiolus4);
                        break;
                    case "Paper":
                        Paper paper5 = new Paper(arr[1], Convert.ToInt32(arr[2]));
                        container.Add(paper5);
                        break;
                }
            }
            return container;
        }
        public Container GetJsonContainer()
        {
            string json = "l5.json";
            Container container = new Container();
            Rose? rose = JsonSerializer.Deserialize<Rose>(json);
            Gladiolus? glad = JsonSerializer.Deserialize<Gladiolus>(json);
            Paper? paper = JsonSerializer.Deserialize<Paper>(json);

            if (rose != null)
            {
                container.Add(rose);
            }
            if (glad != null)
            {
                container.Add(glad);
            }
            if (paper != null)
            {
                container.Add(paper);
            }
            return container;
        }
    }
}
