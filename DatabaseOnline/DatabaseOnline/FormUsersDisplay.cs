using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseOnline
{
    public partial class FormUsersDisplay : Form
    {
        public FormUsersDisplay()
        {
            InitializeComponent();

            RefreshData();

        }

        private void RefreshData()
        {
            DataTable dataTable = new DataTable();
            string strCmdText = @"SELECT *, (CASE U_Gender when 1 then 'Male' else 'Female' END) U_GenderText 
                                  FROM USERS U INNER JOIN USERTYPES UT ON (U.UT_ID_FK = UT.UT_ID);";
            SqlConnection sqlConnection = new SqlConnection(FormMain.STR_CONNECTION_STRING);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(strCmdText, sqlConnection);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            dataTable.Load(sdr);
            sdr.Close();
            sqlConnection.Close();

            bindingSourceData.DataSource = dataTable;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                bindingSourceData.Filter = "";
            }
            else
            {
                bindingSourceData.Filter = string.Format("U_FirstName like '{0}%'", textBoxSearch.Text);
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormUsersNew form = new FormUsersNew();

            if (form.ShowDialog() == DialogResult.OK)
            {
                int UT_ID_fk = Convert.ToInt32(form.comboBoxUType.SelectedValue);
                string U_FirstName = form.textBoxFirstName.Text;
                string U_LastName = form.textBoxLastName.Text;
                int U_Gender = form.radioButtonMale.Checked ? 1 : 0;
                string U_MeliCode = form.textBoxMeliCode.Text;
                string U_Email = form.textBoxEmail.Text;
                string U_Mobile = form.textBoxMobile.Text;
                string U_Username = form.textBoxUserName.Text;
                string U_Password = form.textBoxPass.Text;
                
                string U_Address = form.textBoxAddress.Text;
                MemoryStream memoryStream = new MemoryStream();
                form.pictureBoxImage.Image.Save(memoryStream, ImageFormat.Jpeg);
                byte[] U_Image = memoryStream.ToArray();
                memoryStream.Close();
                string strCmdText = $"INSERT INTO Users (UT_ID_fk, U_FirstName, U_LastName, U_Gender, U_MeliCode, U_Email, U_Mobile, U_Username, U_Password, U_Image, U_Address)VALUES({UT_ID_fk}, N'{U_FirstName}', N'{U_LastName}', {U_Gender}, N'{U_MeliCode}', N'{U_Email}', N'{U_Mobile}', N'{U_Username}', N'{U_Password}', @U_Image, N'{U_Address}');";
                SqlParameter sqlParameter = new SqlParameter("@U_Image", SqlDbType.Image);
                sqlParameter.Value = U_Image;

                SqlConnection sqlConnection = new SqlConnection(FormMain.STR_CONNECTION_STRING);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(strCmdText, sqlConnection);
                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();
                
                RefreshData();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Plesae select A!!!");
                return;
            }

            DataRow dr = ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;
            int intUTID = Convert.ToInt32(dr["UT_ID"]);
            string strUTName = dr["UT_Name"].ToString();

            FormUserTypesNew form = new FormUserTypesNew();
            form.textBoxUT_Name.Text = strUTName;

            if (form.ShowDialog() == DialogResult.OK)
            {
                string strCmdText = string.Format("UPDATE UserTypes SET UT_Name = N'{0}' WHERE UT_ID = {1};", form.textBoxUT_Name.Text, intUTID);
                SqlConnection sqlConnection = new SqlConnection(FormMain.STR_CONNECTION_STRING);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(strCmdText, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                RefreshData();
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Plesae select A!!!");
                return;
            }

            DataRow dr = ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;
            int intUID = Convert.ToInt32(dr["U_ID"]);

            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            string strCmdText = string.Format("DELETE FROM Users WHERE U_ID = {0};",  intUID);
            SqlConnection sqlConnection = new SqlConnection(FormMain.STR_CONNECTION_STRING);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(strCmdText, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            RefreshData();

        }
    }
}
