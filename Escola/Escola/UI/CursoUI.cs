using Escola.Banco;
using Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.UI
{
    public class CursoUI
    {
        public void AdicionarCurso()
        {
            try
            {
                Console.WriteLine("Digite o nome do curso:");
                var nome = Console.ReadLine();

                Console.WriteLine("Digite o ID do professor responsável pelo curso:");
                var professorId = int.Parse(Console.ReadLine());

                using (var context = new EscolaContext())
                {
                    var curso = new Curso { Nome = nome, ProfessorId = professorId };
                    context.Cursos.Add(curso);
                    context.SaveChanges();
                }

                Console.WriteLine("Curso adicionado com sucesso!");
            }
            catch
            {
                Console.WriteLine("Erro ao adicionar Curso");
            }

        }
        public void MatricularAlunoEmCurso()
        {
            try
            {

                Console.WriteLine("Digite o ID do aluno:");
                var alunoId = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o ID do curso:");
                var cursoId = int.Parse(Console.ReadLine());

                using (var context = new EscolaContext())
                {
                    var matricula = new Matricula { AlunoId = alunoId, CursoId = cursoId };
                    context.Matriculas.Add(matricula);
                    context.SaveChanges();
                }

                Console.WriteLine("Aluno matriculado com sucesso!");

            }
            catch
            {
                Console.WriteLine("Erro ao adicionar a Matricola");
            }
        }



    }
}
