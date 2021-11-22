using EFTutorial.BLL;
using EFTutorial.DAL;
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
    public partial class Form1 : Form
    {
        SinhVienVM sinhVienVM;
        public Form1()
        {
            InitializeComponent();
            NapSinhVien();
            GetList();
            AddListStudent();
        }

        void GetList()
        {
            var ls = LopHocBLL.GetList();
            comboBox1.DataSource = ls;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
        }

        public SinhVienVM selectSinhVien
        {
            get{
                return sinhVienBindingSource1.Current as SinhVienVM;
            }
        }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lop = comboBox1.SelectedItem as LopHoc;
            if(lop != null)
            {
                var ls = SinhVienBLL.GetList(lop.ID);
                sinhVienBindingSource1.DataSource = ls;
                dataGridView1.DataSource = sinhVienBindingSource1;

            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            var ls = SinhVienBLL.GetAllList();
            sinhVienBindingSource1.DataSource = ls;
            dataGridView1.DataSource = sinhVienBindingSource1;
        }

        void NapSinhVien()
        {
            var ls = SinhVienBLL.GetAllList();
            sinhVienBindingSource1.DataSource = ls;
            dataGridView1.DataSource = sinhVienBindingSource1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var masv = txbMsv.Text;
            var ten = txbTen.Text;
            var ho = txbHo.Text;
            var ngaysinh = dtbDOB.Value;
            var noisinh = txbPOB.Text;
            var idlop = numIDLop.Value;

            if(string.IsNullOrEmpty(masv) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(ho) || ngaysinh==null
                || string.IsNullOrEmpty(noisinh) || idlop== null)
            {
                MessageBox.Show("Thông tin không được để trống", "Thông báo");
            }
            else if(sinhVienVM == null)
            {
                var ls = SinhVienBLL.Add(new SinhVienVM
                {
                    IDStudent = masv,
                    FirstName = ten,
                    LastName = ho,
                    DOB = ngaysinh,
                    POB = noisinh,
                    IDLop = (long?)idlop
                });
                if(ls == SinhVienBLL.KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                    if(DialogResult == DialogResult.OK)
                    {
                        NapSinhVien();
                    }
                }
                else if(ls == SinhVienBLL.KetQua.MaTrung)
                {
                    MessageBox.Show("Mã sinh viên không được trùng nhau", "Thông báo");
                }
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (selectSinhVien != null)
            {
                if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SinhVienBLL.Delete(selectSinhVien.ID);
                    sinhVienBindingSource1.RemoveCurrent();
                    MessageBox.Show("Đã xóa thành công!");
                }
            }
        }

        void AddListStudent()
        {
            txbMsv.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IDStudent", true, DataSourceUpdateMode.Never));
            txbTen.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "FirstName", true, DataSourceUpdateMode.Never));
            txbHo.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "LastName", true, DataSourceUpdateMode.Never));
            dtbDOB.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DOB", true, DataSourceUpdateMode.Never));
            txbPOB.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "POB", true, DataSourceUpdateMode.Never));
            numIDLop.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IDLop", true, DataSourceUpdateMode.Never ));
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var masv = txbMsv.Text;
            var ten = txbTen.Text;
            var ho = txbHo.Text;
            var ngaysinh = dtbDOB.Value;
            var noisinh = txbPOB.Text;
            var idlop = numIDLop.Value;


            if (string.IsNullOrEmpty(masv) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(ho) || ngaysinh == null
                || string.IsNullOrEmpty(noisinh) || idlop == null)
            {
                MessageBox.Show("Thông tin không được để trống", "Thông báo");
            }
            else if (sinhVienVM == null)
            {
                var ls = SinhVienBLL.Update(new SinhVienVM
                {
                    IDStudent = masv,
                    FirstName = ten,
                    LastName = ho,
                    DOB = ngaysinh,
                    POB = noisinh,
                    IDLop = (long?)idlop
                });
                if (ls == SinhVienBLL.KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                    if (DialogResult == DialogResult.OK)
                    {
                        NapSinhVien();
                    }
                }
                else if (ls == SinhVienBLL.KetQua.MaTrung)
                {
                    MessageBox.Show("Mã sinh viên không được trùng nhau", "Thông báo");
                }
            }
        }
    }
    }
