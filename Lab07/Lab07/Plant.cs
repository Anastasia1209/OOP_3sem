using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Lab07
{
    interface IGrowing
    {
        void Grow();
    }
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
        public override string ToString()
        {
            return $"Тип: {this.GetType()}, месяц: {MounthOfFlowering}";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public virtual void GetInfo()
        {
            Console.WriteLine("Артем лох!");
        }
    } 
    class Bush : Plant, IGrowing
    {
        private string heightOfBush;
        public string HeightOfBush
        {
             get { return heightOfBush; }
             set { heightOfBush = value; }
        }
        private string nameOfBush;
        public string NameOfBush
        {
            get { return nameOfBush; }
            set { nameOfBush = value; }
        }
        public Bush(string height, string name, string mounth) : base(mounth)
        {
             heightOfBush = height;
            nameOfBush = name;
        }
        public void Grow()
        {
            Console.WriteLine("Куст растет 2 года");
        }
        public override string ToString()
        {
            return $"Тип: {this.GetType()}, месяц: {MounthOfFlowering}, высота куста: {HeightOfBush}, название: {NameOfBush} ";
        }
        public override void GetInfo()
        {
            Console.WriteLine("Артем куст, а я чебурашка:)");
        }
    }
     class Flower : Plant, IGrowing
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
        public void Grow()
        {
            Console.WriteLine("Цветок растет 2 месяца");
        }
        public override string ToString()
        {
            return $"Тип: {this.GetType()}, месяц: {MounthOfFlowering}, цвет: {ColorOfFlower}";
        }
    }
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
            return  $"Тип: {this.GetType()}, месяц: {MounthOfFlowering}, высота куста: {NumOfNeedle} ";
        }
       
    }
    
}
