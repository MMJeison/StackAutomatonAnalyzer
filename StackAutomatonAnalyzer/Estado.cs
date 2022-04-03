using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAutomatonAnalyzer
{
    public class Estado
    {
        public string _nombre { get; set; }
        public Dictionary<(string, string), Transicion> _transiciones { get; set; }
        public Estado(string nombre)
        {
            _nombre = nombre;
            _transiciones = new Dictionary<(string, string), Transicion>();
        }
    }
}
