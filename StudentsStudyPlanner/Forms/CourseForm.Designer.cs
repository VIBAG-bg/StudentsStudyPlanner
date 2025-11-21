namespace StudentsStudyPlanner.Forms
{
    partial class CourseForm
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
            this.lableName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.labelSemester = new System.Windows.Forms.Label();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lableName
            // 
            this.lableName.AutoSize = true;
            this.lableName.Location = new System.Drawing.Point(370, 9);
            this.lableName.Name = "lableName";
            this.lableName.Size = new System.Drawing.Size(73, 13);
            this.lableName.TabIndex = 0;
            this.lableName.Text = "Име на курс:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(543, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(392, 115);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(29, 13);
            this.labelCode.TabIndex = 2;
            this.labelCode.Text = "Код:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(149, 159);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(543, 20);
            this.txtCode.TabIndex = 3;
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(370, 212);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(83, 13);
            this.labelTeacher.TabIndex = 4;
            this.labelTeacher.Text = "Преподавател:";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(149, 254);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(543, 20);
            this.txtTeacher.TabIndex = 5;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Location = new System.Drawing.Point(392, 290);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(57, 13);
            this.labelSemester.TabIndex = 8;
            this.labelSemester.Text = "Семестър:";
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(149, 316);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(543, 20);
            this.txtSemester.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(253, 362);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(548, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отказ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lableName);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.TextBox txtSemester;
    }
}