using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week8
{
    public partial class SplashPage : Form
    {
        public SplashPage()
        {
            InitializeComponent();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Enabled = false;
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();
        }
    }
}
