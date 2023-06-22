using Escola.Banco;
using Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.UI
{
    public class ProfessorUi
    {
        public void AdicionarProfessor()
        {
            Console.WriteLine("Digite o nome do professor:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite o email do professor:");
            var email = Console.ReadLine();

            using (var context = new EscolaContext())
            {
                var professor = new Professor { Nome = nome, Email = email };
                context.Professores.Add(professor);
                context.SaveChanges();
            }

            Console.WriteLine("Professor adicionado com sucesso!");
        }

    }
}
