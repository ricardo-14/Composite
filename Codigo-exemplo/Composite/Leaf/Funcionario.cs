using Composite1.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite1.Leaf
{
    internal class Funcionario : HoraTrabalhada
    {
        public int Id { get; set; }
        public int Horas { get; set; }

        public override int GetHoraTrabalhada()
        {
            Console.WriteLine($"O Funcionário {Id}-{Nome} registrou {Horas} trabalhadas");
            return Horas;
        }
    }
}
