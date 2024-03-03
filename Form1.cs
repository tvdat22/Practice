using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace Practice
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=TVDat;Initial Catalog=QlyLopHoc;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();


        void loaddataClass()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM class";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvClass.DataSource = table;
            cbStd.DataSource = table;
            cbStd.DisplayMember = "ClassName";
            cbStd.ValueMember = "ClassId";

        }

        void loaddataStd()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM student";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            dgvStudent.DataSource = table2;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO class values('"+txtGrade.Text+"', '"+txtClass.Text+"')";
            command.ExecuteNonQuery();
            loaddataClass();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddataClass();
            loaddataStd();
        }

        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvClass.CurrentRow.Index;
            txtClassID.Text = dgvClass.Rows[i].Cells[0].Value.ToString();
            txtClass.Text = dgvClass.Rows[i].Cells[1].Value.ToString();
            txtGrade.Text = dgvClass.Rows[i].Cells[2].Value.ToString();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int j;
            j = dgvStudent.CurrentRow.Index;
            txtStdId.Text = dgvStudent.Rows[j].Cells[0].Value.ToString();
            txtStudentName.Text = dgvStudent.Rows[j].Cells[1].Value.ToString();
            dtpBirth.Text = dgvStudent.Rows[j].Cells[2].Value.ToString();
            txtAddress.Text = dgvStudent.Rows[j].Cells[3].Value.ToString();
            cbStd.SelectedValue = dgvStudent.Rows[j].Cells[4].Value.ToString();


        }

        private void btnAddStd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO student values('" + txtStudentName.Text + "', '" + dtpBirth.Text + "', '"+ txtAddress.Text+ "', '"+cbStd.SelectedValue.ToString()+"')";
            command.ExecuteNonQuery();
            loaddataStd();
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE class set ClassName ='"+txtClass.Text+"', GradeName = '"+txtGrade.Text+"' where ClassId = '"+txtClassID.Text+"'";
            command.ExecuteNonQuery();
            loaddataClass();
        }

        private void btnEditStd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE student set StudentName ='" + txtStudentName.Text + "', DateofBirth = '" + dtpBirth.Text + "', StudentAddress = '"+ txtAddress.Text + "', ClassId = '"+ cbStd.SelectedValue.ToString() + "' where StudentID = '"+ txtStdId.Text + "'";
            command.ExecuteNonQuery();
            loaddataStd();
        }

        private void btnDelStd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM student where StudentID = '"+ txtStdId.Text + "'";
            command.ExecuteNonQuery();
            loaddataStd();
        }
    }
}
