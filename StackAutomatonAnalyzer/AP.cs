using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackAutomatonAnalyzer
{
    public class AP
    {
        public List<string> _simbEntrada { get; set; }
        public List<string> _simbEnPila { get; set; }
        public Stack<string> _pila { get; set; }
        public Dictionary<string, Estado> _estados { get; set; }
        public string _simboloPilaVacia { get; set; }
        public string _simboloFinSecuencia { get; set; }
        public List<string> _configuracionInicialPila { get; set; }
        public string _estadoInicial { get; set; }
        public string _estadoActual { get; set; }
        public Dictionary<string, Transicion> _transiciones { get; set; }

        public AP()
        {
            _simbEntrada = new List<string>();
            _simbEnPila = new List<string>();
            _estados = new Dictionary<string, Estado>();
            _simboloPilaVacia = "#";
            _simboloFinSecuencia = "¬";
            _simbEntrada.Add(_simboloFinSecuencia);
            _simbEnPila.Add(_simboloPilaVacia);
            _pila = new Stack<string>();
            _configuracionInicialPila = new List<string>();
            _configuracionInicialPila.Add(_simboloPilaVacia);
            _estadoInicial = null;
            _estadoActual = null;
            _transiciones = new Dictionary<string, Transicion>();
            Transicion rechace = new Transicion("R", new object[] { "Rechazo", new string[] { "" } },
                new string[] { "Rechazo", "" }, "Rechazo");
            _transiciones.Add("R", rechace);
            Transicion acepte = new Transicion("A", new object[] { "Apcepte", new string[] { "" } },
                new string[] { "Acepte", "" }, "Acepte");
            _transiciones.Add("A", acepte);
        }
        public void establecerConfInicialPila()
        {
            _pila.Clear();
            foreach(string simbolo in _configuracionInicialPila)
            {
                _pila.Push(simbolo);
            }
        }
        public Boolean evaluarEntrada(string entrada)
        {
            entrada += _simboloFinSecuencia;
            char[] simbsEntrada = entrada.ToCharArray();
            _estadoActual = _estadoInicial;
            establecerConfInicialPila();
            int i = 0;
            while (true)
            {
                string simbolo = simbsEntrada[i].ToString();
                Transicion t = _estados[_estadoActual]._transiciones[(_pila.Peek(), simbolo)];
                if(t._id.Equals("A"))
                {
                    if (simbolo.Equals(_simboloFinSecuencia))
                    {
                        i = -1;
                        MessageBox.Show("¡Enhorabuena la hilera ha sido reconociada!", "Informacion",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    if (!simbolo.Equals(_simboloFinSecuencia))
                    {
                        i = -2;
                        MessageBox.Show("La hilera NO ha sido reconocida -", "Informacion",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                if (t._id.Equals("R") || simbolo.Equals(_simboloFinSecuencia))
                {
                    i = -2;
                    MessageBox.Show("La hilera NO ha sido reconocida", "Alerta",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                int n = t.ejecutarTransicion(this);
                i += n;
            }
            if (i == -1) return true;
            return false;
        }
    }
}
