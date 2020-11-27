using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DBConnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = "select * from tb_teacher";
                var cmd = new OleDbCommand(sql, conn);
                conn.Open();
                var rdr = cmd.ExecuteReader();
                var result = "";
                while (rdr.Read())
                {
                    result += $"Id: {rdr.GetInt32(0)}; First name: {rdr.GetString(1)}; Last name: {rdr.GetString(2)}; Address: {rdr.GetString(3)}; Phone: {rdr.GetString(4)}";
                    result += "\n";
                }

                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if ((conn.State != ConnectionState.Closed))
                {
                    conn.Close();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = $@"
insert into tb_teacher (last_name, first_name, address, phone) 
values('{tbxLastName.Text}', '{tbxFirstName.Text}', '{tbxAddress.Text}', '{tbxPhone.Text}')";

                var cmd = new OleDbCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if ((conn.State != ConnectionState.Closed))
                {
                    conn.Close();
                }
            }
        }
    }
}
