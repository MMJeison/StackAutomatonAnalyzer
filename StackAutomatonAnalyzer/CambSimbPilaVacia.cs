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
    public partial class CambSimbPilaVacia : UserControl
    {
        private IngresarDatosIniciales _ingresarDatosIniciales;
        private AP _automataPila;
        public CambSimbPilaVacia(IngresarDatosIniciales ingresarDatosIniciales, AP automataPila)
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
            if (tb.Text.Length > 0)
            {
                if (e.KeyChar != 8 && e.KeyChar != 127)
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
                MessageBox.Show("Debe ingresar un simbolo", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            if (_automataPila._simbEntrada.Contains(textBox1.Text)
                || _automataPila._simboloFinSecuencia.Equals(textBox1.Text))
            {
                MessageBox.Show("El simbolo ya ha sido ingresado, por favor ingrese\n" +
                       "un simbolo diferente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
                return;
            }
            _automataPila._simbEnPila[_automataPila._simbEnPila.Count - 1] = textBox1.Text;
            _automataPila._simboloPilaVacia = textBox1.Text;
            _automataPila._configuracionInicialPila[0] = textBox1.Text;
            _ingresarDatosIniciales.cargarConfgInicialPila();
            _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
            _ingresarDatosIniciales.Enabled = true;
            _ingresarDatosIniciales.cargarListaDeSimbolosPila();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
            _ingresarDatosIniciales.Enabled = true;
            _ingresarDatosIniciales.cargarListaDeSimbolosEntrada();
        }
    }
}
