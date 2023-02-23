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
    public partial class FormUserTypesNew : Form
    {
        public FormUserTypesNew()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUT_Name.Text))
            {
                MessageBox.Show("Pleae Enter Usert Type Name !!!");
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
