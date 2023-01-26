using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using XmlWorker;

namespace BestOil
{
    public partial class Form1 : Form
    {
        double gasprice;
        double cafeprice;
        IFile files;
        List<double> total;
        List<Gasoline> gasoline;
        ToolStripMenuItem getReceipt = new ToolStripMenuItem("Получить чек");
        ToolStripMenuItem exit = new ToolStripMenuItem("Выход");
        public Form1()
        {
            InitializeComponent();
            files = new XmlFormat();
            this.Text = "BestOil";
            hPayCafe.Text = "0.0";
            hGasPay.Text="0.0";
            hTotalPay.Text = "0.0";
            total = new List<double>();
            gasprice = default(double);
            cafeprice = default(double);
            gasoline = new List<Gasoline>();
            //LoadGasList();
            contextMenuStrip1.Items.AddRange(new[] { getReceipt, exit });
            this.ContextMenuStrip = contextMenuStrip1;
            exit.Click += exit_Click;
            getReceipt.Click += getReceipt_Click;
            hPrice.Enabled = false;
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = false;
            textBox1.Text = 4.ToString();
            textBox3.Text = 5.40.ToString();
            textBox5.Text = 7.20.ToString();
            textBox7.Text = 4.40.ToString();
            hSum.Enabled = false;
            
        }
       
        private void hGasoline_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gasoline.Count != 0)
            {
                int count = 0;
                foreach (var val in gasoline)
                {
                    if (count == hGasoline.SelectedIndex)
                        hPrice.Text = val.price.ToString();
                    count++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (cbCount.Checked == true)
            {
                if (hGasCount.Text != String.Empty && hPrice.Text != String.Empty)
                    gasprice = double.Parse(hPrice.Text) * double.Parse(hGasCount.Text);
            }
            else if (cbSum.Checked == true)
            {
                if (hSum.Text != String.Empty)
                {
                    gasprice = double.Parse(hSum.Text);
                }
            }

            if (checkBox1.Checked)
            {
                textBox2.Enabled = true;
                if (textBox2.Text != String.Empty)
                {
                    total.Add(double.Parse(textBox1.Text) * double.Parse(textBox2.Text));
                }
            }
            if (checkBox2.Checked)
            {
                textBox4.Enabled = true;
                if (textBox4.Text != String.Empty)
                {
                    total.Add(double.Parse(textBox3.Text) * double.Parse(textBox4.Text));
                }
            }
            if (checkBox3.Checked)
            {
                textBox6.Enabled = true;
                if (textBox6.Text != String.Empty)
                {
                    total.Add(double.Parse(textBox5.Text) * double.Parse(textBox6.Text));
                }
            }
            if (checkBox4.Checked)
            {
                textBox8.Enabled = true;
                if (textBox8.Text != String.Empty)
                {
                    total.Add(double.Parse(textBox7.Text) * double.Parse(textBox8.Text));
                }
            }
            if (total.Count != 0)
            {
                cafeprice = total.Sum();
                total.Clear();
            }
            else cafeprice = 0;
            hGasPay.Text = gasprice.ToString();
            hPayCafe.Text = cafeprice.ToString();
            hTotalPay.Text = (cafeprice + gasprice).ToString();
        }
        private void getReceipt_Click(object sender, EventArgs e)
        {
            if(gasprice!=0)
            {
                MessageBox.Show($"Бензин: {hGasoline.SelectedItem} Сумма: {gasprice}");
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbCount_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCount.Checked == true)
            {
                hSum.Text="";
                hSum.Enabled = false;
                hGasCount.Enabled = true;

            }
            else if (cbSum.Checked == true)
            {
                hGasCount.Text="";
                hSum.Enabled = true;
                hGasCount.Enabled = false;
            }
            if (checkBox1.Checked)
                textBox2.Enabled = true;
            else
            {
                textBox2.Enabled = false;
                textBox2.Text="";
            }
            if (checkBox2.Checked)
                textBox4.Enabled = true;
            else
            {
                textBox4.Enabled = false;
                textBox4.Text="";
            }
            if (checkBox3.Checked)
                textBox6.Enabled = true;
            else
            {
                textBox6.Enabled = false;
                textBox6.Text="";
            }
            if (checkBox4.Checked)
                textBox8.Enabled = true;
            else
            {
                textBox8.Enabled = false;
                textBox8.Text="";
            }
        }

        private void AddGas_Click(object sender, EventArgs e)
        {
            if(textBox9.Text!=String.Empty&&textBox10.Text!=String.Empty)
            {
                Gasoline gas = new Gasoline();
                gas.type = textBox10.Text;
                gas.price = double.Parse(textBox9.Text);
                gasoline.Add(gas);
                files.Save(gasoline, "../../Gasoline.xml");
                hGasoline.Items.Add(gas.type);
            }
        }

        private void AZS_Click(object sender, EventArgs e)
        {
            if (File.Exists("../../Gasoline.xml"))
            {
                gasoline = files.Load<List<Gasoline>>("../../Gasoline.xml");
                foreach (var val in gasoline)
                    hGasoline.Items.Add(val.type);
            }
        }
    }
}
