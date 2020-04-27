
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Herença
{
    class Program
    {
        static void Main(string[] args)
        {
            Fornecedor f = new Fornecedor("Guilherme Pereira", "Monsenhor Paulo", "(35) 3263-2525");
            f.Valor_Credito = 2500.00;
            f.Valor_Divida = 316.00;
            Console.WriteLine("Fornecedor: " + f.Nome + "\nTelefone: " + f.Telefone + "\nEndereço: " + f.Endereco + "\nsaldo de: R$ " + f.Saldo());

            Colaborador c = new Colaborador("Victor Bento", "João Pessoa", "(21) 3263-9000");
            c.ID_Setor = 30;
            c.Salario_Base = 26000;
            c.Impostos = 1;
            Console.WriteLine("\nColaborador: " + c.Nome + "\nTelefone: " + c.Telefone + "\nEndereço: " + c.Endereco + "\nsaldo de: R$ " + c.Salario());

            Adm a = new Adm("Hugo Massote", " São Paulo ", "(35) 6525-6563");
            a.ID_Setor = 30;
            a.Salario_Base = 2000.00;
            a.Impostos = 2;
            a.AjudadeCusto = 314.00;
            Console.WriteLine("\nAdm: " + a.Nome + "\nTelefone: " + a.Telefone + "\nEndereço: " + a.Endereco + "\nsaldo de: JP¥ " + a.Salario());

            Operario o = new Operario("Alvaro Lemes", " Salvado", "(35) 2547-6972");
            o.ID_Setor = 30;
            o.Salario_Base = 5000.00;
            o.Impostos = 2;
            o.ValorProducao = 100;
            o.Comissao = 3;
            Console.WriteLine("\nOperario: " + o.Nome + "\nTelefone: " + o.Telefone + "\nEndereço: " + o.Endereco + "\nsaldo de: R$ " + o.Salario());

            Vendedores v = new Vendedores("Luis Gustavo", "Londres", "(1) 25474-7942");
            v.ID_Setor = 30;
            v.Salario_Base = 500000.00;
            v.Impostos = 2;
            v.ValorVendas = 1028.00;
            v.Comissao = 5;
            Console.WriteLine("\nVendedor: " + v.Nome + "\nTelefone: " + v.Telefone + "\nEndereço: " + v.Endereco + "\nsaldo de: $ " + v.Salario());
            Console.ReadKey();
        }
    }
}