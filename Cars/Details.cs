using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdrianJemiolo09._02
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            int kilometry = int.Parse(textBoxKilometry.Text);
            int spalanie = int.Parse(labelSpalanie.Text);
            Auto auto = new Auto(labelMarka.Text, labelRocznik.Text, labelKolor.Text, double.Parse(labelPrzebieg.Text), int.Parse(labelSpalanie.Text));
            labelWynik.Text = auto.obliczSpalanie(kilometry).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            labelWynik.Text = "";
            textBoxKilometry.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }
    }
}
