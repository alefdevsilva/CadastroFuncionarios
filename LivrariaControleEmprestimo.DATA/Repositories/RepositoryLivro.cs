using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimos.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class RepositoryLivro: RepositoryBase<Livro>, IRepositoryLivro
    {
        public RepositoryLivro(bool SavesChanges = true): base (SavesChanges)
        {

        }
    }
}
