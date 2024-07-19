namespace DatabaseProjectConnect
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
            StudedentRecordDataGridView = new DataGridView();
            label7 = new Label();
            panel1 = new Panel();
            txtClass = new TextBox();
            label8 = new Label();
            label1 = new Label();
            txtMobile = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtRollNumber = new TextBox();
            label4 = new Label();
            txtFatherName = new TextBox();
            label3 = new Label();
            txtStudentName = new TextBox();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)StudedentRecordDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // StudedentRecordDataGridView
            // 
            StudedentRecordDataGridView.AllowUserToAddRows = false;
            StudedentRecordDataGridView.BackgroundColor = SystemColors.ButtonFace;
            StudedentRecordDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudedentRecordDataGridView.Location = new Point(24, 448);
            StudedentRecordDataGridView.Margin = new Padding(3, 4, 3, 4);
            StudedentRecordDataGridView.Name = "StudedentRecordDataGridView";
            StudedentRecordDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudedentRecordDataGridView.Size = new Size(744, 365);
            StudedentRecordDataGridView.TabIndex = 17;
            StudedentRecordDataGridView.CellClick += StudedentRecordDataGridView_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(761, 9);
            label7.Name = "label7";
            label7.Size = new Size(19, 20);
            label7.TabIndex = 19;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(txtClass);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMobile);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtRollNumber);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtFatherName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtStudentName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(24, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 376);
            panel1.TabIndex = 22;
            // 
            // txtClass
            // 
            txtClass.Location = new Point(135, 167);
            txtClass.Margin = new Padding(3, 4, 3, 4);
            txtClass.Multiline = true;
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(190, 29);
            txtClass.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(54, 166);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 37;
            label8.Text = "Class";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(156, 0);
            label1.Name = "label1";
            label1.Size = new Size(432, 41);
            label1.TabIndex = 36;
            label1.Text = "Student Management System";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(135, 230);
            txtMobile.Margin = new Padding(3, 4, 3, 4);
            txtMobile.Multiline = true;
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(190, 29);
            txtMobile.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(54, 233);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 34;
            label6.Text = "Mobile";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(500, 230);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(190, 29);
            txtAddress.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(369, 228);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 32;
            label5.Text = "Address";
            // 
            // txtRollNumber
            // 
            txtRollNumber.Location = new Point(500, 168);
            txtRollNumber.Margin = new Padding(3, 4, 3, 4);
            txtRollNumber.Multiline = true;
            txtRollNumber.Name = "txtRollNumber";
            txtRollNumber.Size = new Size(190, 29);
            txtRollNumber.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(369, 168);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 30;
            label4.Text = "Roll Number";
            // 
            // txtFatherName
            // 
            txtFatherName.Location = new Point(500, 107);
            txtFatherName.Margin = new Padding(3, 4, 3, 4);
            txtFatherName.Multiline = true;
            txtFatherName.Name = "txtFatherName";
            txtFatherName.Size = new Size(190, 29);
            txtFatherName.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(369, 111);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 28;
            label3.Text = "Father's Name";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(135, 106);
            txtStudentName.Margin = new Padding(3, 4, 3, 4);
            txtStudentName.Multiline = true;
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(190, 31);
            txtStudentName.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 105);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 26;
            label2.Text = "Name";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11F);
            button4.Location = new Point(545, 318);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(107, 39);
            button4.TabIndex = 25;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(396, 318);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(107, 39);
            button3.TabIndex = 24;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(245, 318);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(107, 39);
            button2.TabIndex = 23;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(92, 318);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(107, 39);
            button1.TabIndex = 22;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(791, 836);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(StudedentRecordDataGridView);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)StudedentRecordDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView StudedentRecordDataGridView;
        private Label label7;
        private Panel panel1;
        private TextBox txtClass;
        private Label label8;
        private Label label1;
        private TextBox txtMobile;
        private Label label6;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtRollNumber;
        private Label label4;
        private TextBox txtFatherName;
        private Label label3;
        private TextBox txtStudentName;
        private Label label2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
