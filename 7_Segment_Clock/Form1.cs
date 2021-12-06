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

        public Form1()
        {
            InitializeComponent();
        }

        private void numbers(object sender, EventArgs e)
        {
            Button timeon = (Button)sender;
            timeon.BackColor = System.Drawing.Color.Red;
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
        }
    }
}
