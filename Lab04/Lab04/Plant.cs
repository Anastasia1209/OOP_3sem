using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Lab04
{
    public abstract class Plant
    {
        private string mounthOfFlowering;
        public virtual string MounthOfFlowering
        {
            get { return mounthOfFlowering; }
            set { mounthOfFlowering = value; }
        }
        public Plant(string mounthFlow)
        {
            mounthOfFlowering = mounthFlow;
        }
    } 
    class Bush : Plant
    {
        private string heightOfBush;
        public string HeightOfBush
        {
             get { return heightOfBush; }
             set { heightOfBush = value; }
        }
        public Bush(string height, string mounth) : base(mounth)
        {
             heightOfBush = height;
        }
    }
     class Flower : Plant
     {
        private string colorOfFlower;
        public string ColorOfFlower
        {
            get { return colorOfFlower; }
            set { colorOfFlower = value; }
        }
        public Flower(string color, string mounth) : base(mounth)
        {
            colorOfFlower = color;
        }
     }
    class Cactus : Plant
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
    }
    interface IGetInfo
    {
        void ToString();
    }
}
