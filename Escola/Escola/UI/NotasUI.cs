using Escola.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.UI
{
    public class NotasUI
    {



        public void AdicionarNota()
        {
           try
            {
                Console.WriteLine("Informe o ID do aluno:");
                int alunoId = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o ID do curso:");
                int cursoId = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a nota:");
                double nota = double.Parse(Console.ReadLine());
                while(nota <= 0 || nota >= 10)
                {
                    Console.WriteLine();
                    Console.WriteLine("Erro ");
                    Console.WriteLine("digite uma nota entre 1 e 10");
                    Console.WriteLine();
                    Console.WriteLine("Informe a nota:");
                    nota = double.Parse(Console.ReadLine());
                }
                
                using (var context = new EscolaContext())
                {
                    var matricula = context.Matriculas.FirstOrDefault(m => m.AlunoId == alunoId && m.CursoId == cursoId);

                    if (matricula != null)
                    {
                        matricula.Nota = nota;
                        context.SaveChanges();
                        Console.WriteLine("Nota adicionada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Matrícula não encontrada!");
                    }
                }
            } catch 
            {
                Console.WriteLine("Erro ao adicionar nota");
            }
        }

        // Função para alterar uma nota na tabela Matricula
        public void AlterarNota()
        {
            try
            {
                Console.WriteLine("Informe o ID do aluno:");
                int alunoId = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o ID do curso:");
                int cursoId = int.Parse(Console.ReadLine());

                using (var context = new EscolaContext())
                {
                    var matricula = context.Matriculas.FirstOrDefault(m => m.AlunoId == alunoId && m.CursoId == cursoId);

                    if (matricula != null)
                    {
                        Console.WriteLine($"A nota atual é: {matricula.Nota}");

                        double novaNota;
                        do
                        {
                            Console.WriteLine("Informe a nova nota (entre 0 e 10):");
                            novaNota = double.Parse(Console.ReadLine());
                        } while (novaNota <= 0 || novaNota >= 10);

                        matricula.Nota = novaNota;
                        context.SaveChanges();

                        Console.WriteLine("Nota alterada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Matrícula não encontrada!");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Erro ao Alterar notas");
            }
        }

    }
}
