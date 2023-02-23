using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseOnline
{
    public partial class FormUsersNew : Form
    {
        //[U_FirstName], [U_LastName], [U_Gender], [U_MeliCode], [U_Email], [U_Mobile], [U_Username], [U_Password], [U_Image], [U_Address]
        public FormUsersNew()
        {
            InitializeComponent();

            LoadCombo();
        }

        private void LoadCombo()
        {
            DataTable dataTable = new DataTable();
            string strCmdText = "SELECT * FROM UserTypes;";
            SqlConnection sqlConnection = new SqlConnection(FormMain.STR_CONNECTION_STRING);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(strCmdText, sqlConnection);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            dataTable.Load(sdr);
            sdr.Close();
            sqlConnection.Close();

            comboBoxUType.DataSource = dataTable;
            comboBoxUType.ValueMember = "UT_ID";
            comboBoxUType.DisplayMember = "UT_Name";


        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                MessageBox.Show("Pleae Enter First Name!!!");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.jpg|*.jpg";
            openFileDialog.Title = "Profile Image";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
