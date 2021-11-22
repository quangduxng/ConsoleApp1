using EFTutorial.BLL;
using EFTutorial.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTutorial
{
    public partial class frmLopHoc : Form
    {
        public frmLopHoc()
        {
            InitializeComponent();
            Naplophoc();
        }
        void Naplophoc()
        {
            var ls = LopHocBLL.GetListVM();
            lopHocVMBindingSource.DataSource = ls;
            dtgvLopHoc.DataSource = lopHocVMBindingSource;
        }

        public LopHocVM selectLopHoc
        {
            get {
                return lopHocVMBindingSource.Current as LopHocVM;
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(selectLopHoc!= null)
            {
                if(MessageBox.Show("Bạn có thực sự muốn xóa?","Chú ý",MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
                {
                    LopHocBLL.Delete(selectLopHoc.ID);
                    lopHocVMBindingSource.RemoveCurrent();
                    MessageBox.Show("Đã xóa thành công!");
                }
            }
        }

        private void btnThêm_Click(object sender, EventArgs e)
        {
            frmLopChiTiet add = new frmLopChiTiet();
            var rs = add.ShowDialog();
            if(rs == DialogResult.OK)
            {
                Naplophoc();
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectLopHoc != null)
            {
                frmLopChiTiet update = new frmLopChiTiet(selectLopHoc);
                var rs = update.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    Naplophoc();
                }
            }
        }
    }
}
