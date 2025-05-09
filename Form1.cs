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
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const int id = 123;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //resizing logic
            panel2.Dock = DockStyle.Top;  // Top panel
            panel1.Dock = DockStyle.Bottom;
            panel4.Dock = DockStyle.Fill;
            // Place both controls inside panel1 manually or via Designer
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            button1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            
            
            ApplyRoundedCorners(panel5,20);
            ApplyRoundedCorners(panel6,20);
            

            //connection logic
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\sukku\OneDrive\Documents\ChatApp.accdb;");
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Username from Users", con);
            con.Open();
            DataSet d1 = new DataSet();
            adapter.Fill(d1);
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
                //btn.Click += Button_Click;
                flowLayoutPanel2.Controls.Add(btn);
                btn.BringToFront();
            }
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // label2.TextAlign = ContentAlignment.MiddleCenter;
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
            
            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // textBox1.TextAlign=ContentAlignment.MiddleLeft;
            
        }
        
        private void textBox1_Leave(object sender, EventArgs e)
        {
            //placeholder text logic p1
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter Message";
                textBox1.ForeColor= Color.Gray;
            }
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            //placeholder text logic p2
            if (textBox1.Text == "Enter Message")
            {
                textBox1.Text = "";
                textBox1.ForeColor= Color.Black;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            Color borderColor = Color.Gray;
            int borderWidth = 1;
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid);
        
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // panel3.BackgroundImage=Image.FromFile();
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void flowLayoutPanel3_Resize(object sender, EventArgs e)
        {
            // Check if label2 exists in flowLayoutPanel3
            if (flowLayoutPanel3.Controls.Contains(label2))
            {
                // Update label2 width if AutoSize is enabled
                label2.AutoSize = true;

                // Center label2 horizontally
                int centerX = (flowLayoutPanel3.Width - label2.Width) / 2;
                label2.Margin = new Padding(centerX, label2.Margin.Top, 0, 0);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
        }

        private void flowLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {
           
            
        }

        private void flowLayoutPanel3_Resize_1(object sender, EventArgs e)
        {
            if (flowLayoutPanel3.Controls.Contains(label2))
            {
                // Make sure AutoSize is set to false for label2
                label2.AutoSize = false;

                // Set the label size to its current width and height (or define it)
                label2.Width = flowLayoutPanel3.Width;

                // Center label2 horizontally inside flowLayoutPanel3
                label2.Location = new Point((flowLayoutPanel3.Width - label2.Width) / 2, label2.Location.Y);
            }
        }
        

        private void textBox2_Enter(object sender, EventArgs e)
        {
            //placeholder text logic p2
            if (textBox2.Text == "Search or start a new chat")
            {
                textBox2.Text = "";
                textBox2.ForeColor= Color.Black;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Search or start a new chat";
                textBox2.ForeColor= Color.Gray;
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //this is for the name of the person we talkin to ,its size would 
            //automatically adapt to the width of name
            
        }


        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.LightGray;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.BackColor= Color.White;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightGray;
            
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
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

        private void addbordercolor(Panel panel,PaintEventArgs e)
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

                using (Pen borderPen = new Pen(Color.DarkBlue, 2))  // Change color/thickness here
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            addbordercolor(panel5,e);
           
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            addbordercolor(panel6,e);
            
        }
    }
}
