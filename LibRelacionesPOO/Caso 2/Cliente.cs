using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso_2
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
