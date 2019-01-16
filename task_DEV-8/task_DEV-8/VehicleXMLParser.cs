using System.Collections.Generic;
using System.Xml;

namespace task_DEV8
{
    public class VehicleXMLParser
    {
        private List<Vehicle> listOfVehicles;

        public VehicleXMLParser()
        {
            listOfVehicles = new List<Vehicle>();
        }

        public List<Vehicle> GetVehicles(string filePath)
        {
            listOfVehicles.Clear();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filePath);
            XmlElement xRoot = xDoc.DocumentElement;

            string brand = string.Empty;
            string model = string.Empty;
            int amount = 0;
            double price = 0.0;

            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "brand")
                    {
                        brand = childnode.InnerText;
                    }

                    if (childnode.Name == "model")
                    {
                        model = childnode.InnerText;
                    }

                    if (childnode.Name == "amount")
                    {
                        amount = int.Parse(childnode.InnerText);
                    }

                    if (childnode.Name == "price")
                    {
                        price = double.Parse(childnode.InnerText);
                    }
                }

                listOfVehicles.Add(new Vehicle(brand, model, amount, price));
            }

            return listOfVehicles;
        }
    }
}