using Escola.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Models
{
    public class Aluno : Pessoa
    {
        public List<Matricula> Matriculas { get; set; }



        public override void ExibirInformacoes()
        {
            try
            {
                Console.WriteLine("Alunos:");

                using (var context = new EscolaContext())
                {
                    var alunos = context.Alunos.ToList();

                    foreach (var aluno in alunos)
                    {
                        Console.WriteLine($"Nome do aluno: {aluno.Nome}");
                    }
                }
            }
            catch
            {
                Console.WriteLine("ERRO ao mostrar informações do aluno");
            }


        }



    }
}
