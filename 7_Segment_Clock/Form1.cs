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

        public Form1()
        {
            InitializeComponent();
        }

        private void numbers(object sender, EventArgs e)
        {
            Button timeon = (Button)sender;
            timeon.BackColor = System.Drawing.Color.Black;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            sec = DateTime.Now.ToString("ss");
            seconds = Convert.ToInt32(sec.Substring(sec.Length - 1));
            
            if(seconds == 0)
            {
                S1A.PerformClick();
                S1B.PerformClick();
                S1C.PerformClick();
                S1D.PerformClick();
                S1E.PerformClick();
                S1F.PerformClick();
                S1G.UseVisualStyleBackColor = true;
            }

            else if(seconds == 1)
            {
                S1A.UseVisualStyleBackColor = true;
                S1B.PerformClick();
                S1C.PerformClick();
                S1D.UseVisualStyleBackColor = true;
                S1E.UseVisualStyleBackColor = true;
                S1F.UseVisualStyleBackColor = true;
                S1G.UseVisualStyleBackColor = true;
            }

            else if (seconds == 2)
            {
                S1A.PerformClick();
                S1B.PerformClick();
                S1C.UseVisualStyleBackColor = true;
                S1D.PerformClick();
                S1E.PerformClick();
                S1F.UseVisualStyleBackColor = true;
                S1G.PerformClick();
            }

            else if (seconds == 3)
            {
                S1A.PerformClick();
                S1B.PerformClick();
                S1C.PerformClick();
                S1D.PerformClick();
                S1E.UseVisualStyleBackColor = true;
                S1F.UseVisualStyleBackColor = true;
                S1G.PerformClick();
            }

            else if (seconds == 4)
            {
                S1A.UseVisualStyleBackColor = true;
                S1B.PerformClick();
                S1C.PerformClick();
                S1D.UseVisualStyleBackColor = true;
                S1E.UseVisualStyleBackColor = true;
                S1F.PerformClick();
                S1G.PerformClick();
            }

            else if (seconds == 5)
            {
                S1A.PerformClick();
                S1B.UseVisualStyleBackColor = true;
                S1C.PerformClick();
                S1D.PerformClick();
                S1E.UseVisualStyleBackColor = true;
                S1F.PerformClick();
                S1G.PerformClick();
            }

            else if (seconds == 6)
            {
                S1A.PerformClick();
                S1B.UseVisualStyleBackColor = true;
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
                S1D.UseVisualStyleBackColor = true;
                S1E.UseVisualStyleBackColor = true;
                S1F.UseVisualStyleBackColor = true;
                S1G.UseVisualStyleBackColor = true;
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
                S1E.UseVisualStyleBackColor = true;
                S1F.PerformClick();
                S1G.PerformClick();
            }


            sec2 = DateTime.Now.ToString("ss");
            seconds2 = Convert.ToInt32(sec.Substring(0,1));

            if (seconds2 == 0)
            {
                S2A.PerformClick();
                S2B.PerformClick();
                S2C.PerformClick();
                S2D.PerformClick();
                S2E.PerformClick();
                S2F.PerformClick();
                S2G.UseVisualStyleBackColor = true;
            }

            else if (seconds2 == 1)
            {
                S2A.UseVisualStyleBackColor = true;
                S2B.PerformClick();
                S2C.PerformClick();
                S2D.UseVisualStyleBackColor = true;
                S2E.UseVisualStyleBackColor = true;
                S2F.UseVisualStyleBackColor = true;
                S2G.UseVisualStyleBackColor = true;
            }

            else if (seconds2 == 2)
            {
                S2A.PerformClick();
                S2B.PerformClick();
                S2C.UseVisualStyleBackColor = true;
                S2D.PerformClick();
                S2E.PerformClick();
                S2F.UseVisualStyleBackColor = true;
                S2G.PerformClick();
            }

            else if (seconds2 == 3)
            {
                S2A.PerformClick();
                S2B.PerformClick();
                S2C.PerformClick();
                S2D.PerformClick();
                S2E.UseVisualStyleBackColor = true;
                S2F.UseVisualStyleBackColor = true;
                S2G.PerformClick();
            }

            else if (seconds2 == 4)
            {
                S2A.UseVisualStyleBackColor = true;
                S2B.PerformClick();
                S2C.PerformClick();
                S2D.UseVisualStyleBackColor = true;
                S2E.UseVisualStyleBackColor = true;
                S2F.PerformClick();
                S2G.PerformClick();
            }

            else if (seconds2 == 5)
            {
                S2A.PerformClick();
                S2B.UseVisualStyleBackColor = true;
                S2C.PerformClick();
                S2D.PerformClick();
                S2E.UseVisualStyleBackColor = true;
                S2F.PerformClick();
                S2G.PerformClick();
            }
            


        }

        
    }
}
