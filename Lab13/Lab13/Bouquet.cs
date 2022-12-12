using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    [Serializable]
    public class Bouquet
    {
        private int costOfBouquet;
        public int CostOfBouquet
        {
            get { return costOfBouquet; }
            set { costOfBouquet = value; }
        }

        public Bouquet()
        {
            costOfBouquet = 100;

        }
        public Bouquet(int costBouq)
        {
            costOfBouquet = costBouq;
        }
        public override string ToString()
        {
            return $"Тип: {this.GetType()}, цена: {CostOfBouquet}";
        }
    }
    [Serializable]
    public class Rose : Bouquet
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
        }
        public override string ToString()
        {
            return $"Тип: {this.GetType()}, цена: {CostOfBouquet}, цвет роз: {ColorOfRose}";
        }
    }
    [Serializable]
    class Gladiolus : Bouquet
    {
        [NonSerialized]
        //private int numOfFlow;
        public int NumOfFlow;
        
        public Gladiolus(int num, int cost) : base(cost)
        {
            NumOfFlow = num;
        }
        public override string ToString()
        {
            return $"Тип: {this.GetType()}, ценакак дела: {CostOfBouquet}, цвет роз: {NumOfFlow}";
        }
    }
    [Serializable]
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
        }
        public override string ToString()
        {
            return $"Тип: {this.GetType()}, цпривета: {CostOfBouquet}, вид бумаги: {TypeOfPaper}";
        }
    }
}
