namespace QuanLyThuVien.View
{
    partial class FormDangNhap
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
            this.buttonDN = new System.Windows.Forms.Button();
            this.textBoxMK = new System.Windows.Forms.TextBox();
            this.textBoxTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDangky = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDN
            // 
            this.buttonDN.BackColor = System.Drawing.Color.Green;
            this.buttonDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDN.Location = new System.Drawing.Point(175, 265);
            this.buttonDN.Name = "buttonDN";
            this.buttonDN.Size = new System.Drawing.Size(141, 46);
            this.buttonDN.TabIndex = 2;
            this.buttonDN.Text = "Dang Nhap";
            this.buttonDN.UseVisualStyleBackColor = false;
            this.buttonDN.Click += new System.EventHandler(this.buttonDN_Click);
            // 
            // textBoxMK
            // 
            this.textBoxMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMK.Location = new System.Drawing.Point(175, 193);
            this.textBoxMK.Multiline = true;
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.Size = new System.Drawing.Size(315, 36);
            this.textBoxMK.TabIndex = 1;
            // 
            // textBoxTK
            // 
            this.textBoxTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTK.Location = new System.Drawing.Point(175, 128);
            this.textBoxTK.Multiline = true;
            this.textBoxTK.Name = "textBoxTK";
            this.textBoxTK.Size = new System.Drawing.Size(315, 36);
            this.textBoxTK.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mat khau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tai khoan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 85);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(194, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dang nhap";
            // 
            // buttonDangky
            // 
            this.buttonDangky.BackColor = System.Drawing.Color.DeepPink;
            this.buttonDangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangky.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDangky.Location = new System.Drawing.Point(351, 265);
            this.buttonDangky.Name = "buttonDangky";
            this.buttonDangky.Size = new System.Drawing.Size(139, 46);
            this.buttonDangky.TabIndex = 3;
            this.buttonDangky.Text = "Dang ky";
            this.buttonDangky.UseVisualStyleBackColor = false;
            this.buttonDangky.Click += new System.EventHandler(this.buttonDangky_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 344);
            this.Controls.Add(this.buttonDangky);
            this.Controls.Add(this.buttonDN);
            this.Controls.Add(this.textBoxMK);
            this.Controls.Add(this.textBoxTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDN;
        private System.Windows.Forms.TextBox textBoxMK;
        private System.Windows.Forms.TextBox textBoxTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDangky;
    }
}