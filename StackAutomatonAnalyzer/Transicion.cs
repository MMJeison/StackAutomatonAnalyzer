using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackAutomatonAnalyzer
{
    public class Transicion
    {
        public string _id { get; set; }
        public object[] _operacionSobrePila { get; set; }
        public string[] _operacionSobreEstado { get; set; }
        public string _operacionSobreEentrada { get; set; }

        public Transicion(string id)
        {
            _id = id;
            _operacionSobrePila = new object[2];
            _operacionSobreEstado = new string[2];
            _operacionSobreEentrada = string.Empty;
        }
        public Transicion(string id, object[] operacionSobrePila, string[] operacionSobreEstado, string operacionSobreEentrada)
        {
            _id = id;
            _operacionSobrePila = operacionSobrePila;
            _operacionSobreEstado = operacionSobreEstado;
            _operacionSobreEentrada = operacionSobreEentrada;
        }

        public int ejecutarTransicion(AP ap)
        {
            switch ((string)_operacionSobrePila[0])
            {
                case "Apilar": 
                    string[] simbs = (string[])_operacionSobrePila[1];
                    ap._pila.Push(simbs[0]);
                    break;
                case "Desapilar":
                    ap._pila.Pop();
                    break;
                case "Replace":
                    ap._pila.Pop();
                    foreach(string simb in (string[])_operacionSobrePila[1])
                    {
                        ap._pila.Push(simb);
                    }
                    break;
                case "Ninguna": break;
            }
            ap._estadoActual = _operacionSobreEstado[1];
            switch (_operacionSobreEentrada)
            {
                case "Avanzar":
                    return 1;
                case "Retener":
                    return 0;
            }
            return -1000;
        }
    }
    
}
