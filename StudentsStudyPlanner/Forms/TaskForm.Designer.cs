namespace StudentsStudyPlanner.Forms
{
    partial class TaskForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelUntil = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelAdditional = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.dateTimeDeadline = new System.Windows.Forms.DateTimePicker();
            this.comboTaskType = new System.Windows.Forms.ComboBox();
            this.comboPriority = new System.Windows.Forms.ComboBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(81, 394);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(627, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отказ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(72, 7);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Име:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(75, 57);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Описание:";
            // 
            // labelUntil
            // 
            this.labelUntil.AutoSize = true;
            this.labelUntil.Location = new System.Drawing.Point(78, 127);
            this.labelUntil.Name = "labelUntil";
            this.labelUntil.Size = new System.Drawing.Size(68, 13);
            this.labelUntil.TabIndex = 4;
            this.labelUntil.Text = "Краен срок:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(78, 183);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(29, 13);
            this.labelType.TabIndex = 5;
            this.labelType.Text = "Тип:";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(78, 239);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(64, 13);
            this.labelPriority.TabIndex = 6;
            this.labelPriority.Text = "Приоритет:";
            this.labelPriority.Click += new System.EventHandler(this.labelPriority_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(78, 294);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 13);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Статус:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(433, 127);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(91, 13);
            this.labelSubject.TabIndex = 8;
            this.labelSubject.Text = "Предмет / тема:";
            // 
            // labelAdditional
            // 
            this.labelAdditional.AutoSize = true;
            this.labelAdditional.Location = new System.Drawing.Point(433, 183);
            this.labelAdditional.Name = "labelAdditional";
            this.labelAdditional.Size = new System.Drawing.Size(197, 13);
            this.labelAdditional.TabIndex = 9;
            this.labelAdditional.Text = "Допълнително (упр. № / стая / екип):";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(627, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(75, 74);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(627, 20);
            this.txtDescription.TabIndex = 11;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(436, 144);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(266, 20);
            this.txtSubject.TabIndex = 12;
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(436, 203);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(266, 20);
            this.txtExtra.TabIndex = 13;
            // 
            // dateTimeDeadline
            // 
            this.dateTimeDeadline.Location = new System.Drawing.Point(78, 144);
            this.dateTimeDeadline.Name = "dateTimeDeadline";
            this.dateTimeDeadline.Size = new System.Drawing.Size(203, 20);
            this.dateTimeDeadline.TabIndex = 14;
            // 
            // comboTaskType
            // 
            this.comboTaskType.FormattingEnabled = true;
            this.comboTaskType.Location = new System.Drawing.Point(81, 202);
            this.comboTaskType.Name = "comboTaskType";
            this.comboTaskType.Size = new System.Drawing.Size(203, 21);
            this.comboTaskType.TabIndex = 15;
            // 
            // comboPriority
            // 
            this.comboPriority.FormattingEnabled = true;
            this.comboPriority.Location = new System.Drawing.Point(81, 255);
            this.comboPriority.Name = "comboPriority";
            this.comboPriority.Size = new System.Drawing.Size(203, 21);
            this.comboPriority.TabIndex = 16;
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(81, 310);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(200, 21);
            this.comboStatus.TabIndex = 17;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.comboPriority);
            this.Controls.Add(this.comboTaskType);
            this.Controls.Add(this.dateTimeDeadline);
            this.Controls.Add(this.txtExtra);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelAdditional);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelUntil);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelUntil;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelAdditional;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.DateTimePicker dateTimeDeadline;
        private System.Windows.Forms.ComboBox comboTaskType;
        private System.Windows.Forms.ComboBox comboPriority;
        private System.Windows.Forms.ComboBox comboStatus;
    }
}