namespace Csharp_hinhchunhat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCao = new System.Windows.Forms.TextBox();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnDienTich = new System.Windows.Forms.Button();
            this.btnChuVi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH CHU VI VÀ DIỆN TÍCH HÌNH CHỮ NHẬT SỬ DỤNG CLASS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rộng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết quả";
            // 
            // txtCao
            // 
            this.txtCao.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCao.Location = new System.Drawing.Point(387, 101);
            this.txtCao.Name = "txtCao";
            this.txtCao.Size = new System.Drawing.Size(228, 40);
            this.txtCao.TabIndex = 2;
            // 
            // txtRong
            // 
            this.txtRong.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRong.Location = new System.Drawing.Point(387, 164);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(228, 40);
            this.txtRong.TabIndex = 2;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetqua.Location = new System.Drawing.Point(387, 236);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(228, 40);
            this.txtKetqua.TabIndex = 2;
            // 
            // btnDienTich
            // 
            this.btnDienTich.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDienTich.Location = new System.Drawing.Point(287, 321);
            this.btnDienTich.Name = "btnDienTich";
            this.btnDienTich.Size = new System.Drawing.Size(156, 73);
            this.btnDienTich.TabIndex = 3;
            this.btnDienTich.Text = "DIỆN TÍCH";
            this.btnDienTich.UseVisualStyleBackColor = true;
            this.btnDienTich.Click += new System.EventHandler(this.btnDienTich_Click);
            // 
            // btnChuVi
            // 
            this.btnChuVi.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuVi.Location = new System.Drawing.Point(526, 321);
            this.btnChuVi.Name = "btnChuVi";
            this.btnChuVi.Size = new System.Drawing.Size(156, 73);
            this.btnChuVi.TabIndex = 3;
            this.btnChuVi.Text = "CHU VI";
            this.btnChuVi.UseVisualStyleBackColor = true;
            this.btnChuVi.Click += new System.EventHandler(this.btnChuVi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 450);
            this.Controls.Add(this.btnChuVi);
            this.Controls.Add(this.btnDienTich);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtRong);
            this.Controls.Add(this.txtCao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCao;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btnDienTich;
        private System.Windows.Forms.Button btnChuVi;
    }
}

