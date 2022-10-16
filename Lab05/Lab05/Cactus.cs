using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    class Cactus : Plant, IGrowing
    {
        private int numOfNeedle;
        public int NumOfNeedle
        {
            get { return numOfNeedle; }
            set { numOfNeedle = value; }
        }
        public Cactus(int needle, string mounth) : base(mounth)
        {
            numOfNeedle = needle;
        }
        public void Grow()
        {
            Console.WriteLine("Кактус растет много лет");
        }
        public override string ToString()
        {
            return $"Тип: {this.GetType()}, месяц: {MounthOfFlowering}, высота куста: {NumOfNeedle} ";
        }

    }
}
