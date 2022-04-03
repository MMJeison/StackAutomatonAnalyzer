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
    public partial class AgregarSimbEntrada : UserControl
    {
        private IngresarDatosIniciales _ingresarDatosIniciales;
        private AP _automataPila;
        public AgregarSimbEntrada(IngresarDatosIniciales ingresarDatosIniciales, AP automataPila)
        {
            InitializeComponent();
            _ingresarDatosIniciales = ingresarDatosIniciales;
            _automataPila = automataPila;
        }

        private void tb_IngresarSimbEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 32)
            {
                e.Handled = true;
                return;
            }
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length >= 1)
            {
                if(e.KeyChar != 127 && e.KeyChar != 8)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ingresarDatosIniciales.Enabled = true;
            _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_IngresarSimbEntrada.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar un simbolo", "Alerta", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_IngresarSimbEntrada.Focus();
                return;
            }
            if (tb_IngresarSimbEntrada.Text.Equals(_automataPila._simboloFinSecuencia))
            {
                MessageBox.Show("Esta intentado ingresar el simbolo de fin de secuencia.\n" +
                    "Ingrese un simbolo diferente", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_IngresarSimbEntrada.Text = string.Empty;
                return;
            }
            if (tb_IngresarSimbEntrada.Text.Equals(_automataPila._simboloPilaVacia))
            {
                MessageBox.Show("Esta intentado ingresar el simbolo de pila vacia.\n" +
                    "Ingrese un simbolo diferente", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_IngresarSimbEntrada.Text = string.Empty;
                return;
            }
            if (_automataPila._simbEntrada.Contains(tb_IngresarSimbEntrada.Text))
            {
                MessageBox.Show("El simbolo ya ha sido ingresado, por favor ingrese\n" +
                    "un simbolo diferente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_IngresarSimbEntrada.Text = string.Empty;
                return;
            }
            _automataPila._simbEntrada.Insert(_automataPila._simbEntrada.Count - 1, tb_IngresarSimbEntrada.Text);
            _ingresarDatosIniciales.Enabled = true;
            _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
            _ingresarDatosIniciales.cargarListaDeSimbolosEntrada();
        }
    }
}
