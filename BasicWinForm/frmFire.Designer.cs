
namespace BasicWinForm
{
    partial class frmFire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFire));
            this.lblFire = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbFire = new System.Windows.Forms.PictureBox();
            this.pbFire2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFire
            // 
            this.lblFire.AutoSize = true;
            this.lblFire.BackColor = System.Drawing.Color.Lime;
            this.lblFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFire.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFire.Location = new System.Drawing.Point(353, 197);
            this.lblFire.Name = "lblFire";
            this.lblFire.Size = new System.Drawing.Size(34, 25);
            this.lblFire.TabIndex = 0;
            this.lblFire.Text = "10";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(177, 311);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Bắt Đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(470, 311);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(75, 23);
            this.btnYear.TabIndex = 2;
            this.btnYear.Text = "Đếm ngược";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbFire
            // 
            this.pbFire.Image = ((System.Drawing.Image)(resources.GetObject("pbFire.Image")));
            this.pbFire.Location = new System.Drawing.Point(3, 12);
            this.pbFire.Name = "pbFire";
            this.pbFire.Size = new System.Drawing.Size(315, 266);
            this.pbFire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFire.TabIndex = 3;
            this.pbFire.TabStop = false;
            // 
            // pbFire2
            // 
            this.pbFire2.Image = ((System.Drawing.Image)(resources.GetObject("pbFire2.Image")));
            this.pbFire2.Location = new System.Drawing.Point(443, 12);
            this.pbFire2.Name = "pbFire2";
            this.pbFire2.Size = new System.Drawing.Size(345, 266);
            this.pbFire2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFire2.TabIndex = 4;
            this.pbFire2.TabStop = false;
            // 
            // frmFire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFire);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbFire);
            this.Controls.Add(this.pbFire2);
            this.Name = "frmFire";
            this.Text = "frmFire";
            ((System.ComponentModel.ISupportInitialize)(this.pbFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFire;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbFire;
        private System.Windows.Forms.PictureBox pbFire2;
    }
}