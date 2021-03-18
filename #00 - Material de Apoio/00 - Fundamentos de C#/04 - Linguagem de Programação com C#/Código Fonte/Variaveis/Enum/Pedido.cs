using System;

namespace Enum
{
    public class Pedido 
    {
        public int Numero { get; set; }
        public DateTime DataHora { get; set; }
        public ESituacao Situacao { get; set; }
    }
}