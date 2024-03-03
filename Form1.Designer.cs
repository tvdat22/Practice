namespace Practice
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelStd = new System.Windows.Forms.Button();
            this.btnEditStd = new System.Windows.Forms.Button();
            this.btnAddStd = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.cbStd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStdId = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lớp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtClassID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnEditClass);
            this.panel3.Controls.Add(this.btnAddClass);
            this.panel3.Controls.Add(this.txtClass);
            this.panel3.Controls.Add(this.lbClass);
            this.panel3.Controls.Add(this.lbGrade);
            this.panel3.Controls.Add(this.txtGrade);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 173);
            this.panel3.TabIndex = 1;
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(121, 27);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.ReadOnly = true;
            this.txtClassID.Size = new System.Drawing.Size(163, 22);
            this.txtClassID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã lớp";
            // 
            // btnEditClass
            // 
            this.btnEditClass.Location = new System.Drawing.Point(621, 88);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(115, 50);
            this.btnEditClass.TabIndex = 5;
            this.btnEditClass.Text = "Cập nhật";
            this.btnEditClass.UseVisualStyleBackColor = true;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(621, 20);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(115, 50);
            this.btnAddClass.TabIndex = 4;
            this.btnAddClass.Text = "Thêm mới";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(121, 76);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(163, 22);
            this.txtClass.TabIndex = 3;
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(41, 79);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(30, 16);
            this.lbClass.TabIndex = 2;
            this.lbClass.Text = "Lớp";
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Location = new System.Drawing.Point(41, 128);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(33, 16);
            this.lbGrade.TabIndex = 1;
            this.lbGrade.Text = "Khối";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(121, 122);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(163, 22);
            this.txtGrade.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvClass);
            this.panel2.Location = new System.Drawing.Point(3, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 236);
            this.panel2.TabIndex = 0;
            // 
            // dgvClass
            // 
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClass.Location = new System.Drawing.Point(0, 0);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowHeadersWidth = 51;
            this.dgvClass.RowTemplate.Height = 24;
            this.dgvClass.Size = new System.Drawing.Size(786, 236);
            this.dgvClass.TabIndex = 0;
            this.dgvClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Học Sinh";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtStdId);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cbStd);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnDelStd);
            this.panel4.Controls.Add(this.btnEditStd);
            this.panel4.Controls.Add(this.btnAddStd);
            this.panel4.Controls.Add(this.lbAddress);
            this.panel4.Controls.Add(this.lbBirth);
            this.panel4.Controls.Add(this.lbName);
            this.panel4.Controls.Add(this.txtAddress);
            this.panel4.Controls.Add(this.dtpBirth);
            this.panel4.Controls.Add(this.txtStudentName);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(786, 179);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lớp";
            // 
            // btnDelStd
            // 
            this.btnDelStd.Location = new System.Drawing.Point(614, 120);
            this.btnDelStd.Name = "btnDelStd";
            this.btnDelStd.Size = new System.Drawing.Size(89, 44);
            this.btnDelStd.TabIndex = 8;
            this.btnDelStd.Text = "Xóa";
            this.btnDelStd.UseVisualStyleBackColor = true;
            this.btnDelStd.Click += new System.EventHandler(this.btnDelStd_Click);
            // 
            // btnEditStd
            // 
            this.btnEditStd.Location = new System.Drawing.Point(614, 70);
            this.btnEditStd.Name = "btnEditStd";
            this.btnEditStd.Size = new System.Drawing.Size(89, 44);
            this.btnEditStd.TabIndex = 7;
            this.btnEditStd.Text = "Cập nhật";
            this.btnEditStd.UseVisualStyleBackColor = true;
            this.btnEditStd.Click += new System.EventHandler(this.btnEditStd_Click);
            // 
            // btnAddStd
            // 
            this.btnAddStd.Location = new System.Drawing.Point(614, 18);
            this.btnAddStd.Name = "btnAddStd";
            this.btnAddStd.Size = new System.Drawing.Size(89, 44);
            this.btnAddStd.TabIndex = 6;
            this.btnAddStd.Text = "Thêm mới";
            this.btnAddStd.UseVisualStyleBackColor = true;
            this.btnAddStd.Click += new System.EventHandler(this.btnAddStd_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(5, 84);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(47, 16);
            this.lbAddress.TabIndex = 5;
            this.lbAddress.Text = "Địa chỉ";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Location = new System.Drawing.Point(5, 52);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(132, 16);
            this.lbBirth.TabIndex = 4;
            this.lbBirth.Text = "Ngày tháng năm sinh";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(5, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(64, 16);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Họ và tên";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(165, 78);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(330, 22);
            this.txtAddress.TabIndex = 2;
            // 
            // dtpBirth
            // 
            this.dtpBirth.CustomFormat = "yyyy-MM-dd";
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirth.Location = new System.Drawing.Point(165, 46);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(115, 22);
            this.dtpBirth.TabIndex = 1;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(165, 18);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(330, 22);
            this.txtStudentName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStudent);
            this.panel1.Location = new System.Drawing.Point(3, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 230);
            this.panel1.TabIndex = 0;
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.Location = new System.Drawing.Point(0, 0);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(786, 230);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // cbStd
            // 
            this.cbStd.FormattingEnabled = true;
            this.cbStd.Location = new System.Drawing.Point(165, 117);
            this.cbStd.Name = "cbStd";
            this.cbStd.Size = new System.Drawing.Size(121, 24);
            this.cbStd.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã học sinh";
            // 
            // txtStdId
            // 
            this.txtStdId.Location = new System.Drawing.Point(396, 117);
            this.txtStdId.Name = "txtStdId";
            this.txtStdId.ReadOnly = true;
            this.txtStdId.Size = new System.Drawing.Size(99, 22);
            this.txtStdId.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnDelStd;
        private System.Windows.Forms.Button btnEditStd;
        private System.Windows.Forms.Button btnAddStd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStd;
        private System.Windows.Forms.TextBox txtStdId;
        private System.Windows.Forms.Label label3;
    }
}

