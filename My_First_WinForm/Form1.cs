using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_WinForm
{
    public partial class Form1 : Form
    {
        int hour = 0;
        int minute = 0;
        int second = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second += 1;
            if (second == 60)
            {
                second = 0;
                minute += 1;
                if (minute == 60)
                {
                    minute = 0;
                    hour += 1;
                }
            }
            lbl_timer.Text = string.Format("{0:00}:{1:00}:{2:00}",hour,minute,second);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            lbl_timer.ForeColor = Color.FromArgb(0, 255, 0);
            hour = minute = second = 0;
            timer1.Enabled = true;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            lbl_timer.ForeColor = Color.FromArgb(255, 0, 0);
            timer1.Enabled = false;
        }
        int h, m, s = 0;

        private void btn_stop2_Click(object sender, EventArgs e)
        {
            lbl_time.ForeColor = Color.FromArgb(255, 0, 0);
            timer2.Enabled = false;
        }

        private void btn_start2_Click(object sender, EventArgs e)
        {
            h = m = s = 0;
            lbl_time.ForeColor = Color.FromArgb(0, 255, 0);
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            s += 1;
            if (s == 60)
            {
                s = 0;
                m += 1;
                if (m == 60)
                {
                    m = 0;
                    hour += 1;
                }
            }
            lbl_time.Text = String.Format("{0:00}:{1:00}:{2:00}", h, m, s);
        }
    }
}
