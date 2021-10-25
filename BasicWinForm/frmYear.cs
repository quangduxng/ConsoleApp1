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
    public partial class frmYear : Form
    {
        SoundManager sound = new SoundManager("C:\\Users\\dung0\\OneDrive\\Máy tính\\Hoc.Net\\ConsoleApp1\\BasicWinForm\\Sound\\HNY.mp3");
        
        public frmYear()
        {
            InitializeComponent();
          //  pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            timer1.Start();
            sound.Stop();
        }

        DateTime dt = new DateTime(2022, 01, 01, 00, 00, 00);
       // DateTime dt = DateTime.Now.AddSeconds(10);
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            TimeSpan timeSpan = dt.Subtract(now);
            label2.Text = $"Hôm nay ngày {now.Day}, tháng {now.Month}, năm {now.Year}";
            label1.Text = $"{timeSpan.Days} : {timeSpan.Hours} : {timeSpan.Minutes} : {timeSpan.Seconds}";    
            if (timeSpan.Seconds <= 0 && timeSpan.Minutes <=0 && timeSpan.Hours <= 0 && timeSpan.TotalSeconds==0) {
                timer1.Stop();
                label1.Visible = false;
                label2.Visible = false;
                //  pictureBox1.Visible = true;
                pictureBox2.Visible = true;

                sound.Play();
            }
     
           // timer1.Start();
        }

     
    }
}
