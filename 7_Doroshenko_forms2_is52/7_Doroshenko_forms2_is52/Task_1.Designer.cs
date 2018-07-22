namespace _7_Doroshenko_forms2_is52
{
    partial class WinQuestion
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
            this.Btnyes = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ви задоволені своєю зарплатою?";
            // 
            // Btnyes
            // 
            this.Btnyes.Location = new System.Drawing.Point(12, 160);
            this.Btnyes.Name = "Btnyes";
            this.Btnyes.Size = new System.Drawing.Size(103, 34);
            this.Btnyes.TabIndex = 1;
            this.Btnyes.Text = "так";
            this.Btnyes.UseVisualStyleBackColor = true;
            this.Btnyes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(173, 160);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(103, 34);
            this.btnno.TabIndex = 3;
            this.btnno.Text = "ні";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            this.btnno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btnno_MouseMove);
            // 
            // WinQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 206);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.Btnyes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WinQuestion";
            this.Text = "Насущне питання";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinQuestion_FormClosing);
            this.Load += new System.EventHandler(this.WinQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnyes;
        private System.Windows.Forms.Button btnno;
    }
}