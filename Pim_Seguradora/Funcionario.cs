using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_Seguradora
{
    internal class Funcionario : Usuario // A classe Funcionário está herdando todas as propriedades da classe Usuário
    {
        // Declaração dos atributos da classe Funcionário
        public string NomeFunc { get; set; }
        public string Departamento { get; set; }
        public int NIdentificacao { get; set; }

        // Método Cadastrar Cliente
        public void CadastrarCliente()
        {

        }

        // Método Atualizar Cadastro
        public void AtualizarCadastro()
        {

        }
    }
}
