namespace TPModul3_2311104070
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labeloutp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aulia Jasifa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(512, 245);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(100, 26);
            this.txtinput.TabIndex = 1;
            this.txtinput.TextChanged += new System.EventHandler(this.txtinput_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(512, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labeloutp
            // 
            this.labeloutp.AutoSize = true;
            this.labeloutp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labeloutp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeloutp.Location = new System.Drawing.Point(220, 156);
            this.labeloutp.Name = "labeloutp";
            this.labeloutp.Size = new System.Drawing.Size(327, 46);
            this.labeloutp.TabIndex = 3;
            this.labeloutp.Text = "Hallo Aulia Jasifa";
            this.labeloutp.Click += new System.EventHandler(this.labeloutp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeloutp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labeloutp;
    }
}

