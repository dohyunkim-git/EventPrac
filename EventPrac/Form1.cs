using System;
using System.Windows.Forms;

namespace EventPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ///xml주석 <<xml형식으로 문법을 만들어서 넣어주기ㅋㅋ
        /// <summary>
        /// button1 클릭 이벤트에 대한 이벤트 핸들러입니다
        /// </summary>
        /// <param name="sender">이벤트가 발생한 컨트롤입니다.</param>
        /// <param name="e">이벤트에 대한 부가 정보를 가지고 있습니다</param>

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "button1":
                    break;
                case "button2":
                    break;
            }
            
            btn.Text = "선택됨!";
            btn.Enabled = false;
            
        }
        private void button1_Click2(object sender, EventArgs e)
        {
            textBox1.Text += "★";
            label1.Text = label1.Text + "★";

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Mouse X : " + e.X + " / Y : " + e.Y;
        }

        private int elapsedTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            textBox1.Text = ""+elapsedTime;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            elapsedTime = 0;
            textBox1.Text = "";
        }
    }
}
