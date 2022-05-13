using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _7_Segment_Clock
{
    public partial class Form1 : Form
    {
        int seconds;
        string sec;
        int seconds2;
        string sec2;

        int minutes;
        string min;
        int minutes2;
        string min2;

        int hours;
        string hr;
        int hours2;
        string hr2;

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("NAHACK KITA");
        }

        private void numbers(object sender, EventArgs e)
        {
            Button timeon = (Button)sender;
            timeon.BackColor = System.Drawing.Color.Maroon;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            sec = DateTime.Now.ToString("ss");
            seconds = Convert.ToInt32(sec.Substring(sec.Length - 1));

            if (seconds == 0)
            {
                S1A.PerformClick();
                S1B.PerformClick();
                S1C.PerformClick();
                S1D.PerformClick();
                S1E.PerformClick();
                S1F.PerformClick();
                S1G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (seconds == 1)
            {
                S1A.BackColor = System.Drawing.Color.Transparent;
                S1B.PerformClick();
                S1C.PerformClick();
                S1D.BackColor = System.Drawing.Color.Transparent;
                S1E.BackColor = System.Drawing.Color.Transparent;
                S1F.BackColor = System.Drawing.Color.Transparent;
                S1G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (seconds == 2)
            {
                S1A.PerformClick();
                S1B.PerformClick();
                S1C.BackColor = System.Drawing.Color.Transparent;
                S1D.PerformClick();
                S1E.PerformClick();
                S1F.BackColor = System.Drawing.Color.Transparent;
                S1G.PerformClick();
            }

            else if (seconds == 3)
            {
                S1A.PerformClick();
                S1B.PerformClick();
                S1C.PerformClick();
                S1D.PerformClick();
                S1E.BackColor = System.Drawing.Color.Transparent;
                S1F.BackColor = System.Drawing.Color.Transparent;
                S1G.PerformClick();
            }

            else if (seconds == 4)
            {
                S1A.BackColor = System.Drawing.Color.Transparent;
                S1B.PerformClick();
                S1C.PerformClick();
                S1D.BackColor = System.Drawing.Color.Transparent;
                S1E.BackColor = System.Drawing.Color.Transparent;
                S1F.PerformClick();
                S1G.PerformClick();
            }

            else if (seconds == 5)
            {
                S1A.PerformClick();
                S1B.BackColor = System.Drawing.Color.Transparent;
                S1C.PerformClick();
                S1D.PerformClick();
                S1E.BackColor = System.Drawing.Color.Transparent;
                S1F.PerformClick();
                S1G.PerformClick();
            }

            else if (seconds == 6)
            {
                S1A.PerformClick();
                S1B.BackColor = System.Drawing.Color.Transparent;
                S1C.PerformClick();
                S1D.PerformClick();
                S1E.PerformClick();
                S1F.PerformClick();
                S1G.PerformClick();
            }

            else if (seconds == 7)
            {
                S1A.PerformClick();
                S1B.PerformClick();
                S1C.PerformClick();
                S1D.BackColor = System.Drawing.Color.Transparent;
                S1E.BackColor = System.Drawing.Color.Transparent;
                S1F.BackColor = System.Drawing.Color.Transparent;
                S1G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (seconds == 8)
            {
                S1A.PerformClick();
                S1B.PerformClick();
                S1C.PerformClick();
                S1D.PerformClick();
                S1E.PerformClick();
                S1F.PerformClick();
                S1G.PerformClick();
            }

            else if (seconds == 9)
            {
                S1A.PerformClick();
                S1B.PerformClick();
                S1C.PerformClick();
                S1D.PerformClick();
                S1E.BackColor = System.Drawing.Color.Transparent;
                S1F.PerformClick();
                S1G.PerformClick();
            }


            sec2 = DateTime.Now.ToString("ss");
            seconds2 = Convert.ToInt32(sec.Substring(0, 1));

            if (seconds2 == 0)
            {
                S2A.PerformClick();
                S2B.PerformClick();
                S2C.PerformClick();
                S2D.PerformClick();
                S2E.PerformClick();
                S2F.PerformClick();
                S2G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (seconds2 == 1)
            {
                S2A.BackColor = System.Drawing.Color.Transparent;
                S2B.PerformClick();
                S2C.PerformClick();
                S2D.BackColor = System.Drawing.Color.Transparent;
                S2E.BackColor = System.Drawing.Color.Transparent;
                S2F.BackColor = System.Drawing.Color.Transparent;
                S2G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (seconds2 == 2)
            {
                S2A.PerformClick();
                S2B.PerformClick();
                S2C.BackColor = System.Drawing.Color.Transparent;
                S2D.PerformClick();
                S2E.PerformClick();
                S2F.BackColor = System.Drawing.Color.Transparent;
                S2G.PerformClick();
            }

            else if (seconds2 == 3)
            {
                S2A.PerformClick();
                S2B.PerformClick();
                S2C.PerformClick();
                S2D.PerformClick();
                S2E.BackColor = System.Drawing.Color.Transparent;
                S2F.BackColor = System.Drawing.Color.Transparent;
                S2G.PerformClick();
            }

            else if (seconds2 == 4)
            {
                S2A.BackColor = System.Drawing.Color.Transparent;
                S2B.PerformClick();
                S2C.PerformClick();
                S2D.BackColor = System.Drawing.Color.Transparent;
                S2E.BackColor = System.Drawing.Color.Transparent;
                S2F.PerformClick();
                S2G.PerformClick();
            }

            else if (seconds2 == 5)
            {
                S2A.PerformClick();
                S2B.BackColor = System.Drawing.Color.Transparent;
                S2C.PerformClick();
                S2D.PerformClick();
                S2E.BackColor = System.Drawing.Color.Transparent;
                S2F.PerformClick();
                S2G.PerformClick();
            }


            min = DateTime.Now.ToString("mm");
            minutes = Convert.ToInt32(min.Substring(min.Length - 1));

            if (minutes == 0)
            {
                M1A.PerformClick();
                M1B.PerformClick();
                M1C.PerformClick();
                M1D.PerformClick();
                M1E.PerformClick();
                M1F.PerformClick();
                M1G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (minutes == 1)
            {
                M1A.BackColor = System.Drawing.Color.Transparent;
                M1B.PerformClick();
                M1C.PerformClick();
                M1D.BackColor = System.Drawing.Color.Transparent;
                M1E.BackColor = System.Drawing.Color.Transparent;
                M1F.BackColor = System.Drawing.Color.Transparent;
                M1G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (minutes == 2)
            {
                M1A.PerformClick();
                M1B.PerformClick();
                M1C.BackColor = System.Drawing.Color.Transparent;
                M1D.PerformClick();
                M1E.PerformClick();
                M1F.BackColor = System.Drawing.Color.Transparent;
                M1G.PerformClick();
            }

            else if (minutes == 3)
            {
                M1A.PerformClick();
                M1B.PerformClick();
                M1C.PerformClick();
                M1D.PerformClick();
                M1E.BackColor = System.Drawing.Color.Transparent;
                M1F.BackColor = System.Drawing.Color.Transparent;
                M1G.PerformClick();
            }

            else if (minutes == 4)
            {
                M1A.BackColor = System.Drawing.Color.Transparent;
                M1B.PerformClick();
                M1C.PerformClick();
                M1D.BackColor = System.Drawing.Color.Transparent;
                M1E.BackColor = System.Drawing.Color.Transparent;
                M1F.PerformClick();
                M1G.PerformClick();
            }

            else if (minutes == 5)
            {
                M1A.PerformClick();
                M1B.BackColor = System.Drawing.Color.Transparent;
                M1C.PerformClick();
                M1D.PerformClick();
                M1E.BackColor = System.Drawing.Color.Transparent;
                M1F.PerformClick();
                M1G.PerformClick();
            }

            else if (minutes == 6)
            {
                M1A.PerformClick();
                M1B.BackColor = System.Drawing.Color.Transparent;
                M1C.PerformClick();
                M1D.PerformClick();
                M1E.PerformClick();
                M1F.PerformClick();
                M1G.PerformClick();
            }

            else if (minutes == 7)
            {
                M1A.PerformClick();
                M1B.PerformClick();
                M1C.PerformClick();
                M1D.BackColor = System.Drawing.Color.Transparent;
                M1E.BackColor = System.Drawing.Color.Transparent;
                M1F.BackColor = System.Drawing.Color.Transparent;
                M1G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (minutes == 8)
            {
                M1A.PerformClick();
                M1B.PerformClick();
                M1C.PerformClick();
                M1D.PerformClick();
                M1E.PerformClick();
                M1F.PerformClick();
                M1G.PerformClick();
            }

            else if (minutes == 9)
            {
                M1A.PerformClick();
                M1B.PerformClick();
                M1C.PerformClick();
                M1D.PerformClick();
                M1E.BackColor = System.Drawing.Color.Transparent;
                M1F.PerformClick();
                M1G.PerformClick();
            }

            min2 = DateTime.Now.ToString("mm");
            minutes2 = Convert.ToInt32(min2.Substring(0, 1));

            if (minutes2 == 0)
            {
                M2A.PerformClick();
                M2B.PerformClick();
                M2C.PerformClick();
                M2D.PerformClick();
                M2E.PerformClick();
                M2F.PerformClick();
                M2G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (minutes2 == 1)
            {
                M2A.BackColor = System.Drawing.Color.Transparent;
                M2B.PerformClick();
                M2C.PerformClick();
                M2D.BackColor = System.Drawing.Color.Transparent;
                M2E.BackColor = System.Drawing.Color.Transparent;
                M2F.BackColor = System.Drawing.Color.Transparent;
                M2G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (minutes2 == 2)
            {
                M2A.PerformClick();
                M2B.PerformClick();
                M2C.BackColor = System.Drawing.Color.Transparent;
                M2D.PerformClick();
                M2E.PerformClick();
                M2F.BackColor = System.Drawing.Color.Transparent;
                M2G.PerformClick();
            }

            else if (minutes2 == 3)
            {
                M2A.PerformClick();
                M2B.PerformClick();
                M2C.PerformClick();
                M2D.PerformClick();
                M2E.BackColor = System.Drawing.Color.Transparent;
                M2F.BackColor = System.Drawing.Color.Transparent;
                M2G.PerformClick();
            }

            else if (minutes2 == 4)
            {
                M2A.BackColor = System.Drawing.Color.Transparent;
                M2B.PerformClick();
                M2C.PerformClick();
                M2D.BackColor = System.Drawing.Color.Transparent;
                M2E.BackColor = System.Drawing.Color.Transparent;
                M2F.PerformClick();
                M2G.PerformClick();
            }

            else if (minutes2 == 5)
            {
                M2A.PerformClick();
                M2B.BackColor = System.Drawing.Color.Transparent;
                M2C.PerformClick();
                M2D.PerformClick();
                M2E.BackColor = System.Drawing.Color.Transparent;
                M2F.PerformClick();
                M2G.PerformClick();
            }


            hr = DateTime.Now.ToString("HH");
            hours = Convert.ToInt32(hr.Substring(hr.Length - 1));

            if (hours == 0)
            {
                H1A.PerformClick();
                H1B.PerformClick();
                H1C.PerformClick();
                H1D.PerformClick();
                H1E.PerformClick();
                H1F.PerformClick();
                H1G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (hours == 1)
            {
                H1A.BackColor = System.Drawing.Color.Transparent;
                H1B.PerformClick();
                H1C.PerformClick();
                H1D.BackColor = System.Drawing.Color.Transparent;
                H1E.BackColor = System.Drawing.Color.Transparent;
                H1F.BackColor = System.Drawing.Color.Transparent;
                H1G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (hours == 2)
            {
                H1A.PerformClick();
                H1B.PerformClick();
                H1C.BackColor = System.Drawing.Color.Transparent;
                H1D.PerformClick();
                H1E.PerformClick();
                H1F.BackColor = System.Drawing.Color.Transparent;
                H1G.PerformClick();
            }

            else if (hours == 3)
            {
                H1A.PerformClick();
                H1B.PerformClick();
                H1C.PerformClick();
                H1D.PerformClick();
                H1E.BackColor = System.Drawing.Color.Transparent;
                H1F.BackColor = System.Drawing.Color.Transparent;
                H1G.PerformClick();
            }

            else if (hours == 4)
            {
                H1A.BackColor = System.Drawing.Color.Transparent;
                H1B.PerformClick();
                H1C.PerformClick();
                H1D.BackColor = System.Drawing.Color.Transparent;
                H1E.BackColor = System.Drawing.Color.Transparent;
                H1F.PerformClick();
                H1G.PerformClick();
            }

            else if (hours == 5)
            {
                H1A.PerformClick();
                H1B.BackColor = System.Drawing.Color.Transparent;
                H1C.PerformClick();
                H1D.PerformClick();
                H1E.BackColor = System.Drawing.Color.Transparent;
                H1F.PerformClick();
                H1G.PerformClick();
            }

            else if (hours == 6)
            {
                H1A.PerformClick();
                H1B.BackColor = System.Drawing.Color.Transparent;
                H1C.PerformClick();
                H1D.PerformClick();
                H1E.PerformClick();
                H1F.PerformClick();
                H1G.PerformClick();
            }

            else if (hours == 7)
            {
                H1A.PerformClick();
                H1B.PerformClick();
                H1C.PerformClick();
                H1D.BackColor = System.Drawing.Color.Transparent;
                H1E.BackColor = System.Drawing.Color.Transparent;
                H1F.BackColor = System.Drawing.Color.Transparent;
                H1G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (hours == 8)
            {
                H1A.PerformClick();
                H1B.PerformClick();
                H1C.PerformClick();
                H1D.PerformClick();
                H1E.PerformClick();
                H1F.PerformClick();
                H1G.PerformClick();
            }

            else if (hours == 9)
            {
                H1A.PerformClick();
                H1B.PerformClick();
                H1C.PerformClick();
                H1D.PerformClick();
                H1E.BackColor = System.Drawing.Color.Transparent;
                H1F.PerformClick();
                H1G.PerformClick();
            }


            hr2 = DateTime.Now.ToString("HH");
            hours2 = Convert.ToInt32(hr2.Substring(0, 1));

            if (hours2 == 0)
            {
                H2A.PerformClick();
                H2B.PerformClick();
                H2C.PerformClick();
                H2D.PerformClick();
                H2E.PerformClick();
                H2F.PerformClick();
                H2G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (hours2 == 1)
            {
                H2A.BackColor = System.Drawing.Color.Transparent;
                H2B.PerformClick();
                H2C.PerformClick();
                H2D.BackColor = System.Drawing.Color.Transparent;
                H2E.BackColor = System.Drawing.Color.Transparent;
                H2F.BackColor = System.Drawing.Color.Transparent;
                H2G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (hours2 == 2)
            {
                H2A.PerformClick();
                H2B.PerformClick();
                H2C.BackColor = System.Drawing.Color.Transparent;
                H2D.PerformClick();
                H2E.PerformClick();
                H2F.BackColor = System.Drawing.Color.Transparent;
                H2G.PerformClick();
            }


        }


    }
}
