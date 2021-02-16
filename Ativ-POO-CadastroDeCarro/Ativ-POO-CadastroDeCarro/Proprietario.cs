using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ_POO_CadastroDeCarro
{
    class Proprietario
    {
        public double CPF { get; set; }
        public String Nome { get; set; }

        public Endereco endereco;
        
        public Carro carro;
        public string DataNasc { get; set; }
        public string DataCompra { get; set; }
    }
}
