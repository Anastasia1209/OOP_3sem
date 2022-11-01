using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab06
{
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
}