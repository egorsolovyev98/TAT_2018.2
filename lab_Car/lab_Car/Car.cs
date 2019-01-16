using System;

namespace lab_Car
{
    /// <summary>
    /// Car.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// The model.
        /// </summary>
        private string model;


        /// <summary>
        /// The brand.
        /// </summary>
        private string brand;


        /// <summary>
        /// The color.
        /// </summary>
        private string color;


        /// <summary>
        /// Initializes a new instance of the <see cref="T:lab_Car.Car"/> class.
        /// </summary>
        public Car()
        {
            this.brand = string.Empty;
            this.model = string.Empty;
            this.color = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:lab_Car.Car"/> class.
        /// </summary>
        /// <param name="brand">Brand.</param>
        /// <param name="model">Model.</param>
        /// <param name="color">Color.</param>
        public Car(string brand, string model, string color)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
        }


        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>The model.</value>
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("model string is null.");
                }

                model = value;
            }
        }


        /// <summary>
        /// Gets or sets the brand.
        /// </summary>
        /// <value>The brand.</value>
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("brand string is null.");
                }

                brand = value;
            }
        }


        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>The color.</value>
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("color string is null.");
                }

                model = value;
            }
        }

        public bool Compare(Car car2)
        {
            return brand.Equals(car2.brand) || model.Equals(car2.model) || color.Equals(car2.color);
        }
    }
}