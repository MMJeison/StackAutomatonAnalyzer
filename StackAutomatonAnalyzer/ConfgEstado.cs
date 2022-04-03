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
    public partial class ConfgEstado : UserControl
    {
        private InsertTrasisionConfEstados _insertTrasisionConfEstados;
        private AP _automataPila;
        private Estado _estado;
        private TableLayoutPanel _tabla;
        private Dictionary<(string, string), ComboBox> comboboxs;
        public ConfgEstado(InsertTrasisionConfEstados insertTrasisionConfEstados, AP automataPila, Estado estado)
        {
            InitializeComponent();
            _insertTrasisionConfEstados = insertTrasisionConfEstados;
            _automataPila = automataPila;
            _estado = estado;
            lbl_Nombre.Text = estado._nombre;
            cargarTabla();
        }

        public void cargarTabla()
        {
            _tabla = new TableLayoutPanel();
            _tabla.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            int filas = _automataPila._simbEnPila.Count;
            int columnas = _automataPila._simbEntrada.Count;
            List<string> simbPilAux = _automataPila._simbEnPila;
            List<string> simbEntAux = _automataPila._simbEntrada;
            int ancho = 80;
            int alto = 25;
            Label lbl;
            for (int i = 0; i < (columnas+1); i++)
            {
                if(i == 0)
                {
                    lbl = new Label();
                    lbl.Text = "";
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Size = new Size(ancho - 15, alto);
                    _tabla.Controls.Add(lbl, i, 0);
                    continue;
                }
                lbl = new Label();
                lbl.Text = simbEntAux[i - 1];
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Size = new Size(ancho, alto);
                _tabla.Controls.Add(lbl, i, 0);
            }
            comboboxs = new Dictionary<(string, string), ComboBox>();
            for(int i = 0; i < filas; i++)
            {
                for(int j = 0; j < (columnas+1); j++)
                {
                    if(j == 0)
                    {
                        lbl = new Label();
                        lbl.Text = simbPilAux[i];
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Size = new Size(ancho - 15, alto);
                        _tabla.Controls.Add(lbl, 0, i + 1);
                        continue;
                    }
                    ComboBox cb = new ComboBox();
                    cb.Size = new Size(ancho, cb.Height);
                    cb.DropDownStyle = ComboBoxStyle.DropDownList;
                    cb.Items.Add("Seleccionar");
                    cb.SelectedItem = "Seleccionar";
                    cargarTransicionesAlComoBox(cb);
                    if(_estado._transiciones.Keys.Contains((simbPilAux[i], simbEntAux[j - 1])))
                    {
                        cb.SelectedItem = _estado._transiciones[(simbPilAux[i], simbEntAux[j - 1])]._id;
                    }
                    comboboxs[(simbPilAux[i], simbEntAux[j - 1])] = cb;
                    _tabla.Controls.Add(cb, j, i + 1);
                }
            }
            _tabla.AutoSize = true;
            panel1.Controls.Add(_tabla);
        }
        public void cargarTransicionesAlComoBox(ComboBox cb)
        {
            foreach(string transicion in _automataPila._transiciones.Keys)
            {
                cb.Items.Add(transicion);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<(string, string), Transicion> aux = _estado._transiciones;
            foreach(var v in comboboxs)
            {
                if(v.Value.SelectedItem == null || v.Value.SelectedItem.Equals("Seleccionar"))
                {
                    MessageBox.Show("Campos sin llenar", "Alerta",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _estado._transiciones = aux;
                    return;
                }
                _estado._transiciones[v.Key] = _automataPila._transiciones[(string)v.Value.SelectedItem];
            }
            _insertTrasisionConfEstados._principal._panel1.Controls.Remove(this);
            Visible = false;
            _insertTrasisionConfEstados.Enabled = true;
            _insertTrasisionConfEstados.cargarListEstados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _insertTrasisionConfEstados._principal._panel1.Controls.Remove(this);
            _insertTrasisionConfEstados.Enabled = true;
            Visible = false;
        }
    }
}
