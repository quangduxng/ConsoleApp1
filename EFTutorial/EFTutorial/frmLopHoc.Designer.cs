
namespace EFTutorial
{
    partial class frmLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopHoc));
            this.dtgvLopHoc = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopHocVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnThêm = new System.Windows.Forms.ToolStripButton();
            this.lopHocVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocVMBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocVMBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLopHoc
            // 
            this.dtgvLopHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvLopHoc.AutoGenerateColumns = false;
            this.dtgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.TotalStudent});
            this.dtgvLopHoc.DataSource = this.lopHocVMBindingSource;
            this.dtgvLopHoc.Location = new System.Drawing.Point(0, 28);
            this.dtgvLopHoc.Name = "dtgvLopHoc";
            this.dtgvLopHoc.Size = new System.Drawing.Size(773, 349);
            this.dtgvLopHoc.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên lớp";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // TotalStudent
            // 
            this.TotalStudent.DataPropertyName = "TotalStudent";
            this.TotalStudent.HeaderText = "Sĩ số";
            this.TotalStudent.Name = "TotalStudent";
            // 
            // lopHocVMBindingSource
            // 
            this.lopHocVMBindingSource.DataSource = typeof(EFTutorial.ViewModel.LopHocVM);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnXoa,
            this.btnSua,
            this.btnThêm});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(772, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
           
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(105, 22);
            this.toolStripLabel1.Text = "Danh sách lớp học";
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 22);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThêm
            // 
            this.btnThêm.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThêm.Image = ((System.Drawing.Image)(resources.GetObject("btnThêm.Image")));
            this.btnThêm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThêm.Name = "btnThêm";
            this.btnThêm.Size = new System.Drawing.Size(58, 22);
            this.btnThêm.Text = "Thêm";
            this.btnThêm.Click += new System.EventHandler(this.btnThêm_Click);
            // 
            // lopHocVMBindingSource1
            // 
            this.lopHocVMBindingSource1.DataSource = typeof(EFTutorial.ViewModel.LopHocVM);
            // 
            // lopHocBindingSource
            // 
            this.lopHocBindingSource.DataSource = typeof(EFTutorial.DAL.LopHoc);
            // 
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 376);
            this.Controls.Add(this.dtgvLopHoc);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmLopHoc";
            this.Text = "frmLopHoc";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocVMBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocVMBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLopHoc;
        private System.Windows.Forms.BindingSource lopHocBindingSource;
        private System.Windows.Forms.BindingSource lopHocVMBindingSource1;
        private System.Windows.Forms.BindingSource lopHocVMBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnThêm;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalStudent;
    }
}