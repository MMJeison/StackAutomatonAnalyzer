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
    public partial class EliminarEstado : UserControl
    {
        private IngresarDatosIniciales _ingresarDatosIniciales;
        private AP _automataPila;
        public EliminarEstado(IngresarDatosIniciales ingresarDatosIniciales, AP automataPila)
        {
            InitializeComponent(); 
            _ingresarDatosIniciales = ingresarDatosIniciales;
            _automataPila = automataPila;
            cargarListaEstados();
        }
        public void cargarListaEstados()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Seleccionar");
            comboBox1.SelectedItem = "Seleccionar";
            foreach (string simbolo in _automataPila._estados.Keys)
            {
                comboBox1.Items.Add(simbolo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string estado = (string)comboBox1.SelectedItem;
            if (estado == null || estado.Equals("Seleccionar"))
            {
                MessageBox.Show("Seleccione un estado", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool seMostroMensaje = false;
            string[] keys = _automataPila._transiciones.Keys.ToArray<string>();
            foreach (var tr in keys)
            {
                string estAux = _automataPila._transiciones[tr]._operacionSobreEstado[1];
                if (estAux.Equals(estado))
                {
                    if (!seMostroMensaje)
                    {
                        if (MessageBox.Show("Algunas transiciones contienen el estado a elimnar\n" +
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
                    foreach (var est in _automataPila._estados)
                    {
                        (string, string)[] keysE = est.Value._transiciones.Keys.ToArray<(string, string)>();
                        foreach ((string, string) tran in keysE)
                        {
                            if (est.Value._transiciones[tran]._id.Equals(tr))
                            {
                                est.Value._transiciones.Remove(tran);
                            }
                        }
                    }
                }
            }
            _automataPila._estados.Remove(estado);
            string estInicial = (string)_ingresarDatosIniciales._cb_SelecEstadoInicial.SelectedItem;
            _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
            _ingresarDatosIniciales.Enabled = true;
            _ingresarDatosIniciales.cargarListaEstados();
            if (estInicial != null && !estInicial.Equals(estado))
            {
                _ingresarDatosIniciales._cb_SelecEstadoInicial.SelectedItem = estInicial;
            }
            else
            {
                _ingresarDatosIniciales._cb_SelecEstadoInicial.SelectedIndex = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ingresarDatosIniciales._principal._panel1.Controls.Remove(this);
            _ingresarDatosIniciales.Enabled = true;
        }
    }
}
