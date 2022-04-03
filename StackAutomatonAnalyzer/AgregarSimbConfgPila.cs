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
    public partial class AgregarSimbConfgPila : UserControl
    {
        private IngresarDatosIniciales _ingresarDatosIniciales;
        private AP _automataPila;
        public AgregarSimbConfgPila(IngresarDatosIniciales ingresarDatosIniciales, AP automataPila)
        {
            InitializeComponent();
            _ingresarDatosIniciales = ingresarDatosIniciales;
            _automataPila = automataPila;
            cargarListaSimbPila();
        }

        public void cargarListaSimbPila()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Seleccionar");
            comboBox1.SelectedItem = "Seleccionar";
            foreach (string simbolo in _automataPila._simbEnPila)
            {
                if (!simbolo.Equals(_automataPila._simboloPilaVacia))
                {
                    comboBox1.Items.Add(simbolo);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string simbolo = (string)comboBox1.SelectedItem;
            if (simbolo == null || simbolo.Equals("Seleccionar"))
            {
                MessageBox.Show("Seleccione un simbolo", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _automataPila._configuracionInicialPila.Add(simbolo);
            _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
            _ingresarDatosIniciales.Enabled = true;
            _ingresarDatosIniciales.cargarConfgInicialPila();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
            _ingresarDatosIniciales.Enabled = true;
        }
    }
}
