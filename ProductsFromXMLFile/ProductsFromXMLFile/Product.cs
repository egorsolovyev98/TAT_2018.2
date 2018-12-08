using System;

namespace ProductsFromXMLFile
{
    /// <summary>
    /// Product.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type { get; set; }


        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public double Price { get; set; }


        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }


        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        public DateTime Date { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="T:ProductsFromXMLFile.Product"/> class.
        /// </summary>
        /// <param name="type">Type.</param>
        /// <param name="price">Price.</param>
        /// <param name="name">Name.</param>
        /// <param name="date">Date.</param>
        public Product(string type, double price, string name, DateTime date)
        {
            Type = type;
            Price = price;
            Name = name;
            Date = date;
        }


        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:ProductsFromXMLFile.Product"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:ProductsFromXMLFile.Product"/>.</returns>
        public override string ToString()
        {
            return $"{Type} - {Price} - {Name} - {Date.ToShortDateString()}";
        }
    }
}