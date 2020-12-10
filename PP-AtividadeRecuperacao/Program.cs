using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_AtividadeRecuperacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli = new Cliente
            {
                Codigo = 1,
                Nome = "CLIENTE FULANO",
                Endereco = "RUA TESTE 1",
                Cnpj = "99.999.999/9999-99",
                Ie = "123.456",
                Fantasia = "FANTASIA TESTE",
                Segmento = "Comércio"
            };

            Vendedor vend = new Vendedor
            {
                Codigo = 2,
                Nome = "VENDEDOR CICLANO",
                Endereco = "RUA TESTE 2",
                Cpf = "999.999.999-99",
                Rg = "654.321",
                Apelido = "APELIDO TESTE",
                Comissao = 10
            };


            Console.WriteLine("Cliente: " + cli.GetConsultaNome());
            Console.WriteLine("CNPJ: " + cli.GetConsultaCNPJ() + " - IE: " + cli.Ie);
            Console.WriteLine("Fantasia: " + cli.Fantasia);
            Console.WriteLine("Segmento: " + cli.GetConsultaSegmento());
            Console.WriteLine("Pessoa " + cli.GetTipoPessoa());
            Console.WriteLine("");

            Console.WriteLine("Vendedor: " + vend.GetConsultaNome());
            Console.WriteLine("CPF: " + vend.GetConsultaCPF() + " - RG: " + vend.Rg);
            Console.WriteLine("Apelido: " + vend.Apelido);
            Console.WriteLine("Comissão: " + vend.GetConsultaComissao());
            Console.WriteLine("Pessoa " + vend.GetTipoPessoa());

            Console.ReadLine();
        }
    }

    public class Pessoa
    {
        private int codigo;
        private string nome;
        private string endereco;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }

        public string GetConsultaNome()
        {
            return Nome;
        }
    }

    public class Fisica : Pessoa
    {
        private string cpf;
        private string rg;
        
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }

        public string GetConsultaCPF()
        {
            return Cpf;
        }
        public string GetTipoPessoa()
        {
            return "Física";
        }
    }

    public class Juridica : Pessoa
    {
        private string cnpj;
        private string ie;

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Ie { get => ie; set => ie = value; }
        
        public string GetConsultaCNPJ()
        {
            return Cnpj;
        }

        public string GetTipoPessoa()
        {
            return "Jurídica";
        }
    }

    public class Cliente : Juridica
    {
        private string fantasia;
        private string segmento;

        public string Fantasia { get => fantasia; set => fantasia = value; }
        public string Segmento { get => segmento; set => segmento = value; }

        public string GetConsultaSegmento()
        {
            return Segmento;
        }
    }

    public class Vendedor : Fisica
    {
        private string apelido;
        private int comissao;

        public string Apelido { get => apelido; set => apelido = value; }
        public int Comissao { get => comissao; set => comissao = value; }

        public int GetConsultaComissao()
        {
            return Comissao;
        }
    }
}
