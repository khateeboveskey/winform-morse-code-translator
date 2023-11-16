using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;



namespace MorseCodeTranslator
{
    public partial class frmHistory : Form
    {

        MySqlConnection conn = new MySqlConnection("server=localhost;database=morse_code_translator;UID=root;password= ");
        public Point mouseLocation;
        public frmHistory()
        {
            InitializeComponent();
   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        public void select()
        {
            string sql = "SELECT * FROM `history`";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
       


    

     

    
        private void frmHistory_Load(object sender, EventArgs e)
        {
            select();
        }

        private void frmHistory_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void frmHistory_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void pbBtnRefresh_Click(object sender, EventArgs e)
        {
            select();
        }

        private void pbBtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                string sql = "DELETE FROM `history` WHERE id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                select();
            }

        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM `history` ";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    select();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
