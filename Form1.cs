using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const int id = 123;
        private OleDbConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\sukku\OneDrive\Documents\ChatApp.accdb;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\sukku\OneDrive\Documents\ChatApp.accdb;");
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Username from Users", con);
            con.Open();
            DataSet d1 = new DataSet();
            adapter.Fill(d1);
            con.Close();
            int startX = 10, startY = 10;
            int buttonWidth = 200, buttonHeight = 50;
            int gap = 10;
            int friends = d1.Tables[0].Rows.Count;
            for(int i = 0; i < friends; i++)
            {
                Button btn = new Button();
                btn.Name = "button" + i;
                btn.Text = d1.Tables[0].Rows[i][0].ToString();
                btn.Width = buttonWidth;
                btn.Height = buttonHeight;
                btn.BackColor = Color.FromArgb(35,40,45);
                btn.ForeColor = Color.WhiteSmoke;
                btn.Location = new Point(startX, startY + i * (buttonHeight + gap));
                btn.Click += OpenChat;
                flowLayoutPanel2.Controls.Add(btn);
                btn.BringToFront();
            }
            
            

        }

        private void OpenChat(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string q = "SELECT UserID FROM Users WHERE Username = ?";
            OleDbCommand cmd = new OleDbCommand(q, con);
            cmd.Parameters.AddWithValue("?", btn.Text);

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataSet d1 = new DataSet();
            con.Open();
            adapter.Fill(d1);
            con.Close();
            string friendID = d1.Tables[0].Rows[0][0].ToString();
            string q1 = "SELECT Message FROM Messages WHERE (SenderID = ? AND RecvID = ?) OR (SenderID = ? AND RecvID = ?) ORDER BY Time";
            OleDbCommand cmd1 = new OleDbCommand(q1, con);
            cmd1.Parameters.AddWithValue("?", id);
            cmd1.Parameters.AddWithValue("?", int.Parse(friendID));
            cmd1.Parameters.AddWithValue("?", int.Parse(friendID));
            cmd1.Parameters.AddWithValue("?", id);
            OleDbDataAdapter adp1 = new OleDbDataAdapter(cmd1);
            DataSet d2 = new DataSet();

            con.Open();
            adp1.Fill(d2);
            con.Close();

            dataGridView1.DataSource = d2.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
