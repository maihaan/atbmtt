
namespace MaHoaDonBang
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
            this.tbGiaTriCanMaHoa = new System.Windows.Forms.TextBox();
            this.btMaHoa = new System.Windows.Forms.Button();
            this.tbKetQuaMaHoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btGiaiMa = new System.Windows.Forms.Button();
            this.tbKetQuaGiaiMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá trị cần mã hóa";
            // 
            // tbGiaTriCanMaHoa
            // 
            this.tbGiaTriCanMaHoa.Location = new System.Drawing.Point(13, 30);
            this.tbGiaTriCanMaHoa.Multiline = true;
            this.tbGiaTriCanMaHoa.Name = "tbGiaTriCanMaHoa";
            this.tbGiaTriCanMaHoa.Size = new System.Drawing.Size(381, 57);
            this.tbGiaTriCanMaHoa.TabIndex = 1;
            // 
            // btMaHoa
            // 
            this.btMaHoa.Location = new System.Drawing.Point(13, 94);
            this.btMaHoa.Name = "btMaHoa";
            this.btMaHoa.Size = new System.Drawing.Size(75, 23);
            this.btMaHoa.TabIndex = 2;
            this.btMaHoa.Text = "Mã hóa";
            this.btMaHoa.UseVisualStyleBackColor = true;
            this.btMaHoa.Click += new System.EventHandler(this.btMaHoa_Click);
            // 
            // tbKetQuaMaHoa
            // 
            this.tbKetQuaMaHoa.Location = new System.Drawing.Point(13, 137);
            this.tbKetQuaMaHoa.Multiline = true;
            this.tbKetQuaMaHoa.Name = "tbKetQuaMaHoa";
            this.tbKetQuaMaHoa.ReadOnly = true;
            this.tbKetQuaMaHoa.Size = new System.Drawing.Size(381, 57);
            this.tbKetQuaMaHoa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết quả mã hóa";
            // 
            // btGiaiMa
            // 
            this.btGiaiMa.Location = new System.Drawing.Point(13, 200);
            this.btGiaiMa.Name = "btGiaiMa";
            this.btGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btGiaiMa.TabIndex = 5;
            this.btGiaiMa.Text = "Giải mã";
            this.btGiaiMa.UseVisualStyleBackColor = true;
            this.btGiaiMa.Click += new System.EventHandler(this.btGiaiMa_Click);
            // 
            // tbKetQuaGiaiMa
            // 
            this.tbKetQuaGiaiMa.Location = new System.Drawing.Point(13, 243);
            this.tbKetQuaGiaiMa.Multiline = true;
            this.tbKetQuaGiaiMa.Name = "tbKetQuaGiaiMa";
            this.tbKetQuaGiaiMa.ReadOnly = true;
            this.tbKetQuaGiaiMa.Size = new System.Drawing.Size(381, 57);
            this.tbKetQuaGiaiMa.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kết quả giải mã";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 312);
            this.Controls.Add(this.tbKetQuaGiaiMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btGiaiMa);
            this.Controls.Add(this.tbKetQuaMaHoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btMaHoa);
            this.Controls.Add(this.tbGiaTriCanMaHoa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGiaTriCanMaHoa;
        private System.Windows.Forms.Button btMaHoa;
        private System.Windows.Forms.TextBox tbKetQuaMaHoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btGiaiMa;
        private System.Windows.Forms.TextBox tbKetQuaGiaiMa;
        private System.Windows.Forms.Label label3;
    }
}

