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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // hide the start form
            this.Hide();
            // instinate a next form
            NextForm nextForm = new NextForm();
            // show the next form
            nextForm.ShowDialog();
            // close start form
            this.Close();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit the start form?", "Exit", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                System.Environment.Exit(0);

            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
