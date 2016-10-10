using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        int bulan;
        public Form1()
        {
            InitializeComponent();
            DateTime awal = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime akhir = new DateTime(DateTime.Now.Year, 12, 31);
            TimeSpan jarak = akhir - awal;
            int days = jarak.Days;
            for (var i = 0; i <= days; i++) {
                var weekend = awal.AddDays(i);
                switch (weekend.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                        monthCalendar1.AddBoldedDate(weekend);
                        break;
                    case DayOfWeek.Sunday:
                        monthCalendar1.AddBoldedDate(weekend);
                        break;
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.AddBoldedDate(new DateTime(2016, 1, 28)); // Tanggal lahir 
            domainUpDown1.SelectedIndex = monthCalendar1.SelectionStart.Day - 1;
            if (monthCalendar1.SelectionStart.Month == 1)
                domainUpDown2.Text = "Januari";
            else if (monthCalendar1.SelectionStart.Month == 2)
                domainUpDown2.Text = "Februari";
            else if (monthCalendar1.SelectionStart.Month == 3)
                domainUpDown2.Text = "Maret";
            else if (monthCalendar1.SelectionStart.Month == 4)
                domainUpDown2.Text = "April";
            else if (monthCalendar1.SelectionStart.Month == 5)
                domainUpDown2.Text = "Mei";
            else if (monthCalendar1.SelectionStart.Month == 6)
                domainUpDown2.Text = "Juni";
            else if (monthCalendar1.SelectionStart.Month == 7)
                domainUpDown2.Text = "Juli";
            else if (monthCalendar1.SelectionStart.Month == 8)
                domainUpDown2.Text = "Agustus";
            else if (monthCalendar1.SelectionStart.Month == 9)
                domainUpDown2.Text = "September";
            else if (monthCalendar1.SelectionStart.Month == 10)
                domainUpDown2.Text = "Oktober";
            else if (monthCalendar1.SelectionStart.Month == 11)
                domainUpDown2.Text = "November";
            else
                domainUpDown2.Text = "Desember";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((bulan == 4 || bulan == 6 || bulan == 9 | bulan == 11) && domainUpDown1.SelectedIndex + 1 > 30)
            {
                MessageBox.Show("Melebihi Tanggal");
            }
            else if (bulan == 2 && domainUpDown1.SelectedIndex +1 > 29)
                MessageBox.Show("Melebihi Tanggal");
            else
                monthCalendar1.AddMonthlyBoldedDate(new DateTime(DateTime.Now.Year, bulan, domainUpDown1.SelectedIndex + 1));
            monthCalendar1.UpdateBoldedDates();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.RemoveMonthlyBoldedDate(new DateTime(DateTime.Now.Year, bulan, domainUpDown1.SelectedIndex + 1));
            monthCalendar1.UpdateBoldedDates();
        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown2.Text == "Januari")
                bulan = 1;
            else if (domainUpDown2.Text == "Februari")
                bulan = 2;
            else if (domainUpDown2.Text == "Maret")
                bulan = 3;
            else if (domainUpDown2.Text == "April")
                bulan = 4;
            else if (domainUpDown2.Text == "Mei")
                bulan = 5;
            else if (domainUpDown2.Text == "Juni")
                bulan = 6;
            else if (domainUpDown2.Text == "Juli")
                bulan = 7;
            else if (domainUpDown2.Text == "Agustus")
                bulan = 8;
            else if (domainUpDown2.Text == "September")
                bulan = 9;
            else if (domainUpDown2.Text == "Oktober")
                bulan = 10;
            else if (domainUpDown2.Text == "November")
                bulan = 11;
            else
                bulan = 12;
        }
    }
}
