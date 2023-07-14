using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace SimpleSerialize
{
    [Serializable]
    public class Dish
    {
        [XmlAttribute]
        public string Name;
        [XmlAttribute]
        public decimal Price;
        public Dish()
        {

        }
        public Dish(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"{this.Name} {this.Price}";
        }
        static public void Serealize_it(List<Dish> objectGrath, string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Dish>));
            using (Stream fStream = new FileStream(filename,
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlSerializer.Serialize(fStream, objectGrath);
            }
        }
        static public void Deserealize_it(string filename, out List<Dish>lst)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Dish>));
            using (Stream fStream = new FileStream(filename, FileMode.OpenOrCreate,
                FileAccess.Read))
            {
                lst = (List<Dish>)xmlSerializer.Deserialize(fStream);
            }
        }
    }
    
}
