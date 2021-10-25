using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWinForm
{
    public partial class frmToan : Form
    {
        public frmToan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Xin Chao cac ban", "Hello.....");
            try
            {
                var soThuNhat = txtSoThuNhat.Text;

               
                double temp = 0, nSoThuNhat = 0, nSoThuHai = 0;
                if (double.TryParse(soThuNhat, out temp))
                    nSoThuNhat = Convert.ToDouble(soThuNhat);
                   else
                    catch (FormatException ex)
                  {
                MessageBox.Show($"Lỗi định dạng ở Số Thứ Nhất rồi bạn ơi",
                   "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
                   }
             
                       
         
             var soThuHai = txtSoThuHai.Text;
              if (double.TryParse(soThuHai, out temp))
                    nSoThuHai = Convert.ToDouble(soThuHai);
                  
                  




                var ketQua = nSoThuNhat + nSoThuHai;
                lblKetQua.Text = ketQua.ToString("N0");

                    }
           
            catch(OverflowException ex){
                MessageBox.Show($"Lỗi tràn số rồi bạn ơi",
                   "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch ( Exception ex)
            {
                MessageBox.Show($"Lỗi rồi bạn ơi, Chi tiết lỗi :{ex.Message}",
                    "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
