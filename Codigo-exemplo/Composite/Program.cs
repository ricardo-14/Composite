using Composite1.Composite;
using Composite1.Leaf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Organizacao organizacao = new Organizacao { Nome = "ProWay"};

            Organizacao departamentoTI = new Organizacao { Nome = "TI" };
            departamentoTI.Add(new Funcionario { Id = 1, Nome = "João", Horas = 8 });
            departamentoTI.Add(new Funcionario { Id = 2, Nome = "Maria", Horas = 7 });
            departamentoTI.Add(new Funcionario { Id = 3, Nome = "Pedro", Horas = 8 });

            Organizacao departamentoContabilidade = new Organizacao { Nome = "Contabilidade" };
            departamentoContabilidade.Add(new Funcionario { Id = 4, Nome = "Marcos", Horas = 6 });
            departamentoContabilidade.Add(new Funcionario { Id = 5, Nome = "José", Horas = 7 });

            organizacao.Add(departamentoTI);
            organizacao.Add(departamentoContabilidade);
            organizacao.GetHoraTrabalhada();

            Console.ReadKey();
        }
    }
}
