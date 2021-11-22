using BasicWinformm.Entities;
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
    public partial class frmFire : Form
    {
        SoundManager sound = new SoundManager("D:\\C#\\BasicWinForm\\Sound\\Phaohoa.mp3");
        public frmFire()
        {
            InitializeComponent();
            pbFire.Visible = false;
            pbFire2.Visible = false;
           
            sound.Stop();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            frmYear frmYear = new frmYear();
            frmYear.ShowDialog();
            this.Show();
        }
        int second = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            second = int.Parse(lblFire.Text);
            if (!timer1.Enabled)
            {
            //    this.Opacity = 0.7;
                btnStart.Text = "Stop";
                timer1.Start();
            }
            else
            {
                btnStart.Text = "Start";
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (second == 0)
            {

                pbFire.Visible = true;
                pbFire2.Visible = true;
                sound.Play();
                lblFire.Visible = false;
                btnStart.Text = "Start";
                timer1.Stop();

            }
            else
            {

                second--;
                if (second <= 5)
                {

                    lblFire.ForeColor = Color.Black;
                }

                lblFire.Text = $"{second.ToString("00")}";

            }
        }
    }
}
