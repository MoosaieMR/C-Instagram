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
    public partial class FormUserTypesDisplay : Form
    {
        public FormUserTypesDisplay()
        {
            InitializeComponent();

            RefreshData();

        }

        private void RefreshData()
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
                bindingSourceData.Filter = string.Format("UT_Name like '{0}%'", textBoxSearch.Text);
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormUserTypesNew form = new FormUserTypesNew();

            if (form.ShowDialog() == DialogResult.OK)
            {
                string strCmdText = string.Format("INSERT INTO UserTypes(UT_Name) VALUES(N'{0}');", form.textBoxUT_Name.Text);
                SqlConnection sqlConnection = new SqlConnection(FormMain.STR_CONNECTION_STRING);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(strCmdText, sqlConnection);
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
            int intUTID = Convert.ToInt32(dr["UT_ID"]);

            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            string strCmdText = string.Format("DELETE FROM UserTypes WHERE UT_ID = {0};",  intUTID);
            SqlConnection sqlConnection = new SqlConnection(FormMain.STR_CONNECTION_STRING);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(strCmdText, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            RefreshData();

        }
    }
}
