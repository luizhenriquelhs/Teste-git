using System;
using System.Collections.Generic;
using System.Text;

namespace Secao6
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
}
