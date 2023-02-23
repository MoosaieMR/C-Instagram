using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseOnline
{
    public partial class FormMain : Form
    {
        public static readonly string STR_CONNECTION_STRING = "Server=.;Database=AATest;User Id=sa;Password=123456;";

        public FormMain()
        {
            InitializeComponent();
        }

        private void userTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserTypesDisplay form = new FormUserTypesDisplay();

            form.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormUsersDisplay form = new FormUsersDisplay();

            form.ShowDialog();
        }
    }
}
