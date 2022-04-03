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
    public partial class InsertTrasisionConfEstados : UserControl
    {
        public Principal _principal;
        public AP _automataPila;
        public TableLayoutPanel _tabla2;
        public InsertTrasisionConfEstados(Principal principal, AP automataPila)
        {
            InitializeComponent();
            _principal = principal;
            _automataPila = automataPila;
            cargarListaTransiciones();
            cargarListEstados();
        }
        public void cargarListaTransiciones()
        {
            panel1.Controls.Clear();
            TableLayoutPanel _tabla = new TableLayoutPanel();
            _tabla.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            int filas = _automataPila._transiciones.Count;
            int columnas = 4;
            List<string> keys = _automataPila._transiciones.Keys.ToList<string>();
            Label lbl;
            for (int i = 0; i < columnas; i++)
            {
                lbl = new Label();
                lbl.AutoSize = true;
                if (i == 0) lbl.Text = "Id";
                else if (i == 1) lbl.Text = "Op.Sob.Pila";
                else if (i == 2) lbl.Text = "Op.Sob.Estado";
                else lbl.Text = "Op.Sob.Entrada";
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                _tabla.Controls.Add(lbl, i, 0);
            }
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    lbl = new Label();
                    lbl.AutoSize = true;
                    if (j == 0) lbl.Text = _automataPila._transiciones[keys[i]]._id;
                    else if (j == 1)
                    {
                        string[] simbs = (string[])_automataPila._transiciones[keys[i]]._operacionSobrePila[1];
                        string str = string.Empty;
                        foreach (string s in simbs)
                        {
                            if (str.Equals(string.Empty))
                            {
                                str += s;
                                continue;
                            }
                            str += " " + s;
                        }
                        lbl.Text = _automataPila._transiciones[keys[i]]._operacionSobrePila[0] +
                             ": " + str;
                    }
                    else if (j == 2)
                    {
                        lbl.Text = _automataPila._transiciones[keys[i]]._operacionSobreEstado[0] +
                            ": " + _automataPila._transiciones[keys[i]]._operacionSobreEstado[1];
                    }
                    else lbl.Text = _automataPila._transiciones[keys[i]]._operacionSobreEentrada;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    _tabla.Controls.Add(lbl, j, i + 1);
                }
            }
            _tabla.AutoSize = true;
            panel1.Controls.Add(_tabla);
        }
        public void cargarListEstados()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Seleccionar");
            comboBox1.SelectedItem = "Seleccionar";
            panel2.Controls.Clear();
            _tabla2 = new TableLayoutPanel();
            _tabla2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            int nroEstados = _automataPila._estados.Count;
            List<string> keys = _automataPila._estados.Keys.ToList<string>();
            Label lbl;
            for (int i = 0; i < 2; i++)
            {
                lbl = new Label();
                lbl.AutoSize = true;
                if (i == 0) lbl.Text = "Estado";
                else lbl.Text = "TieneTransiciones";
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                _tabla2.Controls.Add(lbl, i, 0);
            }
            for (int i = 0; i < nroEstados; i++)
            {
                string str = "Si";
                foreach (string sp in _automataPila._simbEnPila)
                    {
                        foreach(string se in _automataPila._simbEntrada)
                        {
                            if (!_automataPila._estados[keys[i]]._transiciones.Keys.Contains((sp, se)))
                            {
                                str = "No";
                                break;
                            }
                    }
                    if (str.Equals("No")) break;
                }
                lbl = new Label();
                lbl.AutoSize = true;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Text = _automataPila._estados[keys[i]]._nombre;
                comboBox1.Items.Add(_automataPila._estados[keys[i]]._nombre);
                _tabla2.Controls.Add(lbl, 0, i + 1);
                lbl = new Label();
                lbl.AutoSize = true;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Text = str;
                _tabla2.Controls.Add(lbl, 1, i + 1);
            }
            _tabla2.AutoSize = true;
            panel2.Controls.Add(_tabla2);
        }
        private void btn_InsertarTransicion_Click(object sender, EventArgs e)
        {
            AgregarTransicion agregarTransicion = new AgregarTransicion(this, _automataPila);
            Enabled = false;
            agregarTransicion.Location = new Point(90, 40);
            _principal.Controls.Add(agregarTransicion);
            agregarTransicion.BringToFront();
        }

        private void btn_EditarTransiciones_Click(object sender, EventArgs e)
        {
            string estado = (string)comboBox1.SelectedItem;
            if(estado == null || estado.Equals("Seleccionar"))
            {
                MessageBox.Show("Seleccione un estado para editar sus transiciones", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ConfgEstado confgEstado = new ConfgEstado(this, _automataPila, _automataPila._estados[estado]);
            Enabled = false;
            confgEstado.Location = new Point(90, 40);
            _principal.Controls.Add(confgEstado);
            confgEstado.BringToFront();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            IngresarDatosIniciales ingresarDatosIniciales = new IngresarDatosIniciales(_principal, _automataPila);
            _principal._panel1.Controls.Remove(this);
            _principal._panel1.Controls.Add(ingresarDatosIniciales);
        }
        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < _automataPila._estados.Count; i++)
            {
                Label lbl = (Label)_tabla2.GetControlFromPosition(1, i + 1);
                if (lbl.Text.Equals("No"))
                {
                    MessageBox.Show("Algunos estados no tienen transiciones", "Alerta",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            VerAPEvalucarCadena verAPEvalucarCadena = new VerAPEvalucarCadena(_principal, _automataPila);
            _principal._panel1.Controls.Remove(this);
            _principal._panel1.Controls.Add(verAPEvalucarCadena);
        }

        private void btn_EliminarTransicion_Click(object sender, EventArgs e)
        {
            if(_automataPila._transiciones.Count == 2)
            {
                MessageBox.Show("No hay transiciones que se puedan eliminar", "Alerta",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EliminarTransicion eliminarTransicion = new EliminarTransicion(this, _automataPila);
            Enabled = false;
            eliminarTransicion.Location = new Point(200, 110);
            _principal._panel1.Controls.Add(eliminarTransicion);
            eliminarTransicion.BringToFront();
        }
    }
}
