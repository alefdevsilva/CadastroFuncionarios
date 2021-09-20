﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LivrariaControleEmprestimos.DATA.Models
{
    [Table("Livro_Cliente_Emprestimo")]
    public partial class LivroClienteEmprestimo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idLivro")]
        public int? IdLivro { get; set; }
        [Column("idCliente")]
        public int? IdCliente { get; set; }
        [Column("dataEmprestimo", TypeName = "datetime")]
        public DateTime? DataEmprestimo { get; set; }
        [Column("dataDevolucao", TypeName = "datetime")]
        public DateTime? DataDevolucao { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(Cliente.LivroClienteEmprestimo))]
        public virtual Cliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdLivro))]
        [InverseProperty(nameof(Livro.LivroClienteEmprestimo))]
        public virtual Livro IdLivroNavigation { get; set; }
    }
}