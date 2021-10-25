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
    public partial class FrmTimer : Form
    {
        public FrmTimer()
        {
            InitializeComponent();
        }

        private void FrmTimer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(totalSecond == 0)
            
                timer1.Stop();
            else
            {
                totalSecond--;
                lbltimer.Text = totalSecond.ToString();
              //  mm:ss    lbltimer.Text = string.Format("{0:0#}:{1:0#}", totalSecond / 60, totalSecond % 60);
            }
            
        }
        // gồm 2 định dạng dau vao: theo s, theo m
        int totalSecond = 0;
        private void button1_Click(object sender, EventArgs e)
        {
          //  mm:ss var minute = (int)nmTimer.Value;
           //mm:ss  totalSecond = minute * 60;
            totalSecond = (int)nmTimer.Value;
            timer1.Start();
        }
    }
}
