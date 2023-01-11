namespace SchoolProject
{
    partial class ElevForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.medieTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clasaTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.feedbackTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.medieTxtBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.clasaTxtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numeTxtBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(264, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii generale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medie:";
            // 
            // medieTxtBox
            // 
            this.medieTxtBox.Location = new System.Drawing.Point(97, 78);
            this.medieTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.medieTxtBox.Name = "medieTxtBox";
            this.medieTxtBox.ReadOnly = true;
            this.medieTxtBox.Size = new System.Drawing.Size(50, 23);
            this.medieTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clasa:";
            // 
            // clasaTxtBox
            // 
            this.clasaTxtBox.Location = new System.Drawing.Point(97, 50);
            this.clasaTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clasaTxtBox.Name = "clasaTxtBox";
            this.clasaTxtBox.ReadOnly = true;
            this.clasaTxtBox.Size = new System.Drawing.Size(50, 23);
            this.clasaTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume:";
            // 
            // numeTxtBox
            // 
            this.numeTxtBox.Location = new System.Drawing.Point(97, 28);
            this.numeTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numeTxtBox.Name = "numeTxtBox";
            this.numeTxtBox.ReadOnly = true;
            this.numeTxtBox.Size = new System.Drawing.Size(142, 23);
            this.numeTxtBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.feedbackTxtBox);
            this.groupBox2.Location = new System.Drawing.Point(284, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(267, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scrie feedback catre directiune";
            // 
            // feedbackTxtBox
            // 
            this.feedbackTxtBox.Location = new System.Drawing.Point(4, 18);
            this.feedbackTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.feedbackTxtBox.Multiline = true;
            this.feedbackTxtBox.Name = "feedbackTxtBox";
            this.feedbackTxtBox.Size = new System.Drawing.Size(260, 92);
            this.feedbackTxtBox.TabIndex = 4;
            this.feedbackTxtBox.Text = "...";
            this.feedbackTxtBox.MouseEnter += new System.EventHandler(this.listaMateriiTxtBox_MouseEnter);
            this.feedbackTxtBox.MouseLeave += new System.EventHandler(this.listaMateriiTxtBox_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Trimite feedback";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // ElevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 189);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ElevForm";
            this.Text = "ElevForm";
            this.Load += new System.EventHandler(this.ElevForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox numeTxtBox;
        private Label label2;
        private TextBox clasaTxtBox;
        private Label label3;
        private TextBox medieTxtBox;
        private GroupBox groupBox2;
        private TextBox feedbackTxtBox;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}