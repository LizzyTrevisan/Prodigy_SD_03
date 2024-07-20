namespace Prodigy_SD_03
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(617, 30);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(617, 30);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(158, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(617, 30);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(158, 191);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(617, 30);
            textBox4.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(158, 250);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.HotTrack;
            button2.Location = new Point(286, 250);
            button2.Name = "button2";
            button2.Size = new Size(100, 36);
            button2.TabIndex = 5;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.HotTrack;
            button3.Location = new Point(425, 250);
            button3.Name = "button3";
            button3.Size = new Size(91, 36);
            button3.TabIndex = 6;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.HotTrack;
            button4.Location = new Point(554, 250);
            button4.Name = "button4";
            button4.Size = new Size(95, 36);
            button4.TabIndex = 7;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.HotTrack;
            button5.Location = new Point(684, 250);
            button5.Name = "button5";
            button5.Size = new Size(91, 36);
            button5.TabIndex = 8;
            button5.Text = "View All";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.HotTrack;
            button6.Location = new Point(351, 589);
            button6.Name = "button6";
            button6.Size = new Size(105, 31);
            button6.TabIndex = 9;
            button6.Text = "Download";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 316);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(771, 232);
            dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(57, 50);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 11;
            label1.Text = "Contact ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(57, 92);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(57, 141);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 13;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(62, 191);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 14;
            label4.Text = "Email";
            // 
            // Form1
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(817, 680);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.HotTrack;
            Name = "Form1";
            Text = "Contact Manage System";
            TopMost = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
