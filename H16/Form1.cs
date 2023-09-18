using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H16
{
    public partial class H16Ikalaskin : Form
    {
        public H16Ikalaskin()
        {
            InitializeComponent();
        }

        public int[] CalculateAge(DateTime dateNow, DateTime birthDate)
        {
            int day1, month1, year1;
            int day2, month2, year2;
            int diffYear, diffMonth, diffDay;
            diffYear = 0; diffMonth = 0; diffDay = 0;
            year1 = birthDate.Year;
            month1 = birthDate.Month;
            day1 = birthDate.Day;
            day2 = dateNow.Day;
            month2 = dateNow.Month;
            year2 = dateNow.Year;
            if (day2 < day1)
            {
                day2 += DateTime.DaysInMonth(year2, month2);
                diffDay = day2 - day1;
                month2--;
                if (month2 < month1)
                {
                    month2 += 12;
                    year2--;
                    diffMonth = month2 - month1;
                    diffYear = year2 - year1;
                }
                else
                {
                    diffMonth = month2 - month1;
                    diffYear = year2 - year1;
                }
            }
            else
            {
                diffDay = day2 - day1;
                if (month2 < month1)
                {
                    month2 += 12;
                    year2--;
                    diffMonth = month2 - month1;
                    diffYear = year2 - year1;
                }
                else
                {
                    diffMonth = month2 - month1;
                    diffYear = year2 - year1;
                }
            }
            int[] sonuc = new int[3];
            sonuc[0] = diffYear;
            sonuc[1] = diffMonth;
            sonuc[2] = diffDay;
            return sonuc;
        }


        private void pvmValitsin_ValueChanged(object sender, EventArgs e)
        {
            int[] result = CalculateAge(DateTime.Now, Convert.ToDateTime(pvmValitsin.Text));
            ikaLabel.Text = "Ikäsi nyt: " + result[0].ToString() + " Vuotta " + result[1].ToString() + " Kuukautta " + result[2].ToString() + " Päivää "; 
            
                
        }

        private void H16Ikalaskin_Load(object sender, EventArgs e)
        {
            pvmLabel.Text = "Päivämäärä: " + DateTime.Now.ToShortDateString();
        }
    }
}
