using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Jogo_Galo
{
    public partial class frmJogo : Form
    {
        int vez = 0;
        bool fim = false;

        string simbolo1 = "X";
        string simbolo2 = "O";

        public frmJogo()
        {
            InitializeComponent();
        }

        private void mudarVez()
        {
            if (textVez.Text == simbolo1 && !fim)
                textVez.Text = simbolo2;
            else
                textVez.Text = simbolo1;

            vez++;

            if (!fim)
                verificar();
            else
                MessageBox.Show("Fim do Jogo!");
        }

        private void verificar()
        {
            // horizontal
            if (label1.Text == label2.Text && label2.Text == label3.Text && label1.Text != "")
            {
                MessageBox.Show("Horizontal!");
                fim = true;
            }
            else if (label4.Text == label5.Text && label5.Text == label6.Text && label4.Text != "")
            {
                MessageBox.Show("Horizontal!");
                fim = true;
            }
            else if (label7.Text == label8.Text && label8.Text == label9.Text && label7.Text != "")
            {
                MessageBox.Show("Horizontal!");
                fim = true;
            }

            // vertical
            if (label1.Text == label4.Text && label4.Text == label7.Text && label1.Text != "")
            {
                MessageBox.Show("Vertical!");
                fim = true;
            }
            else if (label2.Text == label5.Text && label5.Text == label8.Text && label2.Text != "")
            {
                MessageBox.Show("Vertical!");
                fim = true;
            }
            else if (label3.Text == label6.Text && label6.Text == label9.Text && label3.Text != "")
            {
                MessageBox.Show("Vertical!");
                fim = true;
            }

            // diagonal
            if (label1.Text == label5.Text && label5.Text == label9.Text && label1.Text != "")
            {
                MessageBox.Show("Diagonal!");
                fim = true;
            }
            else if (label3.Text == label5.Text && label5.Text == label7.Text && label3.Text != "")
            {
                MessageBox.Show("Diagonal!");
                fim = true;
            }

            if (vez >= 9 && fim != true)
            {
                MessageBox.Show("Empate!");
                fim = true;
            }

            if (fim == true && vez < 9)
            {
                if (vez % 2 == 0)
                {
                    MessageBox.Show("O Jogador 2 GANHOU!");
                }
                else
                {
                    MessageBox.Show("O Jogador 1 GANHOU!");
                }
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.Gainsboro;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Gainsboro;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.Gainsboro;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.White;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.BackColor = Color.Gainsboro;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.White;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.BackColor = Color.Gainsboro;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.White;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.BackColor = Color.Gainsboro;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.White;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.BackColor = Color.Gainsboro;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.White;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.BackColor = Color.Gainsboro;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.White;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.BackColor = Color.Gainsboro;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.BackColor = Color.White;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "" && fim != true)
            {
                if (textVez.Text == simbolo1)
                    label1.ForeColor = Color.Red;
                else
                    label1.ForeColor = Color.Blue;

                label1.Text = textVez.Text;
                mudarVez();
            }     
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "" && fim != true)
            {
                if (textVez.Text == simbolo1)
                    label2.ForeColor = Color.Red;
                else
                    label2.ForeColor = Color.Blue;

                label2.Text = textVez.Text;
                mudarVez();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "" && fim != true)
            {
                if (textVez.Text == simbolo1)
                    label3.ForeColor = Color.Red;
                else
                    label3.ForeColor = Color.Blue;

                label3.Text = textVez.Text;
                mudarVez();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "" && fim != true)
            {
                if (textVez.Text == simbolo1)
                    label4.ForeColor = Color.Red;
                else
                    label4.ForeColor = Color.Blue;

                label4.Text = textVez.Text;
                mudarVez();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (label5.Text == "" && fim != true)
            {
                if (textVez.Text == simbolo1)
                    label5.ForeColor = Color.Red;
                else
                    label5.ForeColor = Color.Blue;

                label5.Text = textVez.Text;
                mudarVez();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == "" && fim != true)
            {
                if (textVez.Text == simbolo1)
                    label6.ForeColor = Color.Red;
                else
                    label6.ForeColor = Color.Blue;

                label6.Text = textVez.Text;
                mudarVez();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (label7.Text == "" && fim != true)
            {
                if (textVez.Text == simbolo1)
                    label7.ForeColor = Color.Red;
                else
                    label7.ForeColor = Color.Blue;

                label7.Text = textVez.Text;
                mudarVez();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (label8.Text == "" && fim != true)
            {
                if (textVez.Text == simbolo1)
                    label8.ForeColor = Color.Red;
                else
                    label8.ForeColor = Color.Blue;

                label8.Text = textVez.Text;
                mudarVez();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (label9.Text == "" && fim != true)
            {
                if (textVez.Text == simbolo1)
                    label9.ForeColor = Color.Red;
                else
                    label9.ForeColor = Color.Blue;

                label9.Text = textVez.Text;
                mudarVez();
            }
        }

        private void pretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void roxoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.OliveDrab;
        }

        private void rosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink;
        }

        private void laranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOrange;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CornflowerBlue;
        }

        private void castanhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Brown;
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("João Patrocínio\nNº: 13\nTurma: 10º P2\n2016-2017\nEscola Secundária da Moita", "Autor",  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            vez = 0;
            fim = false;
            textVez.Text = simbolo1;

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSair_Click(sender, e);
        }

        private void jogador1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caracter = Interaction.InputBox("Digite o simbolo:");
            simbolo1 = caracter;
            btnReset_Click(sender, e);
        }

        private void jogador2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caracter = Interaction.InputBox("Digite o simbolo:");
            simbolo2 = caracter;
            btnReset_Click(sender, e);
        }
    }
}
