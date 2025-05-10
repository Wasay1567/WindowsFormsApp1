namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();

            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(250, 246, 233);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(417, 640);

            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(250, 246, 233);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(412, 100);

            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Text = "Chat Ned";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Size = new System.Drawing.Size(412, 100);
            this.label2.Padding = new System.Windows.Forms.Padding(50, 0, 30, 0);

            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(250, 246, 233);
            this.flowLayoutPanel2.Controls.Add(this.textBox2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 109);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(412, 501);

            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Size = new System.Drawing.Size(400, 36);
            this.textBox2.Text = "Search or start a new chat";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(421, 106);
            this.label1.Size = new System.Drawing.Size(0, 87);

            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(417, 540);
            this.panel1.Size = new System.Drawing.Size(851, 100);

            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(688, 27);
            this.button1.Size = new System.Drawing.Size(123, 47);
            this.button1.Text = "Send";

            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(16, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Size = new System.Drawing.Size(666, 36);
            this.textBox1.Text = "Enter Message";

            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(417, 0);
            this.panel2.Size = new System.Drawing.Size(851, 100);

            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(100, 60);
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.Text = "Active Now";

            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(20, 20);
            this.panel3.Size = new System.Drawing.Size(60, 60);

            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(100, 20);
            this.label3.Size = new System.Drawing.Size(200, 30);
            this.label3.Text = "Chat Bot";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1268, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Chat App";
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}
