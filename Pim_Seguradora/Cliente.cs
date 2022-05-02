using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix_Seguradora
{
    internal class Cliente
    {
        // Declaração dos atributos da classe Cliente
        public string NomeCli { get; set; }
        public int Cpf { get; set; }
        public int DataNascimento { get; set; }
        public string Endereco { get; set; }
        public int NumeroCasa { get; set; }
        public string Bairro { get; set; }
        public int Cep { get; set; }
        public string Estado { get; set; }

        // Método Acionar Seguro
        public void AcionarSeguro()
        {

        }
    }
}
