using Escola.Banco;
using Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.UI
{
    public class AlunoUI
    {
        public void AdicionarAluno()
        {
            try 
            { 
                Console.WriteLine("Digite o nome do aluno:");
                var nome = Console.ReadLine();

                Console.WriteLine("Digite o email do aluno:");
                var email = Console.ReadLine();

                using (var context = new EscolaContext())
                {
                    var aluno = new Aluno { Nome = nome, Email = email };
                    context.Alunos.Add(aluno);
                    context.SaveChanges();
                }

                Console.WriteLine("Aluno adicionado com sucesso!");
            }
            catch 
            {
                Console.WriteLine("Erro ao adicionar aluno");
            }
        }

        // Função para adicionar notas à tabela Matricula




    }
}
