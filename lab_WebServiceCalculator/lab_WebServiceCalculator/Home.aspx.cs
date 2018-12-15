using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_WebServiceCalculator
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.WebService1SoapClient s = new ServiceReference1.WebService1SoapClient();

                double result = 0.0;
                string select = DropDownList1.SelectedValue;

                if (select.Equals("+"))
                {
                    result = s.Add(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
                }
                else if (select.Equals("-"))
                {
                    result = s.Subtraction(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
                }
                else if (select.Equals("*"))
                {
                    result = s.Multiplication(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
                }
                else if (select.Equals("/"))
                {
                    result = s.Division(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
                }

                Label1.Text = result.ToString();
            }
            catch (Exception exp)
            {
                Label1.Text = exp.Message;
            }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}