using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgeCalculator
{
    public partial class AgeCalc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string format = "dd/MM/yyyy";
            DateTime dob;
            var isValidFormat = DateTime.TryParseExact(TextBox1.Text, format, new CultureInfo("en-US"), DateTimeStyles.None, out dob);

            TimeSpan difference = DateTime.Now.Subtract(dob);

            DateTime age = DateTime.MinValue + difference;
            DateTime today = DateTime.Today;

            if (isValidFormat)
            {
                DateTime current = DateTime.Now;

                int years = current.Year - dob.Year;

                int Months = DateTime.Now.Month - dob.Month;

                if (today.Day < dob.Day)
                {
                    Months--;
                }

                if (Months < 0)
                {
                    years--;
                    Months += 12;
                }

                int Days = (today - dob.AddMonths((years * 12) + Months)).Days;

                int Hours = DateTime.Now.Hour - dob.Hour;

                int Minutes = DateTime.Now.Minute - dob.Minute;

                int Seconds = DateTime.Now.Second - dob.Second;
              
                TextBox2.Text = years + " Years" + " " + Months + " Months" + " "  + Days + " Days" + " " + Hours + " Hours" + " " + Minutes + " Minutes" + " " + Seconds + " Seconds";

            }
            else
            {
                TextBox2.Text = "Invalid Format";
            }


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}