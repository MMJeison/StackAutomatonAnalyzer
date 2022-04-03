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
    public partial class VerAPEvalucarCadena : UserControl
    {
        public Principal _principal;
        public AP _automataPila;
        public char[] _simbsEntrada;
        public int i;
        public VerAPEvalucarCadena(Principal principal, AP automataPila)
        {
            InitializeComponent();
            _principal = principal;
            _automataPila = automataPila;
            cargarDatosAutomata();
            button4.Enabled = false;
            panel5.Enabled = false;
            label16.Text = "";
            label13.Text = "";
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 32)
            {
                e.Handled = true;
                return;
            }
            panel5.Enabled = false;
            button3.Enabled = true;
        }
        public void cargarDatosAutomata()
        {
            string str = string.Empty;
            foreach(string s in _automataPila._simbEntrada)
            {
                if (str.Equals(string.Empty))
                {
                    str = s;
                    continue;
                }
                str += "  " + s;
            }
            label2.Text = str;
            str = string.Empty;
            foreach (string s in _automataPila._simbEnPila)
            {
                if (str.Equals(string.Empty))
                {
                    str = s;
                    continue;
                }
                str += "  " + s;
            }
            label4.Text = str;
            str = string.Empty;
            foreach (string s in _automataPila._estados.Keys)
            {
                if (str.Equals(string.Empty))
                {
                    str = s;
                    continue;
                }
                str += "  " + s;
            }
            label5.Text = str;
            label10.Text = _automataPila._estadoInicial;
            str = string.Empty;
            foreach (string s in _automataPila._transiciones.Keys)
            {
                if (str.Equals(string.Empty))
                {
                    str = s;
                    continue;
                }
                str += "  " + s;
            }
            label7.Text = str;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InsertTrasisionConfEstados insertTrasisionConfEstados = new InsertTrasisionConfEstados(_principal, _automataPila);
            _principal._panel1.Controls.Remove(this);
            _principal._panel1.Controls.Add(insertTrasisionConfEstados);
            Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            _principal.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string entrada = textBox1.Text;
            char[] simbolos = entrada.ToCharArray();
            foreach(char c in simbolos)
            {
                if (!_automataPila._simbEntrada.Contains(c.ToString())
                    || _automataPila._simboloFinSecuencia.Equals(c.ToString()))
                {
                    MessageBox.Show("Algunos simbolos de entrada no son válidos", "Alerta",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            _automataPila.evaluarEntrada(entrada);
            button4.Enabled = true;
            button3.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string entrada = textBox1.Text + _automataPila._simboloFinSecuencia;
            _simbsEntrada = entrada.ToCharArray();
            _automataPila._estadoActual = _automataPila._estadoInicial;
            _automataPila.establecerConfInicialPila();

            panel5.Enabled = true;
            i = 0;
            label16.Text = _simbsEntrada[i].ToString();
            label13.Text = _automataPila._estadoActual;
            actualizarListPila();
            actualizarTablaEstado();

            button4.Enabled = false;
        }
        public void actualizarListPila()
        {
            listBox1.Items.Clear();
            foreach(string simbolo in _automataPila._pila)
            {
                listBox1.Items.Add(simbolo);
            }
        }
        public void actualizarTablaEstado()
        {
            panel6.Controls.Clear();
            TableLayoutPanel _tabla = new TableLayoutPanel();
            _tabla.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            int filas = _automataPila._simbEnPila.Count;
            int columnas = _automataPila._simbEntrada.Count;
            List<string> simbPilAux = _automataPila._simbEnPila;
            List<string> simbEntAux = _automataPila._simbEntrada;
            int ancho = 40;
            int alto = 25;
            Label lbl;
            for (int i = 0; i < (columnas + 1); i++)
            {
                lbl = new Label();
                if (i == 0) lbl.Text = "";
                else lbl.Text = simbEntAux[i - 1];
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Size = new Size(ancho, alto);
                _tabla.Controls.Add(lbl, i, 0);
            }
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < (columnas + 1); j++)
                {
                    lbl = new Label();
                    if (j == 0) lbl.Text = simbPilAux[i];
                    else
                    {
                        lbl.Text = _automataPila._estados[_automataPila._estadoActual]._transiciones[(simbPilAux[i], simbEntAux[j - 1])]._id;
                    }
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.AutoSize = true;
                    _tabla.Controls.Add(lbl, j, i + 1);
                }
            }
            _tabla.AutoSize = true;
            panel6.Controls.Add(_tabla);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string simbolo = _simbsEntrada[i].ToString();
            Transicion t = _automataPila._estados[_automataPila._estadoActual]._transiciones[(_automataPila._pila.Peek(), simbolo)];
            if (t._id.Equals("A") && simbolo.Equals(_automataPila._simboloFinSecuencia))
            {
                i = -1;
            }
            if (t._id.Equals("R") || simbolo.Equals(_automataPila._simboloFinSecuencia))
            {
                i = -1;
            }
            if(i == -1)
            {
                panel5.Enabled = false;
                button4.Enabled = true;
                return;
            }
            string estAnt = _automataPila._estadoActual;
            int n = t.ejecutarTransicion(_automataPila);
            i += n;
            label16.Text = _simbsEntrada[i].ToString();
            label13.Text = _automataPila._estadoActual;
            actualizarListPila();
            if (!estAnt.Equals(_automataPila._estadoActual))
            {
                actualizarTablaEstado();
            }
        }
    }
}
