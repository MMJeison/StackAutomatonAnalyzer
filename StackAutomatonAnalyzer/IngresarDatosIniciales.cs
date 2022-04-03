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
    public partial class IngresarDatosIniciales : UserControl
    {
        public Principal _principal;
        public AP _automataPila;
        public ComboBox _cb_SelecEstadoInicial;
        public IngresarDatosIniciales(Principal principal, AP automataPila)
        {
            InitializeComponent();
            _principal = principal;
            _automataPila = automataPila;
            cargarListaDeSimbolosEntrada();
            cargarListaDeSimbolosPila();
            cargarListaEstados();
            cargarConfgInicialPila();
            _cb_SelecEstadoInicial = cb_SelecEstadoInicial;
        }

        public void cargarListaDeSimbolosEntrada()
        {
            lb_SimbEntrada.Items.Clear();
            foreach(string simbolo in _automataPila._simbEntrada)
            {
                lb_SimbEntrada.Items.Add(simbolo);
            }
        }
        public void cargarListaDeSimbolosPila()
        {
            lb_SimbPila.Items.Clear();
            foreach (string simbolo in _automataPila._simbEnPila)
            {
                lb_SimbPila.Items.Add(simbolo);
            }
        }
        public void cargarListaEstados()
        {
            lb_Estados.Items.Clear();
            cb_SelecEstadoInicial.Items.Clear();
            cb_SelecEstadoInicial.Items.Add("Seleccionar");
            foreach (var estado in _automataPila._estados)
            {
                lb_Estados.Items.Add(estado.Key);
                cb_SelecEstadoInicial.Items.Add(estado.Key);
            }
            if (_automataPila._estadoInicial != null)
            {
                cb_SelecEstadoInicial.SelectedItem = _automataPila._estadoInicial;
            }
            else cb_SelecEstadoInicial.SelectedItem = "Seleccionar";
        }
        public void cargarConfgInicialPila()
        {
            lb_ConfgPila.Items.Clear();
            foreach (string simbolo in _automataPila._configuracionInicialPila)
            {
                lb_ConfgPila.Items.Add(simbolo);
            }
        }
        private void btn_AgrSimbEntrada_Click(object sender, EventArgs e)
        {
            AgregarSimbEntrada agregarSimbEntrada = new AgregarSimbEntrada(this, _automataPila);
            Enabled = false;
            agregarSimbEntrada.Location = new Point(270, 85);
            _principal._panel1.Controls.Add(agregarSimbEntrada);
            agregarSimbEntrada.BringToFront();
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            if(_automataPila._simbEntrada.Count < 2)
            {
                MessageBox.Show("Debe ingresar por lo menos un simbolo de entrada", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_automataPila._simbEnPila.Count < 2)
            {
                MessageBox.Show("Debe ingresar por lo menos un simbolo en simbolos en la pila", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_automataPila._estados.Count < 1)
            {
                MessageBox.Show("Debe ingresar por lo menos un estado", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cb_SelecEstadoInicial.SelectedItem == null || cb_SelecEstadoInicial.SelectedItem.Equals("Seleccionar"))
            {
                MessageBox.Show("Debe seleccionar un estado inicial", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InsertTrasisionConfEstados insertTrasisionConfEstados = new InsertTrasisionConfEstados(_principal, _automataPila);
            _principal._panel1.Controls.Remove(this);
            _principal._panel1.Controls.Add(insertTrasisionConfEstados);
        }

        private void btn_ElimSimbEntrada_Click(object sender, EventArgs e)
        {
            if(_automataPila._simbEntrada.Count >= 2)
            {
                EliminarSimbEntrada eliminarSimbEntrada = new EliminarSimbEntrada(this, _automataPila);
                Enabled = false;
                eliminarSimbEntrada.Location = new Point(270, 85);
                _principal._panel1.Controls.Add(eliminarSimbEntrada);
                eliminarSimbEntrada.BringToFront();
            }
            else
            {
                MessageBox.Show("No hoy simbolos para eliminar", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AgrSimbPila_Click(object sender, EventArgs e)
        {
            AgregarSimbPila agregarSimbPila = new AgregarSimbPila(this, _automataPila);
            Enabled = false;
            agregarSimbPila.Location = new Point(270, 85);
            _principal._panel1.Controls.Add(agregarSimbPila);
            agregarSimbPila.BringToFront();
        }

        private void btn_ElimSimbPila_Click(object sender, EventArgs e)
        {
            if (_automataPila._simbEnPila.Count >= 2)
            {
                EliminarSimbPila eliminarSimbPila = new EliminarSimbPila(this, _automataPila);
                Enabled = false;
                eliminarSimbPila.Location = new Point(270, 85);
                _principal._panel1.Controls.Add(eliminarSimbPila);
                eliminarSimbPila.BringToFront();
            }
            else
            {
                MessageBox.Show("No hay simbolos para eliminar", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AgrEstado_Click(object sender, EventArgs e)
        {
            AgregarEstado agregarEstado = new AgregarEstado(this, _automataPila);
            Enabled = false;
            agregarEstado.Location = new Point(270, 85);
            _principal._panel1.Controls.Add(agregarEstado);
            agregarEstado.BringToFront();
        }

        private void btn_ElimEstado_Click(object sender, EventArgs e)
        {
            if (_automataPila._estados.Count > 0)
            {
                EliminarEstado eliminarEstado = new EliminarEstado(this, _automataPila);
                Enabled = false;
                eliminarEstado.Location = new Point(270, 85);
                _principal._panel1.Controls.Add(eliminarEstado);
                eliminarEstado.BringToFront();
            }
            else
            {
                MessageBox.Show("No hoy estados para eliminar", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AgrSimbConfg_Click(object sender, EventArgs e)
        {
            if (_automataPila._simbEnPila.Count < 2)
            {
                MessageBox.Show("Debe ingresar al menos un simbolo a simbolos en la pila\n" +
                    "para agregar a la configuracion inicial de la pila", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_automataPila._configuracionInicialPila.Count == _automataPila._simbEnPila.Count)
            {
                MessageBox.Show("Todos los simbolos de simbolos en pila han sido agregados\n" +
                    "a la configuracion inicial de la pila", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AgregarSimbConfgPila agregarSimbConfgPila = new AgregarSimbConfgPila(this, _automataPila);
            Enabled = false;
            agregarSimbConfgPila.Location = new Point(270, 85);
            _principal._panel1.Controls.Add(agregarSimbConfgPila);
            agregarSimbConfgPila.BringToFront();
        }

        private void btn_ElimSimbConfg_Click(object sender, EventArgs e)
        {
            if (_automataPila._configuracionInicialPila.Count >= 2)
            {
                EliminarSImbConfgPila eliminarSImbConfgPila = new EliminarSImbConfgPila(this, _automataPila);
                Enabled = false;
                eliminarSImbConfgPila.Location = new Point(270, 85);
                _principal._panel1.Controls.Add(eliminarSImbConfgPila);
                eliminarSImbConfgPila.BringToFront();
            }
            else
            {
                MessageBox.Show("No hay simbolos para eliminar", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_SelecEstadoInicial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = (string)cb_SelecEstadoInicial.SelectedItem;
            if (estado == null || estado.Equals("Seleccionar"))
            {
                _automataPila._estadoInicial = null;
                return;
            }
            _automataPila._estadoInicial = estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CambSimbFinSec cambSimbFinSec = new CambSimbFinSec(this, _automataPila);
            Enabled = false;
            cambSimbFinSec.Location = new Point(270, 85);
            _principal._panel1.Controls.Add(cambSimbFinSec);
            cambSimbFinSec.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CambSimbPilaVacia cambSimbPilaVacia = new CambSimbPilaVacia(this, _automataPila);
            Enabled = false;
            cambSimbPilaVacia.Location = new Point(270, 85);
            _principal._panel1.Controls.Add(cambSimbPilaVacia);
            cambSimbPilaVacia.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _automataPila = new AP();
            cargarListaDeSimbolosEntrada();
            cargarListaDeSimbolosPila();
            cargarListaEstados();
            cargarConfgInicialPila();
        }
    }
}
