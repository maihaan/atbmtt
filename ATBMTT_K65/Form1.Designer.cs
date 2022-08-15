
namespace Cecar
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
            this.nudHeSoK = new System.Windows.Forms.NumericUpDown();
            this.btMaHoa = new System.Windows.Forms.Button();
            this.tbKetQuaMaHoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeSoK)).BeginInit();
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
            this.tbGiaTriCanMaHoa.Size = new System.Drawing.Size(358, 70);
            this.tbGiaTriCanMaHoa.TabIndex = 1;
            // 
            // nudHeSoK
            // 
            this.nudHeSoK.Location = new System.Drawing.Point(13, 107);
            this.nudHeSoK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeSoK.Name = "nudHeSoK";
            this.nudHeSoK.Size = new System.Drawing.Size(120, 20);
            this.nudHeSoK.TabIndex = 2;
            this.nudHeSoK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btMaHoa
            // 
            this.btMaHoa.Location = new System.Drawing.Point(139, 104);
            this.btMaHoa.Name = "btMaHoa";
            this.btMaHoa.Size = new System.Drawing.Size(75, 23);
            this.btMaHoa.TabIndex = 3;
            this.btMaHoa.Text = "Mã hóa";
            this.btMaHoa.UseVisualStyleBackColor = true;
            this.btMaHoa.Click += new System.EventHandler(this.btMaHoa_Click);
            // 
            // tbKetQuaMaHoa
            // 
            this.tbKetQuaMaHoa.Location = new System.Drawing.Point(13, 152);
            this.tbKetQuaMaHoa.Multiline = true;
            this.tbKetQuaMaHoa.Name = "tbKetQuaMaHoa";
            this.tbKetQuaMaHoa.Size = new System.Drawing.Size(358, 70);
            this.tbKetQuaMaHoa.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kết quả mã hóa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 234);
            this.Controls.Add(this.tbKetQuaMaHoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btMaHoa);
            this.Controls.Add(this.nudHeSoK);
            this.Controls.Add(this.tbGiaTriCanMaHoa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHeSoK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGiaTriCanMaHoa;
        private System.Windows.Forms.NumericUpDown nudHeSoK;
        private System.Windows.Forms.Button btMaHoa;
        private System.Windows.Forms.TextBox tbKetQuaMaHoa;
        private System.Windows.Forms.Label label2;
    }
}

