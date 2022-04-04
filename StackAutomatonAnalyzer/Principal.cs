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
    public partial class Principal : Form
    {
        public AP _autonataPila;
        public Panel _panel1;
        public Principal()
        {
            InitializeComponent();
            CenterToScreen();
            _panel1 = panel1;
            _autonataPila = new AP();
            IngresarDatosIniciales ingresarDatosIniciales = new IngresarDatosIniciales(this, _autonataPila);
            panel1.Controls.Add(ingresarDatosIniciales);
        }
    }
}
