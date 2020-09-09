namespace TP05_192149
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Var = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Amp = new System.Windows.Forms.TextBox();
            this.Txt_Freq = new System.Windows.Forms.TextBox();
            this.Txt_C1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tmr_Anim = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Lbx_C2 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbx_R3 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Lbx_R2 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbx_R1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.Pbx_Anim = new System.Windows.Forms.PictureBox();
            this.Tmr_Date = new System.Windows.Forms.Timer(this.components);
            this.Tmr_Verificador = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Anim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_Var);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Txt_Amp);
            this.groupBox1.Controls.Add(this.Txt_Freq);
            this.groupBox1.Controls.Add(this.Txt_C1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(350, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // Txt_Var
            // 
            this.Txt_Var.Location = new System.Drawing.Point(182, 160);
            this.Txt_Var.Name = "Txt_Var";
            this.Txt_Var.Size = new System.Drawing.Size(110, 22);
            this.Txt_Var.TabIndex = 9;
            this.Txt_Var.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyVerif);
            this.Txt_Var.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Var_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Variação:  ";
            // 
            // Txt_Amp
            // 
            this.Txt_Amp.Location = new System.Drawing.Point(182, 42);
            this.Txt_Amp.Name = "Txt_Amp";
            this.Txt_Amp.Size = new System.Drawing.Size(110, 22);
            this.Txt_Amp.TabIndex = 7;
            this.Txt_Amp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyVerif);
            this.Txt_Amp.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Amp_Validating);
            // 
            // Txt_Freq
            // 
            this.Txt_Freq.Location = new System.Drawing.Point(182, 119);
            this.Txt_Freq.Name = "Txt_Freq";
            this.Txt_Freq.Size = new System.Drawing.Size(110, 22);
            this.Txt_Freq.TabIndex = 6;
            this.Txt_Freq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyVerif);
            this.Txt_Freq.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Freq_Validating);
            // 
            // Txt_C1
            // 
            this.Txt_C1.Location = new System.Drawing.Point(182, 80);
            this.Txt_C1.Name = "Txt_C1";
            this.Txt_C1.Size = new System.Drawing.Size(110, 22);
            this.Txt_C1.TabIndex = 5;
            this.Txt_C1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyVerif);
            this.Txt_C1.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_C1_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Frequência: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "µF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacitor (C1) : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amplificação do circuito: ";
            // 
            // Tmr_Anim
            // 
            this.Tmr_Anim.Enabled = true;
            this.Tmr_Anim.Interval = 300;
            this.Tmr_Anim.Tick += new System.EventHandler(this.Tmr_Anim_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Lbx_C2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Lbx_R3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Lbx_R2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Lbx_R1);
            this.groupBox2.Location = new System.Drawing.Point(370, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 139);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "C2";
            // 
            // Lbx_C2
            // 
            this.Lbx_C2.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbx_C2.FormattingEnabled = true;
            this.Lbx_C2.Location = new System.Drawing.Point(328, 39);
            this.Lbx_C2.Name = "Lbx_C2";
            this.Lbx_C2.Size = new System.Drawing.Size(96, 82);
            this.Lbx_C2.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "R3";
            // 
            // Lbx_R3
            // 
            this.Lbx_R3.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbx_R3.FormattingEnabled = true;
            this.Lbx_R3.Location = new System.Drawing.Point(226, 39);
            this.Lbx_R3.Name = "Lbx_R3";
            this.Lbx_R3.Size = new System.Drawing.Size(96, 82);
            this.Lbx_R3.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "R2";
            // 
            // Lbx_R2
            // 
            this.Lbx_R2.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbx_R2.FormattingEnabled = true;
            this.Lbx_R2.Location = new System.Drawing.Point(123, 39);
            this.Lbx_R2.Name = "Lbx_R2";
            this.Lbx_R2.Size = new System.Drawing.Size(96, 82);
            this.Lbx_R2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "R1";
            // 
            // Lbx_R1
            // 
            this.Lbx_R1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbx_R1.FormattingEnabled = true;
            this.Lbx_R1.Location = new System.Drawing.Point(21, 39);
            this.Lbx_R1.Name = "Lbx_R1";
            this.Lbx_R1.Size = new System.Drawing.Size(96, 82);
            this.Lbx_R1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Lbl_Date);
            this.groupBox3.Location = new System.Drawing.Point(370, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 61);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data e Hora";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Location = new System.Drawing.Point(150, 28);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(79, 16);
            this.Lbl_Date.TabIndex = 0;
            this.Lbl_Date.Text = "Data e Hora";
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Image = global::TP05_192149.Properties.Resources.limpar_limpo;
            this.Btn_Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpar.Location = new System.Drawing.Point(662, 337);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(166, 71);
            this.Btn_Limpar.TabIndex = 5;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Image = global::TP05_192149.Properties.Resources.calculadora;
            this.Btn_Calcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Calcular.Location = new System.Drawing.Point(662, 260);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(166, 71);
            this.Btn_Calcular.TabIndex = 4;
            this.Btn_Calcular.Text = "Calcular";
            this.Btn_Calcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // Pbx_Anim
            // 
            this.Pbx_Anim.Image = global::TP05_192149.Properties.Resources.res01;
            this.Pbx_Anim.Location = new System.Drawing.Point(13, 236);
            this.Pbx_Anim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Pbx_Anim.Name = "Pbx_Anim";
            this.Pbx_Anim.Size = new System.Drawing.Size(642, 192);
            this.Pbx_Anim.TabIndex = 0;
            this.Pbx_Anim.TabStop = false;
            // 
            // Tmr_Date
            // 
            this.Tmr_Date.Enabled = true;
            this.Tmr_Date.Interval = 500;
            this.Tmr_Date.Tick += new System.EventHandler(this.Tmr_Date_Tick);
            // 
            // Tmr_Verificador
            // 
            this.Tmr_Verificador.Enabled = true;
            this.Tmr_Verificador.Interval = 200;
            this.Tmr_Verificador.Tick += new System.EventHandler(this.Tmr_Verificador_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(847, 440);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Calcular);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pbx_Anim);
            this.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Calculo do Circuito";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Anim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pbx_Anim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_Var;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Amp;
        private System.Windows.Forms.TextBox Txt_Freq;
        private System.Windows.Forms.TextBox Txt_C1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Tmr_Anim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox Lbx_C2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox Lbx_R3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox Lbx_R2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Lbx_R1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.Button Btn_Calcular;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Timer Tmr_Date;
        private System.Windows.Forms.Timer Tmr_Verificador;
    }
}

