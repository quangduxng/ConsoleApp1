
namespace BasicWinForm
{
    partial class FrmTimer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nmTimer = new System.Windows.Forms.NumericUpDown();
            this.btnBauDau = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian (s)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nmTimer
            // 
            this.nmTimer.Location = new System.Drawing.Point(191, 41);
            this.nmTimer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmTimer.Name = "nmTimer";
            this.nmTimer.Size = new System.Drawing.Size(120, 20);
            this.nmTimer.TabIndex = 1;
            this.nmTimer.ThousandsSeparator = true;
            this.nmTimer.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // btnBauDau
            // 
            this.btnBauDau.Location = new System.Drawing.Point(93, 129);
            this.btnBauDau.Name = "btnBauDau";
            this.btnBauDau.Size = new System.Drawing.Size(75, 23);
            this.btnBauDau.TabIndex = 2;
            this.btnBauDau.Text = "Bắt Đầu";
            this.btnBauDau.UseVisualStyleBackColor = true;
            this.btnBauDau.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(226, 129);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(75, 23);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.ForeColor = System.Drawing.Color.Red;
            this.lbltimer.Location = new System.Drawing.Point(173, 80);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(64, 46);
            this.lbltimer.TabIndex = 4;
            this.lbltimer.Text = "60";
            // 
            // FrmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnBauDau);
            this.Controls.Add(this.nmTimer);
            this.Controls.Add(this.label1);
            this.Name = "FrmTimer";
            this.Text = "FrmTimer";
            this.Load += new System.EventHandler(this.FrmTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmTimer;
        private System.Windows.Forms.Button btnBauDau;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltimer;
    }
}