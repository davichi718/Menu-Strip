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
    public partial class MainForm : Form
    {
        FormTimer tmer;
        FormStopwatch stpw;

        void formClosed(Object sender, FormClosedEventArgs e)
        {
            if (sender == tmer)
            {
                tmer = null;
            }
            else if (sender == stpw)
            {
                stpw = null;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void submenu_timer_click(object sender, EventArgs e)
        {
            tmer = new FormTimer();
            tmer.MdiParent = this;
            tmer.FormClosed += new FormClosedEventHandler(formClosed);
            tmer.Show();
        }

        private void submenu_stopwatch_Click(object sender, EventArgs e)
        {   
            if (stpw == null) // mengecek apakah form sudah ada atau tidak
            {
                stpw = new FormStopwatch();
                stpw.MdiParent = this;
                stpw.FormClosed += new FormClosedEventHandler(formClosed);
                stpw.Show();
            }
            else
            {
                stpw.Activate(); // fokus untuk menggunakan form yang terbuka
            }
        }
    }
}
