using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Perkalian(int a, int b)
        {
            return a * b;
        }
        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (txtNilaiA.Text == "" || txtNilaiB.Text == "" || OnOperasi.SelectedIndex == -1)
            {              
            }
            else
            {
                var a = int.Parse(txtNilaiA.Text);
                var b = int.Parse(txtNilaiB.Text);

                if (OnOperasi.SelectedIndex == 0)
                {
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(string.Format("{2}", a, b, Penambahan(a, b)));
                }
                else if (OnOperasi.SelectedIndex == 1)
                {
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(string.Format("{2}", a, b, Pengurangan(a, b)));
                }
                else if (OnOperasi.SelectedIndex == 2)
                {
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(string.Format("{2}", a, b, Perkalian(a, b)));
                }
                else if (OnOperasi.SelectedIndex == 3)
                {
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(string.Format("{2}", a, b, Pembagian(a, b)));
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void OnOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNilaiA_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstHasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
