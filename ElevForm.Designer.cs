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
            this.listaMateriiTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii generale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medie:";
            // 
            // medieTxtBox
            // 
            this.medieTxtBox.Location = new System.Drawing.Point(139, 130);
            this.medieTxtBox.Name = "medieTxtBox";
            this.medieTxtBox.ReadOnly = true;
            this.medieTxtBox.Size = new System.Drawing.Size(70, 31);
            this.medieTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clasa:";
            // 
            // clasaTxtBox
            // 
            this.clasaTxtBox.Location = new System.Drawing.Point(139, 84);
            this.clasaTxtBox.Name = "clasaTxtBox";
            this.clasaTxtBox.ReadOnly = true;
            this.clasaTxtBox.Size = new System.Drawing.Size(70, 31);
            this.clasaTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume:";
            // 
            // numeTxtBox
            // 
            this.numeTxtBox.Location = new System.Drawing.Point(139, 47);
            this.numeTxtBox.Name = "numeTxtBox";
            this.numeTxtBox.ReadOnly = true;
            this.numeTxtBox.Size = new System.Drawing.Size(201, 31);
            this.numeTxtBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listaMateriiTxtBox);
            this.groupBox2.Location = new System.Drawing.Point(406, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista materii";
            // 
            // listaMateriiTxtBox
            // 
            this.listaMateriiTxtBox.Location = new System.Drawing.Point(6, 30);
            this.listaMateriiTxtBox.Multiline = true;
            this.listaMateriiTxtBox.Name = "listaMateriiTxtBox";
            this.listaMateriiTxtBox.ReadOnly = true;
            this.listaMateriiTxtBox.Size = new System.Drawing.Size(370, 150);
            this.listaMateriiTxtBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Verifica notele";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ElevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ElevForm";
            this.Text = "ElevForm";
            this.Load += new System.EventHandler(this.ElevForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private TextBox listaMateriiTxtBox;
        private Button button1;
    }
}