﻿using System.ComponentModel.DataAnnotations;
using WebApi_Funcionarios.Enum;

namespace WebApi_Funcionarios.Models
{
    public class FuncionarioModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DepartamentoEnum Depatarmento { get; set; }
        public TurnoEnum Turno { get; set; }

        public bool Ativo { get; set; }
        public DateTime DataDeCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDeAlteracao { get; set; } = DateTime.Now.ToLocalTime();


    }
}
