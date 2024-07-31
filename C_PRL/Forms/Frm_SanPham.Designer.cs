namespace C_PRL.Forms
{
    partial class Frm_SanPham
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
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txt_timkiem = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1103, 287);
            dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(63, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 197);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 79);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 2;
            label1.Text = "Tên Sản Phẩm";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 139);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 3;
            label2.Text = "Giá Sản Phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 210);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_timkiem);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(-1, 305);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1105, 359);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bảng Chi Tiết Sản Phẩm";
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(146, 45);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(150, 31);
            txt_timkiem.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 46);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 2;
            label4.Text = "Tìm Kiếm";
            // 
            // Frm_SanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 663);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Frm_SanPham";
            Text = "Frm_SanPham";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txt_timkiem;
    }
}