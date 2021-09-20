using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimos.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class RepositoryLivroClienteEmprestimo: RepositoryBase<LivroClienteEmprestimo>, IRepositoryLivroClienteEmprestimo
    {
        public RepositoryLivroClienteEmprestimo(bool Saveschanges = true): base (Saveschanges)
        {

        }
    }
}
