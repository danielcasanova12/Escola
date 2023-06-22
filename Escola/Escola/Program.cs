using Escola.Models;
using Escola.UI;
using System.ComponentModel.DataAnnotations;

var alunoUI = new AlunoUI();
var professorUi = new ProfessorUi();
var cursoUi = new CursoUI();
var profesorUi = new ProfessorUi();
var professor = new Professor { };
var aluno = new Aluno();
var notaUi = new NotasUI();
while (true)
{
    Console.WriteLine("Sistema de Gerenciamento de Escolas");
    Console.WriteLine("Selecione uma opção:");
    Console.WriteLine("1. Adicionar aluno");
    Console.WriteLine("2. Adicionar professor");
    Console.WriteLine("3. Adicionar curso");
    Console.WriteLine("4. Matricular aluno em curso");
    Console.WriteLine("5. Exibir informações");
    Console.WriteLine("6. Gerenciar Notas");
    Console.WriteLine("7. Sair");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Clear();
            alunoUI.AdicionarAluno();
            break;
        case "2":
            Console.Clear();
            profesorUi.AdicionarProfessor();
            break;
        case "3":
            Console.Clear();
            cursoUi.AdicionarCurso();
            break;
        case "4":
            Console.Clear();
            cursoUi.MatricularAlunoEmCurso();
            break;
        case "5":
            while (true)
            {
                Console.WriteLine("Exibir informações");
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1. Exibir informações de alunos");
                Console.WriteLine("2. Exibir informações de professores");
                Console.WriteLine("3. Voltar");

                var opcaoExibir = Console.ReadLine();

                switch (opcaoExibir)
                {
                    case "1":
                        aluno.ExibirInformacoes();
                        break;
                    case "2":
                        
                        professor.ExibirInformacoes();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                if (opcaoExibir == "3")
                {
                    break;
                }
            }
            break;
        case "6":
            Console.Clear();
            Console.WriteLine("Menu de Gerenciamento de Notas:");

            while (true)
            {
                Console.WriteLine("1. Adicionar Nota");
                Console.WriteLine("2. Alterar Nota");
                Console.WriteLine("0. Voltar ao menu principal");

                string opcaoNotas = Console.ReadLine();

                switch (opcaoNotas)
                {
                    case "1":
                        notaUi.AdicionarNota();
                        break;
                    case "2":
                        notaUi.AlterarNota();   
                        break;
                    case "0":
                        Console.WriteLine("Voltando ao menu principal...");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            break;
        case "7":
            Console.Clear();
            Console.WriteLine("Sistema finalizado");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    if (opcao == "7")
    {
        break;
    }
}