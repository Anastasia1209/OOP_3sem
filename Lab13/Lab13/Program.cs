using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters;
using System.Xml;
using System.Xml.Linq;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            Rose forBin = new Rose("white", 400);
            CustomSerializer.SerializeToBinary(forBin);
            CustomSerializer.DeserializeFromBinary(ref forBin);
            Console.WriteLine($"From .bin : {forBin.ToString()}");


              Rose forSoap = new Rose("yellow", 500);
              CustomSerializer.SerializeToSoap(forSoap);
              CustomSerializer.DeserializeFromSoap(ref forSoap);

            Rose forJson = new Rose("blue", 800);
              CustomSerializer.SerializeToJson(forJson);
              CustomSerializer.DeserializeFromJson(ref forJson);
              Console.WriteLine($"From .json : {forBin.ToString()}");
  
            Bouquet forXml = new Bouquet();
            CustomSerializer.SerializeToXml(forXml);
            CustomSerializer.DeserializefromXml(ref forXml);
            Console.WriteLine($"From .xml : {forXml.ToString()}");


            // задание 3
            List<Bouquet> forXML = new List<Bouquet>();
            List<Bouquet> roses = new List<Bouquet>();

            Bouquet first = new Bouquet();
            Bouquet sec = new Bouquet();
            Bouquet third = new Bouquet();

            roses.Add(first);
            roses.Add(sec);
            roses.Add(third);


            CustomSerializer.SerializeToXml(roses);
            CustomSerializer.DeserializefromXml(ref forXML);
            foreach (var temp in forXML)
            {
                Console.WriteLine(temp.ToString());
            }

            //задание 4
            //используя XPath напишите два селектора для вашего XML-документа

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"D:\Универ\2курс\OOP_3sem\Lab13\Lab13\XML.xml");
            var xRoot = xmlDoc.DocumentElement;

            var selectNodes = xRoot.SelectNodes("*");
            foreach (object xnode in selectNodes) Console.WriteLine((xnode as XmlNode).InnerText);

            Console.WriteLine();
            var nameNodes = xRoot.SelectNodes("Name");
            foreach (object nameNode in nameNodes) Console.WriteLine((nameNode as XmlNode).Name);

            //задание 5
            XDocument Students = new XDocument();
            XElement root = new XElement("Студенты");

            XElement stud;
            XElement name;
            XAttribute year;

            stud = new XElement("student");
            name = new XElement("name");
            name.Value = "Артем";
            year = new XAttribute("year", "2003");
            stud.Add(name);
            stud.Add(year);
            root.Add(stud);

            stud = new XElement("stud");
            name = new XElement("name");
            name.Value = "Полина";
            year = new XAttribute("year", "2004");
            stud.Add(name);
            stud.Add(year);
            root.Add(stud);

            Students.Add(root);
            Students.Save(@"D:\Универ\2курс\OOP_3sem\Lab13\Lab13\NewXML.xml");

            Console.WriteLine("Inter the year for searching: ");
            string yearXML = Console.ReadLine();
            var allAlbums = root.Elements("stud");

            foreach (var item in allAlbums)
            {
                if (item.Attribute("year").Value == yearXML)
                {
                    Console.WriteLine(item.Value);
                }
            }

    }
    }
}
