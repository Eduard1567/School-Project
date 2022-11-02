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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clasaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME ADMIN!";
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.clasaToolStripMenuItem,
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
            this.elevToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.elevToolStripMenuItem.Text = "Elev";
            this.elevToolStripMenuItem.Click += new System.EventHandler(this.elevToolStripMenuItem_Click);
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.profesorToolStripMenuItem.Text = "Profesor";
            this.profesorToolStripMenuItem.Click += new System.EventHandler(this.profesorToolStripMenuItem_Click);
            // 
            // clasaToolStripMenuItem
            // 
            this.clasaToolStripMenuItem.Name = "clasaToolStripMenuItem";
            this.clasaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.clasaToolStripMenuItem.Text = "Clasa";
            // 
            // materieToolStripMenuItem
            // 
            this.materieToolStripMenuItem.Name = "materieToolStripMenuItem";
            this.materieToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.materieToolStripMenuItem.Text = "Materie";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem1,
            this.clasaToolStripMenuItem1,
            this.materieToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // accountToolStripMenuItem1
            // 
            this.accountToolStripMenuItem1.Name = "accountToolStripMenuItem1";
            this.accountToolStripMenuItem1.Size = new System.Drawing.Size(179, 34);
            this.accountToolStripMenuItem1.Text = "Account";
            // 
            // clasaToolStripMenuItem1
            // 
            this.clasaToolStripMenuItem1.Name = "clasaToolStripMenuItem1";
            this.clasaToolStripMenuItem1.Size = new System.Drawing.Size(179, 34);
            this.clasaToolStripMenuItem1.Text = "Clasa";
            // 
            // materieToolStripMenuItem1
            // 
            this.materieToolStripMenuItem1.Name = "materieToolStripMenuItem1";
            this.materieToolStripMenuItem1.Size = new System.Drawing.Size(179, 34);
            this.materieToolStripMenuItem1.Text = "Materie";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.label1);
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

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem elevToolStripMenuItem;
        private ToolStripMenuItem profesorToolStripMenuItem;
        private ToolStripMenuItem clasaToolStripMenuItem;
        private ToolStripMenuItem materieToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem1;
        private ToolStripMenuItem clasaToolStripMenuItem1;
        private ToolStripMenuItem materieToolStripMenuItem1;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}