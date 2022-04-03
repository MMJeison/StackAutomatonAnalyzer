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
    public partial class EliminarSimbPila : UserControl
    {
        private IngresarDatosIniciales _ingresarDatosIniciales;
        private AP _automataPila;
        public EliminarSimbPila(IngresarDatosIniciales ingresarDatosIniciales, AP automataPila)
        {
            InitializeComponent();
            _ingresarDatosIniciales = ingresarDatosIniciales;
            _automataPila = automataPila;
            cargarListSimbPila();
        }

        public void cargarListSimbPila()
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
            bool seMostroMensaje = false;
            string[] keys = _automataPila._transiciones.Keys.ToArray<string>();
            foreach(var tr in keys)
            {
                if (((string)_automataPila._transiciones[tr]._operacionSobrePila[0]).Equals("Apilar")
                    || ((string)_automataPila._transiciones[tr]._operacionSobrePila[0]).Equals("Replace"))
                {
                    string[] list = (string[])_automataPila._transiciones[tr]._operacionSobrePila[1];
                    if (list.Contains(simbolo))
                    {
                        if (!seMostroMensaje)
                        {
                            if(MessageBox.Show("Algunas transiciones contienen el simbolo a elimnar\n" +
                                "Estas transiciones seran eliminadas.\nDesea continuar?",
                                "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                seMostroMensaje = true;
                            }
                            else
                            {
                                return;
                            }
                        }
                        _automataPila._transiciones.Remove(tr);
                        foreach(var est in _automataPila._estados)
                        {
                            (string, string)[] keysE = est.Value._transiciones.Keys.ToArray<(string, string)>();
                            foreach((string, string) tran in keysE)
                            {
                                if (est.Value._transiciones[tran]._id.Equals(tr))
                                {
                                    est.Value._transiciones.Remove(tran);
                                }
                            }
                        }
                    }
                }
            }
            _automataPila._simbEnPila.Remove(simbolo);
            if (_automataPila._configuracionInicialPila.Contains(simbolo))
            {
                _automataPila._configuracionInicialPila.Remove(simbolo);
                _ingresarDatosIniciales.cargarConfgInicialPila();
            }
            foreach (string estado in _automataPila._estados.Keys)
            {
                foreach (string simb in _automataPila._simbEntrada)
                {
                    if (_automataPila._estados[estado]._transiciones.ContainsKey((simbolo, simb)))
                    {
                        _automataPila._estados[estado]._transiciones.Remove((simbolo, simb));
                    }
                }
            }
            _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
            _ingresarDatosIniciales.Enabled = true;
            _ingresarDatosIniciales.cargarListaDeSimbolosPila();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
            _ingresarDatosIniciales.Enabled = true;
        }
    }
}
