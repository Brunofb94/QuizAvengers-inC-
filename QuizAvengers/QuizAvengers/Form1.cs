using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizAvengers
{
    public partial class Frmtelainicial : Form
    {
        public Frmtelainicial()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 openform2 = new Form2();
            openform2.Show();
            this.Hide();
            //pictureBox1.Visible = true;
           // Frmquiz frm = new Frmquiz();
           // frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            



        }
    }
}
