﻿namespace TinyCollege
{
    partial class frmCurrentlyEnrolled
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
            this.grpStudentData = new System.Windows.Forms.GroupBox();
            this.lblStudentResults = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCoursesByStudent = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstCourseList = new System.Windows.Forms.ListBox();
            this.grpStudentData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStudentData
            // 
            this.grpStudentData.Controls.Add(this.lblStudentResults);
            this.grpStudentData.Controls.Add(this.btnFind);
            this.grpStudentData.Controls.Add(this.txtStudentID);
            this.grpStudentData.Controls.Add(this.lblStudentName);
            this.grpStudentData.Controls.Add(this.label1);
            this.grpStudentData.Location = new System.Drawing.Point(6, 0);
            this.grpStudentData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpStudentData.Name = "grpStudentData";
            this.grpStudentData.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpStudentData.Size = new System.Drawing.Size(498, 124);
            this.grpStudentData.TabIndex = 0;
            this.grpStudentData.TabStop = false;
            this.grpStudentData.Text = "Student Data:";
            // 
            // lblStudentResults
            // 
            this.lblStudentResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudentResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentResults.Location = new System.Drawing.Point(170, 83);
            this.lblStudentResults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentResults.Name = "lblStudentResults";
            this.lblStudentResults.Size = new System.Drawing.Size(322, 27);
            this.lblStudentResults.TabIndex = 5;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(404, 24);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(88, 34);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(149, 33);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(238, 20);
            this.txtStudentID.TabIndex = 2;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(13, 83);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(158, 26);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // lblCoursesByStudent
            // 
            this.lblCoursesByStudent.AutoSize = true;
            this.lblCoursesByStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursesByStudent.Location = new System.Drawing.Point(13, 142);
            this.lblCoursesByStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoursesByStudent.Name = "lblCoursesByStudent";
            this.lblCoursesByStudent.Size = new System.Drawing.Size(281, 26);
            this.lblCoursesByStudent.TabIndex = 6;
            this.lblCoursesByStudent.Text = "All Course by This Student: ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(170, 310);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 37);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstCourseList
            // 
            this.lstCourseList.FormattingEnabled = true;
            this.lstCourseList.Location = new System.Drawing.Point(18, 191);
            this.lstCourseList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCourseList.Name = "lstCourseList";
            this.lstCourseList.Size = new System.Drawing.Size(482, 108);
            this.lstCourseList.TabIndex = 8;
            // 
            // frmCurrentlyEnrolled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 361);
            this.Controls.Add(this.lstCourseList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCoursesByStudent);
            this.Controls.Add(this.grpStudentData);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCurrentlyEnrolled";
            this.Text = "What Course is a Student Currently Enrolled";
            this.Load += new System.EventHandler(this.frmCurrentlyEnrolled_Load);
            this.grpStudentData.ResumeLayout(false);
            this.grpStudentData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStudentData;
        private System.Windows.Forms.Label lblStudentResults;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCoursesByStudent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstCourseList;
    }
}