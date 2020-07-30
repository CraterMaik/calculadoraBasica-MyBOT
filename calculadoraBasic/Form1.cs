using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadoraBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtResultado.Enabled = false;
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            Operaciones(txtValor1.Text, txtValor2.Text, 1);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtResultado.Clear();
            txtValor1.Focus();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            Operaciones(txtValor1.Text, txtValor2.Text, 2);
        }
        private void Operaciones(string valor1txt, string valor2txt, int tipo)
        {
            int resultadoTotal, valor1 = 0, valor2 = 0;

            if (valor1txt.Trim() == "")
            {
                MessageBox.Show("Debes agregar los valores ha sumar.");

            }
            else
                if (valor2txt.Trim() == "")
                {
                    MessageBox.Show("Debes agregar los valores ha sumar.");
                }
                else
                {

                    bool res = Int32.TryParse(valor1txt.Trim(), out valor1);
                    bool res2 = Int32.TryParse(valor2txt.Trim(), out valor2);
                    if (res == false)
                    {
                        MessageBox.Show("Debes agregar un numero como valor");
                        return;

                    }
                    else
                        if (res2 == false)
                        {
                            MessageBox.Show("Debes agregar un numero como valor");
                            return;

                        }

                    if (tipo == 1)
                    {
                        resultadoTotal = Convert.ToInt32(valor1txt) + Convert.ToInt32(valor2txt);
                        txtResultado.Text = resultadoTotal.ToString();
                    }
                    else if (tipo == 2)
                    {
                        resultadoTotal = Convert.ToInt32(valor1txt) - Convert.ToInt32(valor2txt);
                        txtResultado.Text = resultadoTotal.ToString();
                    }
                    else if (tipo == 3)
                    {
                        resultadoTotal = Convert.ToInt32(valor1txt) / Convert.ToInt32(valor2txt);
                        txtResultado.Text = resultadoTotal.ToString();
                    }
                    else if (tipo == 4)
                    {
                        resultadoTotal = Convert.ToInt32(valor1txt) * Convert.ToInt32(valor2txt);
                        txtResultado.Text = resultadoTotal.ToString();
                    }
                   

                  

                }
        }

        private void btnDivisor_Click(object sender, EventArgs e)
        {
            Operaciones(txtValor1.Text, txtValor2.Text, 3);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Operaciones(txtValor1.Text, txtValor2.Text, 4);
        }
    }
}
