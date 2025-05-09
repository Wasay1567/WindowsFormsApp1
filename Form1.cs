using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const int id = 123; // Your current user ID
        private OleDbConnection con;

        public Form1()
        {
            InitializeComponent();
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\sukku\OneDrive\Documents\ChatApp.accdb;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Dock panels
            panel2.Dock = DockStyle.Top;
            panel1.Dock = DockStyle.Bottom;
            panel4.Dock = DockStyle.Fill;

            // Anchor input textbox and button
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            button1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;

            // Rounded corners for side panels
            ApplyRoundedCorners(panel5, 20);
            ApplyRoundedCorners(panel6, 20);

            // Load users into buttons
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Username FROM Users", con);
            DataSet userData = new DataSet();
            con.Open();
            adapter.Fill(userData);
            con.Close();

            int startX = 10, startY = 10;
            int buttonWidth = 200, buttonHeight = 50;
            int gap = 10;

            for (int i = 0; i < userData.Tables[0].Rows.Count; i++)
            {
                Button btn = new Button
                {
                    Name = "button" + i,
                    Text = userData.Tables[0].Rows[i][0].ToString(),
                    Width = buttonWidth,
                    Height = buttonHeight,
                    BackColor = Color.FromArgb(35, 40, 45),
                    ForeColor = Color.WhiteSmoke,
                    Location = new Point(startX, startY + i * (buttonHeight + gap))
                };
                btn.Click += OpenChat;
                flowLayoutPanel2.Controls.Add(btn);
                btn.BringToFront();
            }
        }

        private void OpenChat(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string selectedUsername = btn.Text;

            string query = "SELECT UserID FROM Users WHERE Username = ?";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("?", selectedUsername);

            DataSet userIdData = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            con.Open();
            adapter.Fill(userIdData);
            con.Close();

            if (userIdData.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("User not found.");
                return;
            }

            int friendId = Convert.ToInt32(userIdData.Tables[0].Rows[0][0]);

            string chatQuery = "SELECT SenderID, Message FROM Messages WHERE (SenderID = ? AND RecvID = ?) OR (SenderID = ? AND RecvID = ?) ORDER BY Time";
            OleDbCommand chatCmd = new OleDbCommand(chatQuery, con);
            chatCmd.Parameters.AddWithValue("?", id);
            chatCmd.Parameters.AddWithValue("?", friendId);
            chatCmd.Parameters.AddWithValue("?", friendId);
            chatCmd.Parameters.AddWithValue("?", id);

            DataSet messages = new DataSet();
            OleDbDataAdapter messageAdapter = new OleDbDataAdapter(chatCmd);
            con.Open();
            messageAdapter.Fill(messages);
            con.Close();

            // Display chat in RichTextBox
            richTextBox1.Clear();
            foreach (DataRow row in messages.Tables[0].Rows)
            {
                string sender = Convert.ToInt32(row["SenderID"]) == id ? "You" : selectedUsername;
                string message = row["Message"].ToString();
                richTextBox1.AppendText($"{sender}: {message}\n");
            }
        }

        private void ApplyRoundedCorners(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void addbordercolor(Panel panel, PaintEventArgs e)
        {
            int radius = 20;
            Rectangle rect = new Rectangle(1, 1, panel.Width - 2, panel.Height - 2);
            int diameter = radius * 2;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                using (Pen pen = new Pen(Color.DarkBlue, 2))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            addbordercolor(panel5, e);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            addbordercolor(panel6, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Placeholder for Send Button functionality
            // Add message sending logic here if needed
        }
    }
}
