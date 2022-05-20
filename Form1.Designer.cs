
namespace Teste
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Btn_Arq = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtHiste = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_TX = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBuffer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArq = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSaldoSoma = new System.Windows.Forms.TextBox();
            this.txtBTC_Cota = new System.Windows.Forms.TextBox();
            this.txtSaldoBTCini = new System.Windows.Forms.TextBox();
            this.txtSaldoUini = new System.Windows.Forms.TextBox();
            this.txtBtc_Conv = new System.Windows.Forms.TextBox();
            this.txtVol = new System.Windows.Forms.TextBox();
            this.txtCotacao = new System.Windows.Forms.TextBox();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTXRe = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSaldo_Taxas = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSaldoFinal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNVendas = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNCompras = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Arq
            // 
            this.Btn_Arq.Location = new System.Drawing.Point(13, 23);
            this.Btn_Arq.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Arq.Name = "Btn_Arq";
            this.Btn_Arq.Size = new System.Drawing.Size(52, 23);
            this.Btn_Arq.TabIndex = 0;
            this.Btn_Arq.Text = "Arquivo";
            this.Btn_Arq.UseVisualStyleBackColor = true;
            this.Btn_Arq.Click += new System.EventHandler(this.Btn_Arq_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtHiste);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txt_TX);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtBuffer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtArq);
            this.groupBox1.Controls.Add(this.Btn_Arq);
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(710, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label25.Location = new System.Drawing.Point(572, 34);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 19);
            this.label25.TabIndex = 11;
            this.label25.Text = "U$";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label24.Location = new System.Drawing.Point(462, 35);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 19);
            this.label24.TabIndex = 10;
            this.label24.Text = "%";
            // 
            // txtHiste
            // 
            this.txtHiste.Location = new System.Drawing.Point(603, 32);
            this.txtHiste.Margin = new System.Windows.Forms.Padding(2);
            this.txtHiste.Name = "txtHiste";
            this.txtHiste.Size = new System.Drawing.Size(36, 22);
            this.txtHiste.TabIndex = 9;
            this.txtHiste.Text = "200";
            this.txtHiste.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(579, 17);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Histerese :";
            // 
            // txt_TX
            // 
            this.txt_TX.Location = new System.Drawing.Point(426, 34);
            this.txt_TX.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TX.Name = "txt_TX";
            this.txt_TX.Size = new System.Drawing.Size(32, 22);
            this.txt_TX.TabIndex = 7;
            this.txt_TX.Text = "0,1";
            this.txt_TX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(423, 17);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "Taxas/Transação :";
            // 
            // txtBuffer
            // 
            this.txtBuffer.Location = new System.Drawing.Point(357, 34);
            this.txtBuffer.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuffer.Name = "txtBuffer";
            this.txtBuffer.Size = new System.Drawing.Size(23, 22);
            this.txtBuffer.TabIndex = 5;
            this.txtBuffer.Text = "50";
            this.txtBuffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBuffer.TextChanged += new System.EventHandler(this.txtBuffer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buffer :";
            // 
            // txtArq
            // 
            this.txtArq.Location = new System.Drawing.Point(69, 18);
            this.txtArq.Margin = new System.Windows.Forms.Padding(2);
            this.txtArq.Name = "txtArq";
            this.txtArq.Size = new System.Drawing.Size(268, 38);
            this.txtArq.TabIndex = 1;
            this.txtArq.Text = "F:\\2022\\Binance\\Get-BTC\\1d_5min.csv";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSaldoSoma);
            this.groupBox2.Controls.Add(this.txtBTC_Cota);
            this.groupBox2.Controls.Add(this.txtSaldoBTCini);
            this.groupBox2.Controls.Add(this.txtSaldoUini);
            this.groupBox2.Controls.Add(this.txtBtc_Conv);
            this.groupBox2.Controls.Add(this.txtVol);
            this.groupBox2.Controls.Add(this.txtCotacao);
            this.groupBox2.Controls.Add(this.txtLinha);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(8, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(709, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parâmetros iniciais :";
            // 
            // txtSaldoSoma
            // 
            this.txtSaldoSoma.BackColor = System.Drawing.Color.Aqua;
            this.txtSaldoSoma.Location = new System.Drawing.Point(585, 34);
            this.txtSaldoSoma.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoSoma.Name = "txtSaldoSoma";
            this.txtSaldoSoma.Size = new System.Drawing.Size(99, 22);
            this.txtSaldoSoma.TabIndex = 25;
            this.txtSaldoSoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBTC_Cota
            // 
            this.txtBTC_Cota.BackColor = System.Drawing.Color.Aqua;
            this.txtBTC_Cota.Location = new System.Drawing.Point(455, 34);
            this.txtBTC_Cota.Margin = new System.Windows.Forms.Padding(2);
            this.txtBTC_Cota.Name = "txtBTC_Cota";
            this.txtBTC_Cota.Size = new System.Drawing.Size(99, 22);
            this.txtBTC_Cota.TabIndex = 24;
            this.txtBTC_Cota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSaldoBTCini
            // 
            this.txtSaldoBTCini.Location = new System.Drawing.Point(386, 34);
            this.txtSaldoBTCini.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoBTCini.Name = "txtSaldoBTCini";
            this.txtSaldoBTCini.Size = new System.Drawing.Size(54, 22);
            this.txtSaldoBTCini.TabIndex = 23;
            this.txtSaldoBTCini.Text = "0,05";
            this.txtSaldoBTCini.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSaldoUini
            // 
            this.txtSaldoUini.Location = new System.Drawing.Point(313, 34);
            this.txtSaldoUini.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoUini.Name = "txtSaldoUini";
            this.txtSaldoUini.Size = new System.Drawing.Size(54, 22);
            this.txtSaldoUini.TabIndex = 22;
            this.txtSaldoUini.Text = "500,00";
            this.txtSaldoUini.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBtc_Conv
            // 
            this.txtBtc_Conv.BackColor = System.Drawing.Color.Aqua;
            this.txtBtc_Conv.Location = new System.Drawing.Point(244, 34);
            this.txtBtc_Conv.Margin = new System.Windows.Forms.Padding(2);
            this.txtBtc_Conv.Name = "txtBtc_Conv";
            this.txtBtc_Conv.Size = new System.Drawing.Size(57, 22);
            this.txtBtc_Conv.TabIndex = 21;
            this.txtBtc_Conv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVol
            // 
            this.txtVol.Location = new System.Drawing.Point(170, 34);
            this.txtVol.Margin = new System.Windows.Forms.Padding(2);
            this.txtVol.Name = "txtVol";
            this.txtVol.Size = new System.Drawing.Size(43, 22);
            this.txtVol.TabIndex = 20;
            this.txtVol.Text = "0,001";
            this.txtVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCotacao
            // 
            this.txtCotacao.Location = new System.Drawing.Point(81, 34);
            this.txtCotacao.Margin = new System.Windows.Forms.Padding(2);
            this.txtCotacao.Name = "txtCotacao";
            this.txtCotacao.Size = new System.Drawing.Size(66, 22);
            this.txtCotacao.TabIndex = 19;
            this.txtCotacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLinha
            // 
            this.txtLinha.Location = new System.Drawing.Point(13, 34);
            this.txtLinha.Margin = new System.Windows.Forms.Padding(2);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(53, 22);
            this.txtLinha.TabIndex = 6;
            this.txtLinha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Linha :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Saldo Soma BTC + U$ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Saldo BTC (cotação) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Saldo BTC :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Saldo U$ :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(141, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "btc volume :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "BTC Conv. U$ :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cot. Inic. :";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(619, 80);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(78, 29);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar Teste";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTXRe);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.txtSaldo_Taxas);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.btnIniciar);
            this.groupBox3.Controls.Add(this.txtSaldoFinal);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtNVendas);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtNCompras);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(9, 153);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(709, 122);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado :";
            // 
            // txtTXRe
            // 
            this.txtTXRe.BackColor = System.Drawing.Color.Aqua;
            this.txtTXRe.Location = new System.Drawing.Point(169, 87);
            this.txtTXRe.Margin = new System.Windows.Forms.Padding(2);
            this.txtTXRe.Name = "txtTXRe";
            this.txtTXRe.Size = new System.Drawing.Size(52, 22);
            this.txtTXRe.TabIndex = 34;
            this.txtTXRe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(164, 68);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 13);
            this.label26.TabIndex = 35;
            this.label26.Text = "Taxas :";
            // 
            // txtSaldo_Taxas
            // 
            this.txtSaldo_Taxas.BackColor = System.Drawing.Color.Aqua;
            this.txtSaldo_Taxas.Location = new System.Drawing.Point(394, 87);
            this.txtSaldo_Taxas.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldo_Taxas.Name = "txtSaldo_Taxas";
            this.txtSaldo_Taxas.Size = new System.Drawing.Size(99, 22);
            this.txtSaldo_Taxas.TabIndex = 33;
            this.txtSaldo_Taxas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(378, 68);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(124, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "Saldo Final - Taxas U$ :";
            // 
            // txtSaldoFinal
            // 
            this.txtSaldoFinal.BackColor = System.Drawing.Color.Aqua;
            this.txtSaldoFinal.Location = new System.Drawing.Point(265, 87);
            this.txtSaldoFinal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoFinal.Name = "txtSaldoFinal";
            this.txtSaldoFinal.Size = new System.Drawing.Size(99, 22);
            this.txtSaldoFinal.TabIndex = 31;
            this.txtSaldoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(249, 68);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "Saldo Final U$ :";
            // 
            // txtNVendas
            // 
            this.txtNVendas.BackColor = System.Drawing.Color.Aqua;
            this.txtNVendas.Location = new System.Drawing.Point(85, 87);
            this.txtNVendas.Margin = new System.Windows.Forms.Padding(2);
            this.txtNVendas.Name = "txtNVendas";
            this.txtNVendas.Size = new System.Drawing.Size(52, 22);
            this.txtNVendas.TabIndex = 28;
            this.txtNVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(80, 68);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Vendas :";
            // 
            // txtNCompras
            // 
            this.txtNCompras.BackColor = System.Drawing.Color.Aqua;
            this.txtNCompras.Location = new System.Drawing.Point(13, 87);
            this.txtNCompras.Margin = new System.Windows.Forms.Padding(2);
            this.txtNCompras.Name = "txtNCompras";
            this.txtNCompras.Size = new System.Drawing.Size(52, 22);
            this.txtNCompras.TabIndex = 26;
            this.txtNCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 68);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Compras :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Aqua;
            this.textBox1.Location = new System.Drawing.Point(584, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Aqua;
            this.textBox2.Location = new System.Drawing.Point(477, 34);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 22);
            this.textBox2.TabIndex = 24;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Aqua;
            this.textBox3.Location = new System.Drawing.Point(404, 34);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 22);
            this.textBox3.TabIndex = 23;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Aqua;
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Location = new System.Drawing.Point(298, 34);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(91, 22);
            this.textBox4.TabIndex = 22;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Aqua;
            this.textBox5.Location = new System.Drawing.Point(229, 34);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(57, 22);
            this.textBox5.TabIndex = 21;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Aqua;
            this.textBox6.Location = new System.Drawing.Point(169, 34);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(44, 22);
            this.textBox6.TabIndex = 20;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Aqua;
            this.textBox7.Location = new System.Drawing.Point(80, 34);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(66, 22);
            this.textBox7.TabIndex = 19;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Aqua;
            this.textBox8.Location = new System.Drawing.Point(13, 34);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(52, 22);
            this.textBox8.TabIndex = 6;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Linha :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Saldo Soma BTC + U$ :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Saldo BTC (cotação) :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(393, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Saldo BTC :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(328, 15);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Saldo U$ :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(140, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "btc volume :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(215, 15);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "BTC Conv. U$ :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(80, 15);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Cot. Final :";
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 3;
            this.chart1.BorderSkin.BorderWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 300);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "BTC";
            series1.SmartLabelStyle.CalloutLineWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Media";
            series2.SmartLabelStyle.CalloutLineWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Compra";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Venda";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(899, 318);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(921, 629);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTC- Config";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Arq;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtArq;
        private System.Windows.Forms.TextBox txtBuffer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaldoSoma;
        private System.Windows.Forms.TextBox txtBTC_Cota;
        private System.Windows.Forms.TextBox txtSaldoBTCini;
        private System.Windows.Forms.TextBox txtSaldoUini;
        private System.Windows.Forms.TextBox txtBtc_Conv;
        private System.Windows.Forms.TextBox txtVol;
        private System.Windows.Forms.TextBox txtCotacao;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNVendas;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNCompras;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSaldoFinal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txt_TX;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtSaldo_Taxas;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtHiste;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtTXRe;
        private System.Windows.Forms.Label label26;
    }
}

