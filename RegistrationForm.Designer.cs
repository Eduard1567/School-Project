﻿namespace SchoolProject
{
    partial class RegistrationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPasswdTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.passwdTxtBox = new System.Windows.Forms.TextBox();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.confirmPasswdTxtBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.passwdTxtBox);
            this.groupBox1.Controls.Add(this.userTxtBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 265);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Confirm password";
            // 
            // confirmPasswdTxtBox
            // 
            this.confirmPasswdTxtBox.Location = new System.Drawing.Point(70, 139);
            this.confirmPasswdTxtBox.Name = "confirmPasswdTxtBox";
            this.confirmPasswdTxtBox.PasswordChar = '*';
            this.confirmPasswdTxtBox.Size = new System.Drawing.Size(280, 31);
            this.confirmPasswdTxtBox.TabIndex = 2;
            this.confirmPasswdTxtBox.Text = "password";
            this.confirmPasswdTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwdTxtBox
            // 
            this.passwdTxtBox.Location = new System.Drawing.Point(70, 67);
            this.passwdTxtBox.Name = "passwdTxtBox";
            this.passwdTxtBox.PasswordChar = '*';
            this.passwdTxtBox.Size = new System.Drawing.Size(280, 31);
            this.passwdTxtBox.TabIndex = 1;
            this.passwdTxtBox.Text = "password";
            this.passwdTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(70, 30);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(280, 31);
            this.userTxtBox.TabIndex = 0;
            this.userTxtBox.Text = "username";
            this.userTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 327);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox passwdTxtBox;
        private TextBox userTxtBox;
        private Label label1;
        private TextBox confirmPasswdTxtBox;
    }
}