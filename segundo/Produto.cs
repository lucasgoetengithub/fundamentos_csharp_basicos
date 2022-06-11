using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundo {
    class Produto {
        public string Nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEmEstoque() {
            return preco * quantidade;
        }


    }
}
