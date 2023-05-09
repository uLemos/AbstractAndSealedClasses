using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAbstratasESeladas.Sealed
{
    public sealed class ProdutoRequest /*: RequestBase*/
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Categoria { get; set; }
    }
}
