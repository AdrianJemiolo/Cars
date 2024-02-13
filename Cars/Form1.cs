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

namespace AdrianJemiolo09._02
{
    public partial class Form1 : Form
    {
        List<Auto> samochody = new List<Auto>();
        Details details = new Details();
        public Form1()
        {
            InitializeComponent();
        }
        private void Plik(Auto auto)
        {
            StreamWriter wr;
            wr = File.AppendText("samochody.txt");
            wr.WriteLine(auto.Info());
            wr.Close();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string marka = textBoxMarka.Text;
            string rocznik = textBoxRocznik.Text;
            string kolor = textBoxKolor.Text;
            double przebieg = double.Parse(textBoxPrzebieg.Text);
            int spalanie = int.Parse(textBoxSpalanie.Text);
            Auto auto = new Auto(marka,rocznik,kolor,przebieg,spalanie);
            listBox1.Items.Add(auto.Info());
            samochody.Add(auto);
            Plik(auto);

            
            
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            details.labelMarka.Text = samochody[listBox1.SelectedIndex].marka;
            details.labelRocznik.Text = samochody[listBox1.SelectedIndex].rokProdukcji;
            details.labelKolor.Text = samochody[listBox1.SelectedIndex].kolor;
            details.labelPrzebieg.Text = samochody[listBox1.SelectedIndex].przebieg.ToString();
            details.labelSpalanie.Text = samochody[listBox1.SelectedIndex].spalanie.ToString();
        }

        private void textBoxSpalanie_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            details.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
