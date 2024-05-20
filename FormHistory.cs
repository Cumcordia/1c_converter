using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
        }

        public void MainHistoryMethod()
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
        }

    }
}
