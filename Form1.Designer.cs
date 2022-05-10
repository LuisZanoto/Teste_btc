
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
            this.Btn_Arq = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.Btn_Arq.Location = new System.Drawing.Point(15, 30);
            this.Btn_Arq.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Arq.Name = "Btn_Arq";
            this.Btn_Arq.Size = new System.Drawing.Size(61, 30);
            this.Btn_Arq.TabIndex = 0;
            this.Btn_Arq.Text = "Arquivo";
            this.Btn_Arq.UseVisualStyleBackColor = true;
            this.Btn_Arq.Click += new System.EventHandler(this.Btn_Arq_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuffer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtArq);
            this.groupBox1.Controls.Add(this.Btn_Arq);
            this.groupBox1.Location = new System.Drawing.Point(9, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(702, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração :";
            // 
            // txtBuffer
            // 
            this.txtBuffer.Location = new System.Drawing.Point(664, 35);
            this.txtBuffer.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuffer.Name = "txtBuffer";
            this.txtBuffer.Size = new System.Drawing.Size(26, 25);
            this.txtBuffer.TabIndex = 5;
            this.txtBuffer.Text = "5";
            this.txtBuffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBuffer.TextChanged += new System.EventHandler(this.txtBuffer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qtd Buffer :";
            // 
            // txtArq
            // 
            this.txtArq.Location = new System.Drawing.Point(81, 24);
            this.txtArq.Margin = new System.Windows.Forms.Padding(2);
            this.txtArq.Name = "txtArq";
            this.txtArq.Size = new System.Drawing.Size(495, 48);
            this.txtArq.TabIndex = 1;
            this.txtArq.Text = "";
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
            this.groupBox2.Location = new System.Drawing.Point(9, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(827, 93);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parâmetros iniciais :";
            // 
            // txtSaldoSoma
            // 
            this.txtSaldoSoma.BackColor = System.Drawing.Color.Aqua;
            this.txtSaldoSoma.Location = new System.Drawing.Point(682, 44);
            this.txtSaldoSoma.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoSoma.Name = "txtSaldoSoma";
            this.txtSaldoSoma.Size = new System.Drawing.Size(115, 25);
            this.txtSaldoSoma.TabIndex = 25;
            this.txtSaldoSoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBTC_Cota
            // 
            this.txtBTC_Cota.BackColor = System.Drawing.Color.Aqua;
            this.txtBTC_Cota.Location = new System.Drawing.Point(531, 44);
            this.txtBTC_Cota.Margin = new System.Windows.Forms.Padding(2);
            this.txtBTC_Cota.Name = "txtBTC_Cota";
            this.txtBTC_Cota.Size = new System.Drawing.Size(115, 25);
            this.txtBTC_Cota.TabIndex = 24;
            this.txtBTC_Cota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSaldoBTCini
            // 
            this.txtSaldoBTCini.Location = new System.Drawing.Point(450, 44);
            this.txtSaldoBTCini.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoBTCini.Name = "txtSaldoBTCini";
            this.txtSaldoBTCini.Size = new System.Drawing.Size(62, 25);
            this.txtSaldoBTCini.TabIndex = 23;
            this.txtSaldoBTCini.Text = "0,04";
            this.txtSaldoBTCini.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSaldoUini
            // 
            this.txtSaldoUini.Location = new System.Drawing.Point(365, 44);
            this.txtSaldoUini.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoUini.Name = "txtSaldoUini";
            this.txtSaldoUini.Size = new System.Drawing.Size(62, 25);
            this.txtSaldoUini.TabIndex = 22;
            this.txtSaldoUini.Text = "2000,00";
            this.txtSaldoUini.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBtc_Conv
            // 
            this.txtBtc_Conv.BackColor = System.Drawing.Color.Aqua;
            this.txtBtc_Conv.Location = new System.Drawing.Point(285, 44);
            this.txtBtc_Conv.Margin = new System.Windows.Forms.Padding(2);
            this.txtBtc_Conv.Name = "txtBtc_Conv";
            this.txtBtc_Conv.Size = new System.Drawing.Size(66, 25);
            this.txtBtc_Conv.TabIndex = 21;
            this.txtBtc_Conv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVol
            // 
            this.txtVol.Location = new System.Drawing.Point(198, 44);
            this.txtVol.Margin = new System.Windows.Forms.Padding(2);
            this.txtVol.Name = "txtVol";
            this.txtVol.Size = new System.Drawing.Size(50, 25);
            this.txtVol.TabIndex = 20;
            this.txtVol.Text = "0,001";
            this.txtVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCotacao
            // 
            this.txtCotacao.Location = new System.Drawing.Point(94, 44);
            this.txtCotacao.Margin = new System.Windows.Forms.Padding(2);
            this.txtCotacao.Name = "txtCotacao";
            this.txtCotacao.Size = new System.Drawing.Size(76, 25);
            this.txtCotacao.TabIndex = 19;
            this.txtCotacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLinha
            // 
            this.txtLinha.Location = new System.Drawing.Point(15, 44);
            this.txtLinha.Margin = new System.Windows.Forms.Padding(2);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(61, 25);
            this.txtLinha.TabIndex = 6;
            this.txtLinha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Linha :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Saldo Soma BTC + U$ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Saldo BTC (cotação) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Saldo BTC :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Saldo U$ :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(164, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "btc volume :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "BTC Conv. U$ :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cot. Inic. :";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(715, 35);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(91, 38);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar Teste";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // groupBox3
            // 
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
            this.groupBox3.Location = new System.Drawing.Point(10, 200);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(827, 160);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado :";
            // 
            // txtSaldoFinal
            // 
            this.txtSaldoFinal.BackColor = System.Drawing.Color.Aqua;
            this.txtSaldoFinal.Location = new System.Drawing.Point(197, 114);
            this.txtSaldoFinal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoFinal.Name = "txtSaldoFinal";
            this.txtSaldoFinal.Size = new System.Drawing.Size(115, 25);
            this.txtSaldoFinal.TabIndex = 31;
            this.txtSaldoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(178, 89);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 19);
            this.label20.TabIndex = 30;
            this.label20.Text = "Saldo Final U$ :";
            // 
            // txtNVendas
            // 
            this.txtNVendas.BackColor = System.Drawing.Color.Aqua;
            this.txtNVendas.Location = new System.Drawing.Point(99, 114);
            this.txtNVendas.Margin = new System.Windows.Forms.Padding(2);
            this.txtNVendas.Name = "txtNVendas";
            this.txtNVendas.Size = new System.Drawing.Size(60, 25);
            this.txtNVendas.TabIndex = 28;
            this.txtNVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(93, 89);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 19);
            this.label19.TabIndex = 29;
            this.label19.Text = "Vendas :";
            // 
            // txtNCompras
            // 
            this.txtNCompras.BackColor = System.Drawing.Color.Aqua;
            this.txtNCompras.Location = new System.Drawing.Point(15, 114);
            this.txtNCompras.Margin = new System.Windows.Forms.Padding(2);
            this.txtNCompras.Name = "txtNCompras";
            this.txtNCompras.Size = new System.Drawing.Size(60, 25);
            this.txtNCompras.TabIndex = 26;
            this.txtNCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 89);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 19);
            this.label18.TabIndex = 27;
            this.label18.Text = "Compras :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Aqua;
            this.textBox1.Location = new System.Drawing.Point(681, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 25);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Aqua;
            this.textBox2.Location = new System.Drawing.Point(556, 44);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 25);
            this.textBox2.TabIndex = 24;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Aqua;
            this.textBox3.Location = new System.Drawing.Point(471, 44);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(62, 25);
            this.textBox3.TabIndex = 23;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Aqua;
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Location = new System.Drawing.Point(348, 44);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(106, 25);
            this.textBox4.TabIndex = 22;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Aqua;
            this.textBox5.Location = new System.Drawing.Point(267, 44);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(66, 25);
            this.textBox5.TabIndex = 21;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Aqua;
            this.textBox6.Location = new System.Drawing.Point(197, 44);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(51, 25);
            this.textBox6.TabIndex = 20;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Aqua;
            this.textBox7.Location = new System.Drawing.Point(93, 44);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(76, 25);
            this.textBox7.TabIndex = 19;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Aqua;
            this.textBox8.Location = new System.Drawing.Point(15, 44);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(60, 25);
            this.textBox8.TabIndex = 6;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Linha :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Saldo Soma BTC + U$ :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(537, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Saldo BTC (cotação) :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(458, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "Saldo BTC :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(383, 19);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 19);
            this.label14.TabIndex = 14;
            this.label14.Text = "Saldo U$ :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(163, 19);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 19);
            this.label15.TabIndex = 13;
            this.label15.Text = "btc volume :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(251, 19);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 19);
            this.label16.TabIndex = 12;
            this.label16.Text = "BTC Conv. U$ :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(93, 19);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 19);
            this.label17.TabIndex = 11;
            this.label17.Text = "Cot. Final :";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(46, 381);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(465, 130);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(847, 540);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
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
    }
}

