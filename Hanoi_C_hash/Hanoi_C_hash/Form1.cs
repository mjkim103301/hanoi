using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanoi_C_hash
{
    public partial class Form1 : Form
    {
        Hanoi hanoi;
        private Timer timer;
        private int timerCount = 0;
        int number;

        public Form1()
        {
            InitializeComponent();
            hanoi = new Hanoi_C_hash.Hanoi();
            progressBar1.Visible = false;
            label2.Visible = false;
            Show_btn.Visible = false;
            Reset_btn.Visible = false;

        }
       

        public void Check_txt_TextChanged(object sender, EventArgs e)
        {
           
               
        }

        public void label1_Click(object sender, EventArgs e)
        {
          
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
           
            progressBar1.PerformStep();
            ++timerCount;
            움직이는횟수_show.Text = timerCount.ToString();


            // 타이머 중지 조건
            //if (++timerCount == 10)
            //{
            //    timer.Stop();
            //    Show_btn.Show();
            //    Reset_btn.Show();
            //}
            
            if ( hanoi.set_count() == Math.Pow(2, number))
            {                
                timer.Stop();
                Show_btn.Show();
                Reset_btn.Show();
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(Check_txt.Text);
            hanoi.set_number(number);
            label2.Show();
            progressBar1.Show();
         
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void 계산시간_show_Click(object sender, EventArgs e)
        {

        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Reset_btn_Click(object sender, EventArgs e)//초기화시키는거 다시 해야함
        {
            Check_txt.Clear();
            progressBar1.Visible = false;
            label2.Visible = false;
            움직이는횟수_show.Text="0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
