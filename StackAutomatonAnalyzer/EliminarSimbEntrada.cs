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
    public partial class EliminarSimbEntrada : UserControl
    {
        private IngresarDatosIniciales _ingresarDatosIniciales;
        private AP _automataPila;
        public EliminarSimbEntrada(IngresarDatosIniciales ingresarDatosIniciales, AP automataPila)
        {
            InitializeComponent();
            _ingresarDatosIniciales = ingresarDatosIniciales;
            _automataPila = automataPila;
            cargarListSimbEntrada();
        }

        public void cargarListSimbEntrada()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Seleccionar");
            comboBox1.SelectedItem = "Seleccionar";
            foreach (string simbolo in _automataPila._simbEntrada)
            {
                if (!simbolo.Equals(_automataPila._simboloFinSecuencia))
                {
                    comboBox1.Items.Add(simbolo);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string simbolo = (string)comboBox1.SelectedItem;
            if(simbolo == null || simbolo.Equals("Seleccionar"))
            {
                MessageBox.Show("Seleccione un simbolo", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _automataPila._simbEntrada.Remove(simbolo);
            foreach (string estado in _automataPila._estados.Keys)
            {
                foreach(string simbPila in _automataPila._simbEnPila)
                {
                    if(_automataPila._estados[estado]._transiciones.ContainsKey((simbPila, simbolo)))
                    {
                        _automataPila._estados[estado]._transiciones.Remove((simbPila, simbolo));
                    }
                }
            }
            _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
            _ingresarDatosIniciales.Enabled = true;
            _ingresarDatosIniciales.cargarListaDeSimbolosEntrada();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
            _ingresarDatosIniciales.Enabled = true;
        }
    }
}
