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
    public partial class Frmquiz : Form
    {
        public Frmquiz()
        {
            InitializeComponent();
           
          
        }
        int acertos = 0;
        int erros;

        private void rdbthor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbthor.Checked == true)
            {
                erros -= 1;
            }
        }

        private void rdbviuva_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbviuva.Checked == true)
            {
                erros -= 1;
            }
        }

        private void rdbiroman_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbiroman.Checked == true)
            {
                erros = 0;
                
            }
        }

        private void rdbpanther_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbpanther.Checked == true)
            {
               acertos += 1;
                
                
            }
        }

        private void rdbviuva_Click(object sender, EventArgs e)
        {

        }

        private void rdbviuva_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbviuva.Checked == true)
            {
                rdbpanther.Enabled = false;
                rdbiroman.Enabled = false;
                rdbthor.Enabled = false;
                pictureBox4.Visible = false;
                groupBox2.Visible = true;
            }

        }

        private void rdbthor_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbthor.Checked == true)
            {
                rdbpanther.Enabled = false;
                rdbiroman.Enabled = false;
                rdbviuva.Enabled = false;
                pictureBox4.Visible = false;
                groupBox2.Visible = true;
            }
        }

        private void rdbpanther_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbpanther.Checked == true)
            {
                rdbthor.Enabled = false;
                rdbiroman.Enabled = false;
                rdbviuva.Enabled = false;
                pictureBox4.Visible = false;
                groupBox2.Visible = true;
            }
        }

        private void rdbiroman_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbiroman.Checked == true)
            {
                rdbpanther.Enabled = false;
                rdbthor.Enabled = false;
                rdbviuva.Enabled = false;
                pictureBox4.Visible = false;
                groupBox2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void rdbjoiaalma_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbjoiaalma.Checked ==true)
            {
                rdbjoiamente.Enabled = false;
                rdbjoiapoder.Enabled = false;
                rdbjoiatempo.Enabled = false;
                pictureBox5.Visible = false;
                groupBox3.Visible = true;
            }
        }

        private void rdbjoiaalma_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbjoiaalma.Checked == true)
            {
                erros = 0;
                
            }
        }

        private void rdbjoiamente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbjoiamente.Checked == true)
            {
                acertos += 1;
            }
        }

        private void rdbjoiatempo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbjoiatempo.Checked == true)
            {
                erros = 0;

            }
        }

        private void rdbjoiapoder_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbjoiapoder.Checked == true)
            {
                erros = 0;

            }
        }

        private void rdbjoiatempo_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbjoiatempo.Checked == true)
            {
                rdbjoiamente.Enabled = false;
                rdbjoiapoder.Enabled = false;
                rdbjoiaalma.Enabled = false;
                pictureBox5.Visible = false;
                groupBox3.Visible = true;
            }
        }

        private void rdbjoiamente_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbjoiamente.Checked == true)
            {
                rdbjoiaalma.Enabled = false;
                rdbjoiapoder.Enabled = false;
                rdbjoiatempo.Enabled = false;
                pictureBox5.Visible = false;
                groupBox3.Visible = true;
            }
        }

        private void rdbjoiapoder_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbjoiapoder.Checked == true)
            {
                rdbjoiamente.Enabled = false;
                rdbjoiaalma.Enabled = false;
                rdbjoiatempo.Enabled = false;
                pictureBox5.Visible = false;
                groupBox3.Visible = true;
            }
        }

        private void rdbshield_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbshield.Checked == true)
            {
                rdbhydra.Enabled = false;
                rdbcmarvel.Enabled = false;
                rdbdrhank.Enabled = false;
                pictureBox6.Visible = false;
                groupBox4.Visible = true;

                erros = 0;

                
            }
        }

        private void rdbhydra_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbhydra.Checked == true)
            {
                rdbdrhank.Enabled = false;
                rdbcmarvel.Enabled = false;
                rdbshield.Enabled = false;
                pictureBox6.Visible = false;
                groupBox4.Visible = true;
                erros = 0;


            }
        }

        private void rdbcmarvel_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbcmarvel.Checked == true)
            {
                rdbdrhank.Enabled = false;
                rdbhydra.Enabled = false;
                rdbshield.Enabled = false;
                groupBox4.Visible = true;
                pictureBox6.Visible = false;
                acertos += 1;


            }
        }

        private void rdbdrhank_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbdrhank.Checked == true)
            {
                rdbhydra.Enabled = false;
                rdbcmarvel.Enabled = false;
                rdbshield.Enabled = false;
                groupBox4.Visible = true;
                pictureBox6.Visible = false;
                erros = 0;


            }
        }

        private void rdbchildren_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbchildren_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbchildren.Checked == true)
            {
                rdbnebulosa.Enabled = false;
                rdbavengers.Enabled = false;
                rdbdeath.Enabled = false;
                groupBox5.Visible = true;
                pictureBox7.Visible = false;
                acertos += 1;
            }
        }

        private void rdbnebulosa_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbnebulosa.Checked == true)
            {
                rdbchildren.Enabled = false;
                rdbavengers.Enabled = false;
                rdbdeath.Enabled = false;
                groupBox5.Visible = true;
                pictureBox7.Visible = false;
                erros = 0;

            }
        }

        private void rdbdeath_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbdeath.Checked == true)
            {
                rdbnebulosa.Enabled = false;
                rdbavengers.Enabled = false;
                rdbchildren.Enabled = false;
                groupBox5.Visible = true;
                pictureBox7.Visible = false;
                erros = 0;
            }
        }

        private void rdbavengers_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbavengers.Checked == true)
            {
                rdbnebulosa.Enabled = false;
                rdbdeath.Enabled = false;
                rdbchildren.Enabled = false;
                groupBox5.Visible = true;
                pictureBox7.Visible = false;
                erros = 0;
            }
        }

        private void rdb11_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdb11.Checked == true)
            {
                rdb110.Enabled = false;
                rdb114.Enabled = false;
                rdb122.Enabled = false;
                groupBox6.Visible = true;
                pictureBox8.Visible = false;
                erros = 0;
            }
        }

        private void rdb114_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdb114.Checked == true)
            {
                rdb110.Enabled = false;
                rdb11.Enabled = false;
                rdb122.Enabled = false;
                groupBox6.Visible = true;
                pictureBox8.Visible = false;
                acertos += 1;
            }
        }

        private void rdb110_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdb110.Checked == true)
            {
                rdb11.Enabled = false;
                rdb114.Enabled = false;
                rdb122.Enabled = false;
                groupBox6.Visible = true;
                pictureBox8.Visible = false;
                erros = 0;
            }
        }

        private void rdb122_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdb122.Checked == true)
            {
                rdb110.Enabled = false;
                rdb114.Enabled = false;
                rdb11.Enabled = false;
                groupBox6.Visible = true;
                pictureBox8.Visible = false;
                erros = 0;
            }
        }

        private void rdblugarnenhum_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdblugarnenhum.Checked == true)
            {
                rdbvormir.Enabled = false;
                rdbasgard.Enabled = false;
                rdbniva.Enabled = false;
                groupBox7.Visible = true;
                pictureBox9.Visible = false;
                erros = 0;
            }
        }

        private void rdbvormir_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbvormir.Checked == true)
            {
                rdblugarnenhum.Enabled = false;
                rdbasgard.Enabled = false;
                rdbniva.Enabled = false;
                groupBox7.Visible = true;
                pictureBox9.Visible = false;
                erros = 0;
            }
        }

        private void rdbasgard_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbasgard.Checked == true)
            {
                rdbvormir.Enabled = false;
                rdblugarnenhum.Enabled = false;
                rdbniva.Enabled = false;
                groupBox7.Visible = true;
                pictureBox9.Visible = false;
                erros = 0;
            }
        }

        private void rdbniva_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbniva.Checked == true)
            {
                rdbvormir.Enabled = false;
                rdbasgard.Enabled = false;
                rdblugarnenhum.Enabled = false;
                groupBox7.Visible = true;
                pictureBox9.Visible = false;
                acertos += 1;
            }
        }

        private void rdbiloki_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbiloki.Checked == true)
            {
                rdbithanos.Enabled = false;
                rdbultro.Enabled = false;
                rdbcivilwar.Enabled = false;
                pictureBox10.Visible = false;
                groupBox8.Visible = true;
                acertos += 1;
            }
        }

        private void rdbultro_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbultro.Checked == true)
            {
                rdbithanos.Enabled = false;
                rdbiloki.Enabled = false;
                rdbcivilwar.Enabled = false;
                pictureBox10.Visible = false;
                groupBox8.Visible = true;
                erros = 0;
            }
        }

        private void rdbcivilwar_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbcivilwar.Checked == true)
            {
                rdbithanos.Enabled = false;
                rdbiloki.Enabled = false;
                rdbultro.Enabled = false;
                pictureBox10.Visible = false;
                groupBox8.Visible = true;
                erros = 0;
            }
        }

        private void rdbithanos_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbithanos.Checked == true)
            {
                rdbultro.Enabled = false;
                rdbiloki.Enabled = false;
                rdbcivilwar.Enabled = false;
                pictureBox10.Visible = false;
                groupBox8.Visible = true;
                erros = 0;
            }
        }

        private void rdbantman_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbantman.Checked == true)
            {
                rdbspider.Enabled = false;
                rdbdrstrange.Enabled = false;
                rdbhulk.Enabled = false;
                groupBox9.Visible = true;
                pictureBox11.Visible = false;
                acertos += 1;

            }
        }

        private void rdbspider_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbspider.Checked == true)
            {
                rdbantman.Enabled = false;
                rdbdrstrange.Enabled = false;
                rdbhulk.Enabled = false;
                groupBox9.Visible = true;
                pictureBox11.Visible = false;
                erros = 0;

            }
        }

        private void rdbdrstrange_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbdrstrange.Checked == true)
            {
                rdbantman.Enabled = false;
                rdbspider.Enabled = false;
                rdbhulk.Enabled = false;
                groupBox9.Visible = true;
                pictureBox11.Visible = false;
                erros = 0;

            }
        }

        private void rdbhulk_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbhulk.Checked == true)
            {
                rdbantman.Enabled = false;
                rdbdrstrange.Enabled = false;
                rdbdrstrange.Enabled = false;
                groupBox9.Visible = true;
                pictureBox11.Visible = false;
                erros = 0;

            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                groupBox10.Visible = true;
                pictureBox12.Visible = false;
                acertos += 1;

            }
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                groupBox10.Visible = true;
                pictureBox12.Visible = false;
                erros = 0;

            }
        }

        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton4.Enabled = false;
                groupBox10.Visible = true;
                pictureBox12.Visible = false;
                erros = 0;

            }
        }

        private void radioButton4_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                radioButton2.Enabled = false;
                radioButton1.Enabled = false;
                radioButton3.Enabled = false;
                groupBox10.Visible = true;
                pictureBox12.Visible = false;
                erros = 0;
            }
        }

        private void radioButton5_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                radioButton6.Enabled = false;
                radioButton7.Enabled = false;
                radioButton8.Enabled = false;
                pictureBox13.Visible = true;
                erros = 0;
            }
        }

        private void radioButton6_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                radioButton5.Enabled = false;
                radioButton7.Enabled = false;
                radioButton8.Enabled = false;
                pictureBox13.Visible = true;
                acertos += 1;
            }
        }

        private void radioButton7_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                radioButton6.Enabled = false;
                radioButton5.Enabled = false;
                radioButton8.Enabled = false;
                pictureBox13.Visible = true;
                erros = 0;
            }
        }

        private void radioButton8_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                radioButton6.Enabled = false;
                radioButton5.Enabled = false;
                radioButton7.Enabled = false;
                pictureBox13.Visible = true;
                erros = 0;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se vira !!!");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja abandonar o Quiz ?", "Avengeres", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (acertos > 6)
            {
                MessageBox.Show("Você acertou:  " + acertos + "  Você está preparado para assistir vingadores ultimato, 'you are in end game now'", "Quiz Avengers",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Você só acertou " + acertos + " Assista vingadores guerra infinita, Guerra civil e avengers age of ultron e entenda a history", "Quiz Avengers",MessageBoxButtons.OK);
                                               
            }
            
        }
    }
}
