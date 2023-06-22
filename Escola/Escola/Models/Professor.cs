using Escola.Banco;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Models
{
    public class Professor : Pessoa
    {
        public List<Curso> Cursos { get; set; }



        public override void ExibirInformacoes()
        {
            try
            {
                using (var context = new EscolaContext())
                {
                    var professores = context.Professores
                        .Include(p => p.Cursos)
                        .ToList();

                    if (professores.Count == 0)
                    {
                        Console.WriteLine("Nenhum professor encontrado");
                        return;
                    }

                    foreach (var professor in professores)
                    {
                        Console.WriteLine($"Cursos ministrados pelo professor {professor.Nome}:");
                        foreach (var curso in professor.Cursos)
                        {
                            Console.WriteLine(curso.Nome);
                        }
                        Console.WriteLine();
                    }
                }

            }
            catch
            {
                Console.WriteLine("Erro ao exibir as informaçoes do Professor");
            }

        }

    }
}
