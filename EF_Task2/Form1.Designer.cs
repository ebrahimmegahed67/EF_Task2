namespace EF_Task2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_author = new DataGridView();
            txt_name = new TextBox();
            txt_userName = new TextBox();
            txt_password = new TextBox();
            nu_age = new NumericUpDown();
            date = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_author).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nu_age).BeginInit();
            SuspendLayout();
            // 
            // dgv_author
            // 
            dgv_author.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_author.Location = new Point(76, 247);
            dgv_author.Name = "dgv_author";
            dgv_author.Size = new Size(637, 176);
            dgv_author.TabIndex = 0;
            dgv_author.CellContentClick += dataGridView1_CellContentClick;
            dgv_author.RowHeaderMouseClick += dgv_author_RowHeaderMouseClick;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(158, 27);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 1;
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(158, 67);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(100, 23);
            txt_userName.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.AcceptsReturn = true;
            txt_password.Location = new Point(158, 111);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(100, 23);
            txt_password.TabIndex = 3;
            // 
            // nu_age
            // 
            nu_age.Location = new Point(158, 153);
            nu_age.Name = "nu_age";
            nu_age.Size = new Size(120, 23);
            nu_age.TabIndex = 4;
            // 
            // date
            // 
            date.Location = new Point(158, 203);
            date.Name = "date";
            date.Size = new Size(200, 23);
            date.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 35);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 161);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 7;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 119);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 75);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 211);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 10;
            label5.Text = "Date";
            // 
            // button1
            // 
            button1.Location = new Point(551, 31);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(551, 119);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(551, 75);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(date);
            Controls.Add(nu_age);
            Controls.Add(txt_password);
            Controls.Add(txt_userName);
            Controls.Add(txt_name);
            Controls.Add(dgv_author);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_author).EndInit();
            ((System.ComponentModel.ISupportInitialize)nu_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_author;
        private TextBox txt_name;
        private TextBox txt_userName;
        private TextBox txt_password;
        private NumericUpDown nu_age;
        private DateTimePicker date;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
