using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace lab_Calculator_Service
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        /// <summary>
        ///  Add two doubles
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Sum of numbers</returns>
        [WebMethod]
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }


        /// <summary>
        /// Substract two doubles
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Number difference</returns>
        [WebMethod]
        public double Subtraction(double number1, double number2)
        {
            return number1 - number2;
        }


        /// <summary>
        /// Multiplicate two doubles
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Result</returns>
        [WebMethod]
        public double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }


        /// <summary>
        /// Division two doubles
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Result</returns>
        [WebMethod]
        public double Division(double number1, double number2)
        {
            if (number2.Equals(0.0))
            {
                return double.PositiveInfinity;
            }

            if (number2.Equals(-0.0))
            {
                return double.NegativeInfinity;
            }
            return number1 / number2;
        }
    }
}
