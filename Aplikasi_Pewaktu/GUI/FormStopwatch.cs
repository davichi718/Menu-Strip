using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Pewaktu.GUI
{
    public partial class FormStopwatch : Form
    {
        int seconds = 0;
        int minute = 0;
        int hour = 0;

        public FormStopwatch()
        {
            InitializeComponent();
        }

        //Button start
        private void ButtonStopwatch_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        //Button stop
        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        //Button reset
        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            seconds = 0;
            minute = 0;
            hour = 0;

            labelSecond.Text = seconds.ToString("D2");
            labelMinute.Text = minute.ToString("D2");
            labelHour.Text = hour.ToString("D2");
        }

        //Method => dijalankan ketika button start diklik
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                seconds++;

                if (seconds == 60)
                {
                    seconds = 0;
                    minute++;

                    if (minute == 60)
                    {
                        minute = 0;
                        hour++;
                    }
                }
            }

            labelSecond.Text = seconds.ToString("D2");
            labelMinute.Text = minute.ToString("D2");
            labelHour.Text = hour.ToString("D2");
        }
    }
}
