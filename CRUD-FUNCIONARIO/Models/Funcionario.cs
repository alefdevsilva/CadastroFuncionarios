using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_FUNCIONARIO.Models
{
    public class Funcionario
    {
        public Guid Id { get; set; }

        [Required]
        public string Nome  { get; set; }
        [Required]
        public int Idade { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string CPF { get; set; }

        public Funcionario()
        {
            Id = Guid.NewGuid();

        }
    }
}
