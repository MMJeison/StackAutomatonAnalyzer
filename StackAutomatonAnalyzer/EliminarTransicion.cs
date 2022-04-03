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
    public partial class EliminarTransicion : UserControl
    {
        private InsertTrasisionConfEstados _insertTrasisionConfEstados;
        private AP _automataPila;
        public EliminarTransicion(InsertTrasisionConfEstados insertTrasisionConfEstados, AP automataPila)
        {
            InitializeComponent();
            _insertTrasisionConfEstados = insertTrasisionConfEstados;
            _automataPila = automataPila;
            cargarListaTransiciones();
        }

        public void cargarListaTransiciones()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Seleccionar");
            comboBox1.SelectedItem = "Seleccionar";
            foreach(var tran in _automataPila._transiciones)
            {
                if(!tran.Key.Equals("R") && !tran.Key.Equals("A"))
                {
                    comboBox1.Items.Add(tran.Key);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string transicion = (string)comboBox1.SelectedItem;
            if (transicion == null || transicion.Equals("Seleccionar"))
            {
                MessageBox.Show("Seleccione una transicion", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _automataPila._transiciones.Remove(transicion);
            foreach (var est in _automataPila._estados)
            {
                (string, string)[] keysE = est.Value._transiciones.Keys.ToArray<(string, string)>();
                foreach ((string, string) tran in keysE)
                {
                    if (est.Value._transiciones[tran]._id.Equals(transicion))
                    {
                        est.Value._transiciones.Remove(tran);
                    }
                }
            }
            _insertTrasisionConfEstados._principal._panel1.Controls.Remove(this);
            _insertTrasisionConfEstados.Enabled = true;
            _insertTrasisionConfEstados.cargarListaTransiciones();
            _insertTrasisionConfEstados.cargarListEstados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _insertTrasisionConfEstados._principal._panel1.Controls.Remove(this);
            _insertTrasisionConfEstados.Enabled = true;
        }
    }
}
