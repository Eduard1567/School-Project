namespace SchoolProject
{
    partial class AdminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clasaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.editToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.materieToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elevToolStripMenuItem,
            this.profesorToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // elevToolStripMenuItem
            // 
            this.elevToolStripMenuItem.Name = "elevToolStripMenuItem";
            this.elevToolStripMenuItem.Size = new System.Drawing.Size(181, 34);
            this.elevToolStripMenuItem.Text = "Elev";
            this.elevToolStripMenuItem.Click += new System.EventHandler(this.elevToolStripMenuItem_Click);
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(181, 34);
            this.profesorToolStripMenuItem.Text = "Profesor";
            this.profesorToolStripMenuItem.Click += new System.EventHandler(this.profesorToolStripMenuItem_Click);
            // 
            // materieToolStripMenuItem
            // 
            this.materieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privatToolStripMenuItem,
            this.publicToolStripMenuItem});
            this.materieToolStripMenuItem.Name = "materieToolStripMenuItem";
            this.materieToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.materieToolStripMenuItem.Text = "Message";
            // 
            // privatToolStripMenuItem
            // 
            this.privatToolStripMenuItem.Name = "privatToolStripMenuItem";
            this.privatToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.privatToolStripMenuItem.Text = "Private";
            // 
            // publicToolStripMenuItem
            // 
            this.publicToolStripMenuItem.Name = "publicToolStripMenuItem";
            this.publicToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.publicToolStripMenuItem.Text = "Public";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem1,
            this.clasaToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.editToolStripMenuItem.Text = "Show";
            // 
            // accountToolStripMenuItem1
            // 
            this.accountToolStripMenuItem1.Name = "accountToolStripMenuItem1";
            this.accountToolStripMenuItem1.Size = new System.Drawing.Size(185, 34);
            this.accountToolStripMenuItem1.Text = "Profesori";
            // 
            // clasaToolStripMenuItem1
            // 
            this.clasaToolStripMenuItem1.Name = "clasaToolStripMenuItem1";
            this.clasaToolStripMenuItem1.Size = new System.Drawing.Size(185, 34);
            this.clasaToolStripMenuItem1.Text = "Elevi";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(668, 229);
            this.listBox1.TabIndex = 2;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Feedback-uri de la elevi";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem elevToolStripMenuItem;
        private ToolStripMenuItem profesorToolStripMenuItem;
        private ToolStripMenuItem materieToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem1;
        private ToolStripMenuItem clasaToolStripMenuItem1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ListBox listBox1;
        private Label label1;
        private ToolStripMenuItem privatToolStripMenuItem;
        private ToolStripMenuItem publicToolStripMenuItem;
    }
}