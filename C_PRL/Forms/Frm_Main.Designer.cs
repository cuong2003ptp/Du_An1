namespace C_PRL.Forms
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pn_Menu = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            pn_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // pn_Menu
            // 
            pn_Menu.BackColor = Color.ForestGreen;
            pn_Menu.Controls.Add(button6);
            pn_Menu.Controls.Add(button5);
            pn_Menu.Controls.Add(button4);
            pn_Menu.Controls.Add(button3);
            pn_Menu.Controls.Add(button2);
            pn_Menu.Controls.Add(button1);
            pn_Menu.Controls.Add(panel1);
            pn_Menu.Dock = DockStyle.Left;
            pn_Menu.Location = new Point(0, 0);
            pn_Menu.Name = "pn_Menu";
            pn_Menu.Size = new Size(300, 755);
            pn_Menu.TabIndex = 0;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Bottom;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(0, 684);
            button6.Name = "button6";
            button6.Size = new Size(300, 71);
            button6.TabIndex = 6;
            button6.Text = "Thoát";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(0, 434);
            button5.Name = "button5";
            button5.Size = new Size(300, 71);
            button5.TabIndex = 5;
            button5.Text = "Khách Hàng";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(0, 363);
            button4.Name = "button4";
            button4.Size = new Size(300, 71);
            button4.TabIndex = 4;
            button4.Text = "Nhân Viên";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(0, 292);
            button3.Name = "button3";
            button3.Size = new Size(300, 71);
            button3.TabIndex = 3;
            button3.Text = "Sản Phẩm";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(0, 221);
            button2.Name = "button2";
            button2.Size = new Size(300, 71);
            button2.TabIndex = 2;
            button2.Text = "Hóa Đơn";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.ImageAlign = ContentAlignment.TopRight;
            button1.Location = new Point(0, 150);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(300, 71);
            button1.TabIndex = 1;
            button1.Text = "Bán Hàng";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 150);
            panel1.TabIndex = 0;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 755);
            Controls.Add(pn_Menu);
            Name = "Frm_Main";
            Text = "Frm_Main";
            pn_Menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Menu;
        private Panel panel1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
    }
}