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
    public partial class AgregarSimbPila : UserControl
    {
        private IngresarDatosIniciales _ingresarDatosIniciales;
        private AP _automataPila;
        public AgregarSimbPila(IngresarDatosIniciales ingresarDatosIniciales, AP automataPila)
        {
            InitializeComponent();
            _ingresarDatosIniciales = ingresarDatosIniciales;
            _automataPila = automataPila;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar un simbolo", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            if (_automataPila._simboloPilaVacia.Equals(textBox1.Text))
            {
                MessageBox.Show("Este intentando ingresar el simbolo de pila vacia.\n" +
                    "Ingrese un simbolo diferente", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            if (_automataPila._simbEnPila.Contains(textBox1.Text))
            {
                MessageBox.Show("EL simbolo ya ha sido ingresado.\n" +
                    "Ingrese un simbolo diferente", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            _automataPila._simbEnPila.Insert(_automataPila._simbEnPila.Count - 1, textBox1.Text);
            _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
            _ingresarDatosIniciales.Enabled = true;
            _ingresarDatosIniciales.cargarListaDeSimbolosPila();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
            _ingresarDatosIniciales.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
                return;
            }
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length >= 1)
            {
                if (e.KeyChar != 127 && e.KeyChar != 8)
                {
                    e.Handled = true;
                    return;
                }
            }
        }
    }
}
