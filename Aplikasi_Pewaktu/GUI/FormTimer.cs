﻿using System;
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
    public partial class FormTimer : Form
    {
        int seconds;
        int minute;
        int hour;
        public FormTimer()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                if (seconds > 0 || minute > 0 || hour > 0) // Perbaikan kondisi
                {
                    if (seconds > 0)
                    {
                        seconds--;
                    }
                    else
                    {
                        if (minute > 0)
                        {
                            minute--;
                            seconds = 59;
                        }
                        else if (hour > 0)
                        {
                            hour--;
                            minute = 59;
                            seconds = 59;
                        }
                    }
                }

            }

            labelSeconds.Text = seconds.ToString("D2");
            labelMinute.Text = minute.ToString("D2");
            labelHour.Text = hour.ToString("D2");
        }

        private void buttonMinimum_Click(object sender, EventArgs e)
        {
            if (hour > 0)
            {
                hour--;
            }
            else
            {
                hour = 23;
            }

            labelHour.Text = hour.ToString("D2");
        }

        private void buttonHourMax_Click(object sender, EventArgs e)
        {
            hour++;
            labelHour.Text = hour.ToString("D2");
        }

        private void buttonMinuteMin_Click(object sender, EventArgs e)
        {
            if (minute > 0)
            {
                minute--;
            }
            else
            {
                minute = 59;
            }

            labelMinute.Text = minute.ToString("D2");
        }

        private void buttonMinuteMax_Click(object sender, EventArgs e)
        {
            if (minute == 59)
            {
                minute = 0;
            }
            else
            {
                minute++;
            }
            labelMinute.Text = minute.ToString("D2");
        }

        private void buttonSecondsMin_Click(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds--;
            }
            else
            {
                seconds = 59;
            }

            labelSeconds.Text = seconds.ToString("D2");
        }

        private void buttonSecondsMax_Click(object sender, EventArgs e)
        {
            if (seconds == 59)
            {
                seconds = 00;
            }
            else
            {
                seconds++;
            }
            labelSeconds.Text = seconds.ToString("D2");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            hour = 0;
            minute = 0;
            seconds = 0;

            labelHour.Text = hour.ToString();
            labelMinute.Text = minute.ToString();
            labelSeconds.Text = seconds.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FormTimer_Load(object sender, EventArgs e)
        {

        }
    }
}
