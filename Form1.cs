using System;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using CsvHelper.Configuration;
using CsvHelper;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace Teste
{
    public partial class Form1 : Form
    {

        // Variaveis globais
        int T_buffer;
        //int[] array1 = new int[5];
        double[] V_buffer = new double[500];
        double[] Saida = new double[10];
        DataTable dt_raw = new DataTable();
        double max_valor = 0; 
        double min_valor = 0;
        double histerese = 0;

        int Ncompras = 0;
        int Nvendas = 0;
        int Nlinhas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            T_buffer = Convert.ToInt32(txtBuffer.Text);
            dt_raw.Columns.Add("Linha", typeof(Int32));
            dt_raw.Columns.Add("Valor", typeof(double));
            dt_raw.Columns.Add("Media", typeof(double));

        }

        private void Btn_Arq_Click(object sender, EventArgs e)
        {
            //var fileContent = string.Empty;
            var filePath = string.Empty;
            bool ok_ = false;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Filter = "xlsx files (*.csv) | *.csv";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    txtArq.Text = filePath;
                    ok_ = true;
                }
                else
                {
                    txtArq.Text = "Escolher o Arquivo .csv !";
                    ok_ = false;
                }
            }

            if (ok_ == true)
            {
                Le_linha(1);
                Atualiza();
            }

        }
        private void Atualiza()
        {
            //Atualiza valores campos
            T_buffer = Convert.ToInt32(txtBuffer.Text);
            histerese = Convert.ToInt32(txtHiste.Text);
            double d2 = Convert.ToDouble(txtVol.Text);
            double c2 = Convert.ToDouble(txtCotacao.Text);
            double g2 = Convert.ToDouble(txtSaldoBTCini.Text);
            double h2 = g2 * c2;
            double f2 = Convert.ToDouble(txtSaldoUini.Text);
            double i2 = h2 + f2;
            txtBtc_Conv.Text = (c2 * d2).ToString();
            txtBTC_Cota.Text = (h2).ToString();

            txtSaldoSoma.Text = (i2).ToString();
            Saida[4] = f2; // Saldo U$
            Saida[3] = g2;// Saldo BTC
            Ncompras = 0;
            Nvendas = 0;
            Nlinhas = 0;
            dt_raw.Clear();
        }


        private double C_Media(double[] V_buffer_c)
        {
            double soma = 0;

            for (int a = 1; a <= T_buffer; a++)
            {
                soma = soma + V_buffer_c[a];
                //txtMedia.Text = txtMedia.Text + soma + "\n";
            }
            double media = (soma / T_buffer);
            return media;
        }
        private void Calculos(double media_loc, double valor, int n_linha)
        {
            double volume = Convert.ToDouble(txtVol.Text);
            double difer = 0;
            dt_raw.Rows.Add(n_linha, valor, media_loc);// adiciona linha, valor media            

            difer = media_loc - valor;

            if (difer > histerese)
            {
                if (Saida[4] > 100)
                {
                    //Compra xx BTC por cotação atual de U$
                    Saida[4] = Saida[4] - (volume * valor);
                    Saida[3] = Saida[3] + volume;
                    Ncompras++;
                }
                
            }
            if (difer < - histerese)
            {
                if (Saida[3] > 0.001)
                {
                    //Vende xx BTC por cotação atual de U$
                    Saida[4] = Saida[4] + (volume * valor);
                    Saida[3] = Saida[3] - volume;
                    Nvendas++;
                }
                
            }
            // Ultima Cotação
            textBox7.Text = valor.ToString();
            // Ultimo Saldo BTC cotação
            double cota_btc = (Saida[3] * valor);
            textBox2.Text = cota_btc.ToString();

            textBox4.Text = Saida[4].ToString();
            textBox3.Text = Saida[3].ToString();
            textBox8.Text = n_linha.ToString();
            // Atualiza compras e vendas
            txtNCompras.Text = Ncompras.ToString();
            txtNVendas.Text = Nvendas.ToString();
            // Saldo total
            textBox1.Text = (cota_btc + Saida[4]).ToString();
        }
        private void Finaliza()
        {
            // saldosoma + textBox1
            double sf = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(txtSaldoSoma.Text);
            txtSaldoFinal.Text = sf.ToString();
            Nlinhas = Convert.ToInt32(textBox8.Text);
            max_valor = Convert.ToDouble (dt_raw.Compute("MAX([Valor])", ""));
            min_valor = Convert.ToDouble(dt_raw.Compute("MIN([Valor])", ""));
            int transac = Ncompras + Nlinhas;
            double perc_tx = transac * Convert.ToDouble(txt_TX.Text);
            txtTXRe.Text = perc_tx.ToString() + " %";
            double rasc_sf_tx = sf - ((sf * perc_tx)/100);
            txtSaldo_Taxas.Text = rasc_sf_tx.ToString();

            grafico(max_valor, min_valor);
        }


        private void LerArquivo()
        {
            int i = 0; // controle do buffer
            int l = 0; // controle linha

            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false,
                Comment = '#',
                AllowComments = true,
                Delimiter = ";",
            };

            var streamReader = File.OpenText(txtArq.Text);

            var csvReader = new CsvReader(streamReader, csvConfig);


            while (csvReader.Read())
            {
                var v_open = csvReader.GetField(1);
                i++;
                l++;
                txtLinha.Text = l.ToString();
                double valor = Convert.ToDouble(v_open);
                V_buffer[i] = valor;

                if (i >= T_buffer)
                {
                    i = 0;
                }

                Calculos(C_Media(V_buffer), valor, l);

            }
        }

        private void grafico(double max_valor, double min_valor)
        {


            chart1.DataSource = dt_raw;
            chart1.Series[0].XValueMember = "Linha";
            chart1.Series[0].YValueMembers = "Valor";

            chart1.Series[1].XValueMember = "Linha";
            chart1.Series[1].YValueMembers = "Media";
            //
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Color = System.Drawing.Color.DarkBlue;
            //
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].Color = System.Drawing.Color.Red;
            //
            chart1.Series[0].BorderWidth = 1;
            chart1.Series[1].BorderWidth = 1;
            //
            chart1.ChartAreas[0].AxisY.Maximum = max_valor;
            chart1.ChartAreas[0].AxisY.Minimum = min_valor;

            chart1.DataBind();

        }


        private void Le_linha(int l1)
        {

            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false,
                Comment = '#',
                AllowComments = true,
                Delimiter = ";",
            };

            var streamReader = File.OpenText(txtArq.Text);

            var csvReader = new CsvReader(streamReader, csvConfig);
            while (csvReader.Read())
            {
                var v_open = csvReader.GetField(1);
                txtCotacao.Text = v_open.ToString();
                txtLinha.Text = l1.ToString();

                break;

            }


        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Atualiza();
            LerArquivo();
            Finaliza();
        }

        private void txtBuffer_TextChanged(object sender, EventArgs e)
        {
            T_buffer = Convert.ToInt32(txtBuffer.Text);
        }

    }
}