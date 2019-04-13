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

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor1, valor2, resultado;
        char op;

        public Form1()
        {
            InitializeComponent();
        }

        // Operaciones

        private void BtSuma_Click(object sender, EventArgs e)
        {
            if (TbResultado.Text.Length > 0 )
            {
                if (TbResultado.Text.Length < 2 && Convert.ToChar(TbResultado.Text) == ',')
                {
                   return;                    
                }

                valor1 = Convert.ToDouble( TbResultado.Text );
                op = '+';
                TbResultado.Clear();
                TbResultado.Focus();
            }
        }

        private void BtResta_Click(object sender, EventArgs e)
        {
            if ( TbResultado.Text.Length > 0)
            {
            valor1 = Convert.ToDouble(TbResultado.Text);
            op = '-';
            TbResultado.Clear();
            TbResultado.Focus();
            }
        }

        private void BtMultiplicacion_Click(object sender, EventArgs e)
        {
            if ( TbResultado.Text.Length > 0)
            {
            valor1 = Convert.ToDouble(TbResultado.Text);
            op = '*';
            TbResultado.Clear();
            TbResultado.Focus();
            }
        }

        private void BtDivision_Click(object sender, EventArgs e)
        {
            if ( TbResultado.Text.Length > 0)
            {
                valor1 = Convert.ToDouble(TbResultado.Text);
                op = '/';
                TbResultado.Clear();
                TbResultado.Focus();
            }
        }

        private void BtModulo_Click(object sender, EventArgs e)
        {
            if ( TbResultado.Text.Length > 0)
            {
            valor1 = Convert.ToDouble(TbResultado.Text);
            op = '%';
            TbResultado.Clear();
            TbResultado.Focus();
            }
        }

        private void BtSqrt_Click(object sender, EventArgs e)
        {
            op = '√';
        }

        private void BtPow_Click(object sender, EventArgs e)
        {
            if ( TbResultado.Text.Length > 0)
            {
            valor1 = Convert.ToDouble(TbResultado.Text);
            op = 'ª';
            TbResultado.Clear();
            TbResultado.Focus();
            }
        }

        private void BtnDouble_Click(object sender, EventArgs e)
        {
            TbResultado.AppendText( Convert.ToString(',') );
        }

        private void BtIgual_Click(object sender, EventArgs e)
        {
            if (TbResultado.Text.Length > 0)
            {
                try
                {
                    valor2 = Convert.ToDouble(TbResultado.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TbResultado.Clear();
                }

                switch (op)
                {
                    case '+':
                        TbResultado.Text = Convert.ToString(valor1 + valor2);
                        break;

                    case '-':
                        TbResultado.Text = Convert.ToString(valor1 - valor2);
                        break;

                    case '*':
                        TbResultado.Text = Convert.ToString(valor1 * valor2);
                        break;

                    case '/':

                        if (valor2 == 0)
                        {
                            MessageBox.Show("No se puede dividir entre 0",
                                             "Error",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Warning);

                            TbResultado.Clear();
                        }
                        else
                        {
                            TbResultado.Text = Convert.ToString(valor1 / valor2);
                        }
                        break;

                    case '%':
                        TbResultado.Text = Convert.ToString(valor1 % valor2);
                        break;

                    case '√':
                        TbResultado.Text = Convert.ToString(Math.Sqrt(valor2));
                        break;

                    case 'ª':
                        TbResultado.Text = Convert.ToString(Math.Pow(valor1, valor2));
                        break;

                }
            }
        }


        // Numeros

        private void BtUno_Click(object sender, EventArgs e)
        {
            TbResultado.Text += '1';
        }

        private void BtDos_Click(object sender, EventArgs e)
        {
            TbResultado.Text += '2';
        }

        private void BtTres_Click(object sender, EventArgs e)
        {
            TbResultado.Text += '3';
        }

        private void BtCuatro_Click(object sender, EventArgs e)
        {
            TbResultado.Text += '4';
        }

        private void BtCinco_Click(object sender, EventArgs e)
        {
            TbResultado.Text += '5';
        }

        private void BtSeis_Click(object sender, EventArgs e)
        {
            TbResultado.Text += '6';
        }

        private void BtSiete_Click(object sender, EventArgs e)
        {
            TbResultado.Text += '7';
        }

        private void BtOcho_Click(object sender, EventArgs e)
        {
            TbResultado.Text += '8';
        }

        private void BtNueve_Click(object sender, EventArgs e)
        {
            TbResultado.Text += '9';
        }

        private void BtCero_Click(object sender, EventArgs e)
        {
            TbResultado.Text += '0';
        }


        //Otros botones

        private void BtDel_Click(object sender, EventArgs e)
        {
            if (TbResultado.Text.Length > 0)
            {
                TbResultado.Text = TbResultado.Text.Substring(0, (TbResultado.Text.Length - 1));
            }


        }

        private void BtCe_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;

            TbResultado.Clear();
        }

        private void BtPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
