using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackAutomatonAnalyzer
{
    public partial class AgregarEstado : UserControl
    {
        private IngresarDatosIniciales _ingresarDatosIniciales;
        private AP _automataPila;
        public AgregarEstado(IngresarDatosIniciales ingresarDatosIniciales, AP automataPila)
        {
            InitializeComponent(); 
            _ingresarDatosIniciales = ingresarDatosIniciales;
            _automataPila = automataPila;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
                return;
            }
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length >= 4)
            {
                if (e.KeyChar != 127 && e.KeyChar != 8)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar un nombre para el estado", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            if (textBox1.Text.Equals(_automataPila._simboloFinSecuencia))
            {
                MessageBox.Show("Esta intentado ingresar como nombre el simbolo de fin de secuencia.\n" +
                    "Ingrese un simbolo diferente", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
                return;
            }
            if (textBox1.Text.Equals(_automataPila._simboloPilaVacia))
            {
                MessageBox.Show("Esta intentado ingresar como nombre el simbolo de pila vacia.\n" +
                    "Ingrese un simbolo diferente", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
                return;
            }
            if (!_automataPila._estados.Keys.Contains(textBox1.Text))
            {
                string estInicial = (string)_ingresarDatosIniciales._cb_SelecEstadoInicial.SelectedItem;
                _automataPila._estados.Add(textBox1.Text, new Estado(textBox1.Text));
                _ingresarDatosIniciales.Enabled = true;
                _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
                _ingresarDatosIniciales.cargarListaEstados();
                if (estInicial != null)
                {
                    _ingresarDatosIniciales._cb_SelecEstadoInicial.SelectedItem = estInicial;
                }
            }
            else
            {
                MessageBox.Show("Ye existe un estado com nombre "+ textBox1.Text +", por favor\n" +
                    "ingrese un nombre diferente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
            _ingresarDatosIniciales.Enabled = true;
        }
    }
}
