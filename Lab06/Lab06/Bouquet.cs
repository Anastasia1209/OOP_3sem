using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public abstract class Bouquet
    {
        private int costOfBouquet;
        public int CostOfBouquet
        {
            get { return costOfBouquet; }
            set { costOfBouquet = value; }
        }
        public Bouquet(int costBouq)
        {
            costOfBouquet = costBouq;
            if(costBouq > 1000)
            {
                throw new CostException("Рада, что готов отдать на цветы так много, но это слишком:)", costBouq);
            }
        }
        public override string ToString()
        {
            return $"Тип: {this.GetType()}, цена: {CostOfBouquet}";
        }

        struct bouquet
        {
            public string name;
            public int cost;

        }
        public enum Rose
        {
            red,
            white,
            pink
        }
    }
    class Rose : Bouquet
    {
        private string colorOfRose;
        public string ColorOfRose
        {
            get { return colorOfRose; }
            set { colorOfRose = value; }
        }
        public Rose(string color, int cost) : base(cost)
        {
            colorOfRose = color;
            if(color == "purple")
            {
                throw new ColorException("Ужасный цвет депрессии, где ты нашел такую розу??? такое нравится только Полине", color);
            }
        }
        public override string ToString()
        {
            return $"Тип: {this.GetType()}, цена: {CostOfBouquet}, цвет роз: {ColorOfRose}";
        }
    }
    class Gladiolus : Bouquet
    {
        private int numOfFlow;
        public int NumOfFlow
        {
            get { return numOfFlow; }
            set { numOfFlow = value; }
        }
        public Gladiolus(int num, int cost) : base(cost)
        {
            numOfFlow = num;
            if(num > 8)
            {
                throw new NumException("слишком много цветов", num);
            }
        }
        public override string ToString()
        {
            return $"Тип: {this.GetType()}, цена: {CostOfBouquet}, количество цветков: {NumOfFlow}";
        }
    }
    sealed class Paper : Bouquet
    {
        private string typeOfPaper;
        public string TypeOfPaper
        {
            get { return typeOfPaper; }
            set { typeOfPaper = value; }
        }
        public Paper(string type, int cost) : base(cost)
        {
            typeOfPaper = type;
            if(type == "cellophane")
            {
                throw new TypeException("ты дебил цветы в целофане дарить??? иди им задушись", cost);
            }
        }
        public override string ToString()
        {
            return $"Тип: {this.GetType()}, цена: {CostOfBouquet}, вид бумаги: {TypeOfPaper}";
        }
    }

}