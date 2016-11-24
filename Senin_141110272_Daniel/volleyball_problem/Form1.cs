using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            long a, b, hasil = 1, temp;

            a = Convert.ToInt32(Txt1.Text);
            b = Convert.ToInt32(Txt2.Text);

            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            if (((a == 25) && (b < 25 && b > 0)) || ((b == 25) && (a < 25 && a > 0)) || (a > 25 && (a - b == 2)))
            {
                if ((a + b - 1) < 47)
                {
                    hasil = comb(a + b - 1, a - 1);
                    hasil *= pow(2, a - 25);
                    hasil %= mod;
                }
                else
                {
                    hasil = comb(47, 24);
                    hasil *= pow(2, a - 25);
                    hasil %= mod;
                }

            }
            else
                hasil = 0;

            TxtHasil.Text = hasil.ToString();
        }

        const long mod = 1000000007;
        public static long fakto(long a)
        {
            long akhir = 1;
            for (long i = a; i > 1; i--)
            {
                akhir *= i;
                akhir %= mod;
            }
            return akhir;
        }

        public static long pow(long a, long b)
        {
            long akhir = 1;
            while (b > 0)
            {
                if (b % 2 == 1)
                {
                    akhir = (akhir * a) % mod;
                }
                a = (a * a) % mod;
                b /= 2;
            }
            return akhir;
        }

        public static long invers(long n)
        {
            return pow(n, mod - 2);
        }

        public static long comb(long a, long b)
        {
            long hasil = 1;
            hasil *= fakto(a);
            hasil %= mod;
            hasil *= invers(fakto(a - b));
            hasil %= mod;
            hasil *= invers(fakto(b));
            hasil %= mod;
            return hasil;
        }
    }
}
