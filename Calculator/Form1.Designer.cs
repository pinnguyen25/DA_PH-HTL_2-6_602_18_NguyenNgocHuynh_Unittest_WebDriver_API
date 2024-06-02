namespace Calculator
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
            this.btnPT1_18_Huynh = new System.Windows.Forms.Button();
            this.btnPT2_18_Huynh = new System.Windows.Forms.Button();
            this.btnRS_18_Huynh = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.aa = new System.Windows.Forms.Label();
            this.aâ = new System.Windows.Forms.Label();
            this.ab = new System.Windows.Forms.Label();
            this.vb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPT1_18_Huynh
            // 
            this.btnPT1_18_Huynh.Location = new System.Drawing.Point(190, 262);
            this.btnPT1_18_Huynh.Name = "btnPT1_18_Huynh";
            this.btnPT1_18_Huynh.Size = new System.Drawing.Size(92, 31);
            this.btnPT1_18_Huynh.TabIndex = 0;
            this.btnPT1_18_Huynh.Text = "Giải PT1";
            this.btnPT1_18_Huynh.UseVisualStyleBackColor = true;
            this.btnPT1_18_Huynh.Click += new System.EventHandler(this.btnPT1_18_Huynh_Click);
            // 
            // btnPT2_18_Huynh
            // 
            this.btnPT2_18_Huynh.Location = new System.Drawing.Point(346, 262);
            this.btnPT2_18_Huynh.Name = "btnPT2_18_Huynh";
            this.btnPT2_18_Huynh.Size = new System.Drawing.Size(92, 31);
            this.btnPT2_18_Huynh.TabIndex = 1;
            this.btnPT2_18_Huynh.Text = "Giải PT2";
            this.btnPT2_18_Huynh.UseVisualStyleBackColor = true;
            this.btnPT2_18_Huynh.Click += new System.EventHandler(this.btnPT2_18_Huynh_Click);
            // 
            // btnRS_18_Huynh
            // 
            this.btnRS_18_Huynh.Location = new System.Drawing.Point(498, 262);
            this.btnRS_18_Huynh.Name = "btnRS_18_Huynh";
            this.btnRS_18_Huynh.Size = new System.Drawing.Size(89, 31);
            this.btnRS_18_Huynh.TabIndex = 2;
            this.btnRS_18_Huynh.Text = "Làm lại";
            this.btnRS_18_Huynh.UseVisualStyleBackColor = true;
            this.btnRS_18_Huynh.Click += new System.EventHandler(this.btnRS_18_Huynh_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(309, 53);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(231, 22);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(309, 98);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(231, 22);
            this.txtB.TabIndex = 4;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(309, 142);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(231, 22);
            this.txtC.TabIndex = 5;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(309, 185);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(231, 38);
            this.txtKQ.TabIndex = 6;
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.Location = new System.Drawing.Point(241, 56);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(58, 16);
            this.aa.TabIndex = 7;
            this.aa.Text = "Hệ số A:";
            // 
            // aâ
            // 
            this.aâ.AutoSize = true;
            this.aâ.Location = new System.Drawing.Point(241, 101);
            this.aâ.Name = "aâ";
            this.aâ.Size = new System.Drawing.Size(58, 16);
            this.aâ.TabIndex = 8;
            this.aâ.Text = "Hệ số B:";
            // 
            // ab
            // 
            this.ab.AutoSize = true;
            this.ab.Location = new System.Drawing.Point(241, 145);
            this.ab.Name = "ab";
            this.ab.Size = new System.Drawing.Size(58, 16);
            this.ab.TabIndex = 9;
            this.ab.Text = "Hệ số C:";
            // 
            // vb
            // 
            this.vb.AutoSize = true;
            this.vb.Location = new System.Drawing.Point(241, 197);
            this.vb.Name = "vb";
            this.vb.Size = new System.Drawing.Size(55, 16);
            this.vb.TabIndex = 10;
            this.vb.Text = "Kết quả:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vb);
            this.Controls.Add(this.ab);
            this.Controls.Add(this.aâ);
            this.Controls.Add(this.aa);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnRS_18_Huynh);
            this.Controls.Add(this.btnPT2_18_Huynh);
            this.Controls.Add(this.btnPT1_18_Huynh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPT1_18_Huynh;
        private System.Windows.Forms.Button btnPT2_18_Huynh;
        private System.Windows.Forms.Button btnRS_18_Huynh;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label aa;
        private System.Windows.Forms.Label aâ;
        private System.Windows.Forms.Label ab;
        private System.Windows.Forms.Label vb;
    }
}

