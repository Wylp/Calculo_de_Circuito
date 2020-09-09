using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP05_192149
{
    public partial class Form1 : Form
    {

        #region Variaveis Globais
        int cAnim, erroVerif;
        double amp, c1, freq, var;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region Load
        private void Form1_Load(object sender, EventArgs e)
        {
            Txt_C1.Enabled = false;
            Txt_Freq.Enabled = false;
            Txt_Var.Enabled = false;
            Btn_Calcular.Enabled = false;
            Btn_Limpar.Enabled = false;
        }
        #endregion
        #region Close
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Gostaria de Sair?","Encerrando o Aplicativo",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No) {
                e.Cancel = true;
            }
        }
        #endregion
        #region Data e Hora
        private void Tmr_Date_Tick(object sender, EventArgs e)
        {
            Lbl_Date.Text = DateTime.Now.ToString();
        }
        #endregion
        #region Animation
        private void Tmr_Anim_Tick(object sender, EventArgs e)
        {
            cAnim = cAnim % 9 + 1;
            Pbx_Anim.Image = Image.FromFile(Directory.GetCurrentDirectory() +
                "\\res0" + Convert.ToString(cAnim) + ".png");

        }
        #endregion
        #region KeyVerif
        private void KeyVerif(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 44 || e.KeyChar == 45 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion
        #region Liberação de Campo
        private void Tmr_Verificador_Tick(object sender, EventArgs e)
        {
            liberation();
        }

        private void liberation() {
            #region Txt_Amp
            if (Txt_Amp.TextLength != 0)
            {
                Txt_C1.Enabled = true;
            }
            else {
                Txt_C1.Enabled = false;
            }
            #endregion
            #region Txt_C1
            if (Txt_C1.TextLength > 0)
            {
                Txt_Freq.Enabled = true;
            }
            else {
                Txt_Freq.Enabled = false;
            }
            #endregion
            #region Freq
            if (Txt_Freq.TextLength > 0) {
                Txt_Var.Enabled = true;
            }
            else
            {
                Txt_Var.Enabled = false;
            }
            #endregion
            #region Var
            if (Txt_Var.TextLength > 0) {
                Btn_Calcular.Enabled = true;
                Btn_Limpar.Enabled = true;
            }
            else
            {
                Btn_Calcular.Enabled = false;
                Btn_Limpar.Enabled = false;
            }
            #endregion
        }

        #endregion
        #region Limpar
        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("Deseja Limpar?", "Limpar Dados",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                Txt_Amp.Clear();
                Txt_C1.Clear();
                Txt_Freq.Clear();
                Txt_Var.Clear();
                Lbx_C2.Items.Clear();
                Lbx_R1.Items.Clear();
                Lbx_R2.Items.Clear();
                Lbx_R3.Items.Clear();
            }
        }
        #endregion
        #region Tratamento de Erros
        private void errorVerif(object sender, CancelEventArgs e) {
            switch (erroVerif) {
                case 1:
                    MessageBox.Show("Amplificação do Circuito Errada", "Erro");
                    Txt_Amp.Clear();
                    Txt_Amp.Focus();
                    break;
                case 2:
                    MessageBox.Show("Capacitor Errado", "Erro");
                    Txt_C1.Clear();
                    Txt_C1.Focus();
                    break;
                case 3:
                    MessageBox.Show("Frequência Errada", "Erro");
                    Txt_Freq.Clear();
                    Txt_Freq.Focus();
                    break;
                case 4:
                    MessageBox.Show("Variação Invalida", "Erro");
                    Txt_Var.Clear();
                    Txt_Var.Focus();
                    break;
            }
        }

        #endregion
        #region Verificando Amplificação do Circuito
        private void Txt_Amp_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_Amp.Text != "")
            {
                try
                {
                    erroVerif = 1;
                    amp = Convert.ToDouble(Txt_Amp.Text);
                    if (amp <= 0)
                    {
                        errorVerif(sender, e);
                    }

                }
                catch
                {
                    errorVerif(sender, e);
                }
            }
        }
        #endregion
        #region Verificando C1
        private void Txt_C1_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_C1.Text != "")
            {
                try
                {
                    erroVerif = 2;
                    c1 = Convert.ToDouble(Txt_C1.Text);
                    if (c1 <= 0)
                    {
                        errorVerif(sender, e);
                    }

                }
                catch
                {
                    errorVerif(sender, e);
                }
            }
        }
        #endregion
        #region Verificando Frequencia
        private void Txt_Freq_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_Freq.Text != "")
            {
                try
                {
                    erroVerif = 3;
                    freq = Convert.ToDouble(Txt_Freq.Text);
                    if (freq <= 0)
                    {
                        errorVerif(sender, e);
                    }

                }
                catch
                {
                    errorVerif(sender, e);
                }
            }
        }
        #endregion
        #region Verificando Variação
        private void Txt_Var_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_Var.Text != "")
            {
                try
                {
                    erroVerif = 4;
                    var = Convert.ToDouble(Txt_Var.Text);
                    if (var <= 0)
                    {
                        errorVerif(sender, e);
                    }

                }
                catch
                {
                    errorVerif(sender, e);
                }
            }
        }
        #endregion
        #region Calcular
        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            double r1, r2, r3, c2;
            try {
                for (int i = 0; i < 5; i++)
                {
                    #region R1
                    r1 = (Math.Sqrt(2)) / (2 * amp * 2 * Math.PI * c1);
                    Lbx_R1.Items.Add(r1.ToString("#00.000000000"));
                    #endregion
                    #region R2
                    r2 = amp * r1;
                    Lbx_R2.Items.Add(r2.ToString("#00.000000000"));
                    #endregion
                    #region R3
                    r3 = r2 / (amp + 1);
                    Lbx_R3.Items.Add(r3.ToString("#00.000000000"));
                    #endregion
                    #region C2
                    c2 = (2 *(amp + 1)) * c1;
                    Lbx_C2.Items.Add(c2.ToString("#00.00"));
                    #endregion

                    amp += var;
                }
            }
            catch {
                MessageBox.Show("Erro no Calculo", "Erro");
            }
            
        }
        #endregion

    }
}
