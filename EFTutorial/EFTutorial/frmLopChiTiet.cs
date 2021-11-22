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
    public partial class frmLopChiTiet : Form
    {
        LopHocVM lophocVM;
        public frmLopChiTiet(LopHocVM lophocVM = null)
        {
            InitializeComponent();
            this.lophocVM = lophocVM;
            if(lophocVM == null)
            {
                this.Text = "Thêm mới lớp học";
            }
            else{
                this.Text = "Cập nhật dữ liệu";
                txbTenLop.Text = lophocVM.Name;
            }
        }

       

        private void btnDongY_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var tenlop = txbTenLop.Text;
            if(string.IsNullOrEmpty(tenlop))
            {
                errorProvider1.SetError(txbTenLop, "Lớp học không được để trống");
                return;
            }
            if (lophocVM == null)
            {
                //Thêm mới dữ liệu
                var rs = LopHocBLL.Add(new LopHocVM { Name = tenlop });
                if (rs == LopHocBLL.KETQUA.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                    if(rs == LopHocBLL.KETQUA.TenTrung)
                {
                    MessageBox.Show("Tên lớp không được trùng nhau", "Thông báo");
                }
            }
            else {
                //Cập nhật dữ liệu
                lophocVM.Name = tenlop;
                var rs = LopHocBLL.Update(lophocVM);
                if (rs == LopHocBLL.KETQUA.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                   if (rs == LopHocBLL.KETQUA.TenTrung)
                {
                    MessageBox.Show("Tên lớp không được trùng nhau", "Thông báo");
                }
            }
        }
    }
}
