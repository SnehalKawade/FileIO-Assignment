﻿namespace WindowsFormsApp
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Dept Id";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(376, 70);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(167, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(376, 142);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 20);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Dept Name";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(376, 217);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(167, 20);
            this.txtLocation.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Location";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(235, 305);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(86, 32);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write to File";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(366, 305);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(85, 32);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read from File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(235, 369);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(96, 36);
            this.btnCreateFolder.TabIndex = 8;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(366, 369);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(96, 36);
            this.btnCreateFile.TabIndex = 9;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "File IO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnCreateFile;
    }
}