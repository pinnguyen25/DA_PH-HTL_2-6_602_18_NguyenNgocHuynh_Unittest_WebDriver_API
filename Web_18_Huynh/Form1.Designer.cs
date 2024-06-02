namespace Web_18_Huynh
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
            this.btnBack_18 = new System.Windows.Forms.Button();
            this.btnN_18 = new System.Windows.Forms.Button();
            this.btnF_18 = new System.Windows.Forms.Button();
            this.btnChon_18 = new System.Windows.Forms.Button();
            this.btnOpen_18 = new System.Windows.Forms.Button();
            this.btnSearch_18 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack_18
            // 
            this.btnBack_18.Location = new System.Drawing.Point(157, 278);
            this.btnBack_18.Name = "btnBack_18";
            this.btnBack_18.Size = new System.Drawing.Size(99, 36);
            this.btnBack_18.TabIndex = 17;
            this.btnBack_18.Text = "Quay lại";
            this.btnBack_18.UseVisualStyleBackColor = true;
            // 
            // btnN_18
            // 
            this.btnN_18.Location = new System.Drawing.Point(525, 278);
            this.btnN_18.Name = "btnN_18";
            this.btnN_18.Size = new System.Drawing.Size(118, 36);
            this.btnN_18.TabIndex = 16;
            this.btnN_18.Text = "Đọc mới nhất";
            this.btnN_18.UseVisualStyleBackColor = true;
            // 
            // btnF_18
            // 
            this.btnF_18.Location = new System.Drawing.Point(401, 278);
            this.btnF_18.Name = "btnF_18";
            this.btnF_18.Size = new System.Drawing.Size(99, 36);
            this.btnF_18.TabIndex = 15;
            this.btnF_18.Text = "Đọc từ đầu";
            this.btnF_18.UseVisualStyleBackColor = true;
            // 
            // btnChon_18
            // 
            this.btnChon_18.Location = new System.Drawing.Point(283, 278);
            this.btnChon_18.Name = "btnChon_18";
            this.btnChon_18.Size = new System.Drawing.Size(95, 36);
            this.btnChon_18.TabIndex = 14;
            this.btnChon_18.Text = "Chọn";
            this.btnChon_18.UseVisualStyleBackColor = true;
            // 
            // btnOpen_18
            // 
            this.btnOpen_18.Location = new System.Drawing.Point(339, 136);
            this.btnOpen_18.Name = "btnOpen_18";
            this.btnOpen_18.Size = new System.Drawing.Size(99, 34);
            this.btnOpen_18.TabIndex = 13;
            this.btnOpen_18.Text = "Open";
            this.btnOpen_18.UseVisualStyleBackColor = true;
            this.btnOpen_18.Click += new System.EventHandler(this.btnOpen_18_Click);
            // 
            // btnSearch_18
            // 
            this.btnSearch_18.Location = new System.Drawing.Point(221, 208);
            this.btnSearch_18.Name = "btnSearch_18";
            this.btnSearch_18.Size = new System.Drawing.Size(98, 31);
            this.btnSearch_18.TabIndex = 11;
            this.btnSearch_18.Text = "Search";
            this.btnSearch_18.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(339, 208);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 31);
            this.txtSearch.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack_18);
            this.Controls.Add(this.btnN_18);
            this.Controls.Add(this.btnF_18);
            this.Controls.Add(this.btnChon_18);
            this.Controls.Add(this.btnOpen_18);
            this.Controls.Add(this.btnSearch_18);
            this.Controls.Add(this.txtSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack_18;
        private System.Windows.Forms.Button btnN_18;
        private System.Windows.Forms.Button btnF_18;
        private System.Windows.Forms.Button btnChon_18;
        private System.Windows.Forms.Button btnOpen_18;
        private System.Windows.Forms.Button btnSearch_18;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

