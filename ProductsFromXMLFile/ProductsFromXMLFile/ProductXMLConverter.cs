using System;
using System.Collections.Generic;
using System.Xml;

namespace ProductsFromXMLFile
{
    /// <summary>
    /// Product XMLC onverter.
    /// </summary>
    public class ProductXMLConverter
    {
        /// <summary>
        /// The products.
        /// </summary>
        private List<Product> products;


        /// <summary>
        /// Initializes a new instance of the <see cref="T:ProductsFromXMLFile.ProductXMLConverter"/> class.
        /// </summary>
        public ProductXMLConverter()
        {
            products = new List<Product>();
        }


        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns>The products.</returns>
        /// <param name="filePath">File path.</param>
        public List<Product> GetProducts(string filePath)
        {
            products.Clear();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filePath);
            XmlElement xRoot = xDoc.DocumentElement;

            string type = string.Empty;
            string name = string.Empty;
            DateTime date = new DateTime();
            double price = 0.0;

            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "type")
                    {
                        type = childnode.InnerText;
                    }
                    if (childnode.Name == "name")
                    {
                        name = childnode.InnerText;
                    }
                    if (childnode.Name == "price")
                    {
                        price = Double.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "date")
                    {
                        date = GetDate(childnode.InnerText);
                    }
                }

                products.Add(new Product(type, price, name, date));
            }

            return products;
        }


        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <returns>The date.</returns>
        /// <param name="str">String.</param>
        private DateTime GetDate (string str)
        {
            string[] dataInArray = str.Split('.');

            if ( dataInArray.Length != 3)
            {
                throw new ArgumentException("Wrong date.");
            }

            return new DateTime(Int32.Parse(dataInArray[2]), Int32.Parse(dataInArray[1]), Int32.Parse(dataInArray[0]));
        }
    }
}