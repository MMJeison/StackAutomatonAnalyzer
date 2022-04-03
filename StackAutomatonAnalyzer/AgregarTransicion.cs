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
    public partial class AgregarTransicion : UserControl
    {
        private InsertTrasisionConfEstados _insertTrasisionConfEstados;
        private AP _automataPila;
        public AgregarTransicion(InsertTrasisionConfEstados insertTrasisionConfEstados, AP automataPila)
        {
            InitializeComponent();
            _insertTrasisionConfEstados = insertTrasisionConfEstados;
            _automataPila = automataPila;
            cargarListaOpPila();
            cb_OpPila.SelectedIndex = 0;
            cargarListSimbolos();
            cargarListaOpEstado();
            cargarListaEstados();
            cargarLisOpEntrada();
        }

        public void cargarListaOpPila()
        {
            cb_OpPila.Items.Clear();
            cb_OpPila.Items.Add("Seleccionar");
            cb_OpPila.Items.Add("Apilar");
            cb_OpPila.Items.Add("Desapilar");
            cb_OpPila.Items.Add("Replace");
            cb_OpPila.Items.Add("Ninguna");
        }
        public void cargarListSimbolos()
        {
            cb_SelecSimbolo.Items.Clear();
            cb_SelecSimbolo.Items.Add("Seleccionar");
            foreach (string simbolo in _automataPila._simbEnPila)
            {
                if (!simbolo.Equals(_automataPila._simboloPilaVacia))
                {
                    cb_SelecSimbolo.Items.Add(simbolo);
                }
            }
        }
        private void cb_OpPila_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_OpPila.SelectedItem.Equals("Seleccionar"))
            {
                listBox1.Enabled = false;
                label5.Enabled = false;
                cb_SelecSimbolo.Enabled = false;
                btn_AddSimbolo.Enabled = false;
                listBox1.Items.Clear();
            }
            else if (cb_OpPila.SelectedItem.Equals("Apilar"))
            {
                listBox1.Enabled = true;
                label5.Enabled = true;
                cb_SelecSimbolo.Enabled = true;
                btn_AddSimbolo.Enabled = true;
                listBox1.Items.Clear();
            }
            else if (cb_OpPila.SelectedItem.Equals("Desapilar"))
            {
                listBox1.Enabled = false;
                label5.Enabled = false;
                cb_SelecSimbolo.Enabled = false;
                btn_AddSimbolo.Enabled = false;
                listBox1.Items.Clear();
            }
            else if (cb_OpPila.SelectedItem.Equals("Replace"))
            {
                listBox1.Enabled = true;
                label5.Enabled = true;
                cb_SelecSimbolo.Enabled = true;
                btn_AddSimbolo.Enabled = true;
                listBox1.Items.Clear();
            }
            else if (cb_OpPila.SelectedItem.Equals("Ninguna"))
            {
                listBox1.Enabled = false;
                label5.Enabled = false;
                cb_SelecSimbolo.Enabled = false;
                btn_AddSimbolo.Enabled = false;
                listBox1.Items.Clear();
            }
        }

        private void btn_AddSimbolo_Click(object sender, EventArgs e)
        {
            string simbolo = (string)cb_SelecSimbolo.SelectedItem;
            if(simbolo == null || simbolo.Equals("Seleccionar"))
            {
                MessageBox.Show("Seleccione un simbolo", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cb_OpPila.SelectedItem.Equals("Apilar"))
            {
                if(listBox1.Items.Count > 0)
                {
                    MessageBox.Show("Solo se puede apilar un simbolo a la vez", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                listBox1.Items.Add(simbolo);
                return;
            }
            listBox1.Items.Add(simbolo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        public void cargarListaOpEstado()
        {
            cb_OpEstado.Items.Clear();
            cb_OpEstado.Items.Add("Seleccionar");
            cb_OpEstado.Items.Add("Cambiar a");
            cb_OpEstado.Items.Add("Permanecer en");
        }
        public void cargarListaEstados()
        {
            cb_SelecEstado.Items.Clear();
            cb_SelecEstado.Items.Add("Seleccionar");
            foreach (string estado in _automataPila._estados.Keys)
            {
                cb_SelecEstado.Items.Add(estado);
            }
        }
        public void cargarLisOpEntrada()
        {
            cb_OpEntrada.Items.Clear();
            cb_OpEntrada.Items.Add("Seleccionar");
            cb_OpEntrada.Items.Add("Avanzar");
            cb_OpEntrada.Items.Add("Retener");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length < 1)
            {
                MessageBox.Show("Ingrese un Id para la transicion", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_automataPila._transiciones.Keys.Contains(textBox1.Text))
            {
                MessageBox.Show("Ya existe una transicion con id '" + textBox1.Text + "'\n"
                    + "Por favor ingrese in id diferente", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cb_OpPila.SelectedItem == null || cb_OpPila.SelectedItem.Equals("Seleccionar"))
            {
                MessageBox.Show("Seleccione una operacion sobre la pila", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cb_OpPila.SelectedItem.Equals("Apilar") && listBox1.Items.Count == 0)
            {
                MessageBox.Show("Agrege un simbolo a apilar", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cb_OpPila.SelectedItem.Equals("Replace") && listBox1.Items.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un simbolo para aplicar replace", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            object[] operacionPila;
            if (cb_OpPila.SelectedItem.Equals("Replace") || cb_OpPila.SelectedItem.Equals("Apilar"))
            {
                string[] simbs = new string[listBox1.Items.Count];
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    simbs[i] = (string)listBox1.Items[i];
                }
                operacionPila = new object[] { cb_OpPila.SelectedItem, simbs };
            }
            else
            {
                operacionPila = new object[] { cb_OpPila.SelectedItem, new string[] { "" } };
            }
            if (cb_OpEstado.SelectedItem == null || cb_OpEstado.SelectedItem.Equals("Seleccionar"))
            {
                MessageBox.Show("Seleccione una operacion sobre el estado", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cb_SelecEstado.SelectedItem == null || cb_SelecEstado.SelectedItem.Equals("Seleccionar"))
            {
                if (cb_OpEstado.SelectedItem.Equals("Cambiar a"))
                {
                    MessageBox.Show("Seleccione el estado al que se cambiará", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Seleccione el estado en el que permanecerá", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            string[] opreacionEstado = new string[] { (string)cb_OpEstado.SelectedItem, (string)cb_SelecEstado.SelectedItem };
            if (cb_OpEntrada.SelectedItem == null || cb_OpEntrada.SelectedItem.Equals("Seleccionar"))
            {
                MessageBox.Show("Seleccione una operacion sobre la entrada", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Transicion t = new Transicion(textBox1.Text, operacionPila, opreacionEstado, (string)cb_OpEntrada.SelectedItem);
            _automataPila._transiciones.Add(textBox1.Text, t);
            _insertTrasisionConfEstados.Enabled = true;
            _insertTrasisionConfEstados._principal._panel1.Controls.Remove(this);
            Visible = false;
            _insertTrasisionConfEstados.cargarListaTransiciones();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
                return;
            }
            TextBox tb = (TextBox)sender;
            if(tb.Text.Length >= 3)
            {
                if(e.KeyChar != 8 && e.KeyChar != 127)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _insertTrasisionConfEstados._principal._panel1.Controls.Remove(this);
            Visible = false;
            _insertTrasisionConfEstados.Enabled = true;
        }
    }
}
