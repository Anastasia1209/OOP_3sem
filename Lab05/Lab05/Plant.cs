using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Lab05
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

    partial class Flower : Plant, IGrowing
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
       /* public void Grow()
        {
            Console.WriteLine("Цветок растет 2 месяца");
        }
        public override string ToString()
        {
            return $"Тип: {this.GetType()}, месяц: {MounthOfFlowering}, цвет: {ColorOfFlower}";
        }*/
    }
  

}
