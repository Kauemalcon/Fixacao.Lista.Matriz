using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixacao.Lista.Matriz
{
    class Funcionairos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }


        public Funcionairos(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double porcenagem)
        {
            Salario += Salario * porcenagem / 100;
        }
        public override string ToString()
        {
            return Id + "," + Nome + "," + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
