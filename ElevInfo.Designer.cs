namespace SchoolProject
{
    partial class ElevInfo
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
            this.noteElevListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.medieGeneralaLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.notaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.privateMsgTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // noteElevListBox
            // 
            this.noteElevListBox.FormattingEnabled = true;
            this.noteElevListBox.ItemHeight = 25;
            this.noteElevListBox.Location = new System.Drawing.Point(150, 12);
            this.noteElevListBox.Name = "noteElevListBox";
            this.noteElevListBox.Size = new System.Drawing.Size(106, 129);
            this.noteElevListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notele elevului:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Media generala:";
            // 
            // medieGeneralaLabel
            // 
            this.medieGeneralaLabel.AutoSize = true;
            this.medieGeneralaLabel.Location = new System.Drawing.Point(168, 167);
            this.medieGeneralaLabel.Name = "medieGeneralaLabel";
            this.medieGeneralaLabel.Size = new System.Drawing.Size(61, 25);
            this.medieGeneralaLabel.TabIndex = 3;
            this.medieGeneralaLabel.Text = "medie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.notaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(291, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Noteaza elevul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notaTextBox
            // 
            this.notaTextBox.Location = new System.Drawing.Point(85, 47);
            this.notaTextBox.Name = "notaTextBox";
            this.notaTextBox.Size = new System.Drawing.Size(76, 31);
            this.notaTextBox.TabIndex = 0;
            this.notaTextBox.Text = "nota";
            this.notaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.privateMsgTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 229);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trimite mesaj privat elevului";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(402, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Trimite mesaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // privateMsgTextBox
            // 
            this.privateMsgTextBox.Location = new System.Drawing.Point(6, 48);
            this.privateMsgTextBox.Multiline = true;
            this.privateMsgTextBox.Name = "privateMsgTextBox";
            this.privateMsgTextBox.Size = new System.Drawing.Size(506, 121);
            this.privateMsgTextBox.TabIndex = 0;
            // 
            // ElevInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.medieGeneralaLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteElevListBox);
            this.Name = "ElevInfo";
            this.Text = "ElevInfo";
            this.Load += new System.EventHandler(this.ElevInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox noteElevListBox;
        private Label label1;
        private Label label2;
        private Label medieGeneralaLabel;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox notaTextBox;
        private GroupBox groupBox2;
        private Button button2;
        private TextBox privateMsgTextBox;
    }
}