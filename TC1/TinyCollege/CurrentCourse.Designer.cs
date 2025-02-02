﻿namespace TinyCollege
{
    partial class frmCurrentCourse
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
            this.grpCourseData = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lstCourseData = new System.Windows.Forms.ListBox();
            this.lblCurrentEnrollment = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpCourseData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCourseData
            // 
            this.grpCourseData.Controls.Add(this.btnFind);
            this.grpCourseData.Controls.Add(this.txtCourseTitle);
            this.grpCourseData.Controls.Add(this.txtCourseID);
            this.grpCourseData.Controls.Add(this.lblCourseTitle);
            this.grpCourseData.Controls.Add(this.lblCourseID);
            this.grpCourseData.Location = new System.Drawing.Point(6, 11);
            this.grpCourseData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCourseData.Name = "grpCourseData";
            this.grpCourseData.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCourseData.Size = new System.Drawing.Size(463, 140);
            this.grpCourseData.TabIndex = 0;
            this.grpCourseData.TabStop = false;
            this.grpCourseData.Text = "Course Data";
            this.grpCourseData.Enter += new System.EventHandler(this.grpCourseData_Enter);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(379, 25);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(72, 35);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourseTitle.Location = new System.Drawing.Point(150, 90);
            this.txtCourseTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.ReadOnly = true;
            this.txtCourseTitle.Size = new System.Drawing.Size(261, 20);
            this.txtCourseTitle.TabIndex = 6;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(139, 35);
            this.txtCourseID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(224, 20);
            this.txtCourseID.TabIndex = 5;
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.AutoSize = true;
            this.lblCourseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseTitle.Location = new System.Drawing.Point(14, 81);
            this.lblCourseTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(134, 26);
            this.lblCourseTitle.TabIndex = 4;
            this.lblCourseTitle.Text = "Course Title:";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.Location = new System.Drawing.Point(14, 25);
            this.lblCourseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(116, 26);
            this.lblCourseID.TabIndex = 3;
            this.lblCourseID.Text = "Course ID:";
            // 
            // lstCourseData
            // 
            this.lstCourseData.FormattingEnabled = true;
            this.lstCourseData.Location = new System.Drawing.Point(6, 205);
            this.lstCourseData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCourseData.Name = "lstCourseData";
            this.lstCourseData.Size = new System.Drawing.Size(465, 82);
            this.lstCourseData.TabIndex = 1;
            // 
            // lblCurrentEnrollment
            // 
            this.lblCurrentEnrollment.AutoSize = true;
            this.lblCurrentEnrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentEnrollment.Location = new System.Drawing.Point(6, 162);
            this.lblCurrentEnrollment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentEnrollment.Name = "lblCurrentEnrollment";
            this.lblCurrentEnrollment.Size = new System.Drawing.Size(366, 26);
            this.lblCurrentEnrollment.TabIndex = 2;
            this.lblCurrentEnrollment.Text = "All Students Enrolled in This Course:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(176, 288);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 38);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCurrentCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 333);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCurrentEnrollment);
            this.Controls.Add(this.lstCourseData);
            this.Controls.Add(this.grpCourseData);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCurrentCourse";
            this.Text = "Current Course";
            this.grpCourseData.ResumeLayout(false);
            this.grpCourseData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCourseData;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.Label lblCourseID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox lstCourseData;
        private System.Windows.Forms.Label lblCurrentEnrollment;
        private System.Windows.Forms.Button btnClose;
    }
}