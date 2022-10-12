using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
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
        }
    }

}
