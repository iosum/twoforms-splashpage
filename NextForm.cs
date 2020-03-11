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
    public partial class NextForm : Form
    {
        public NextForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // hide the next form
            this.Hide();
            // instinate a start form
            StartForm startForm = new StartForm();
            // show the start form
            startForm.ShowDialog();
            // close the next form
            this.Close();
        }

        private void NextForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit the next form?", "Exit", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;
                // hide the next form
                this.Hide();
                // instinate a start form
                StartForm startForm = new StartForm();
                // show the start form
                startForm.ShowDialog();
                // close the next form
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
