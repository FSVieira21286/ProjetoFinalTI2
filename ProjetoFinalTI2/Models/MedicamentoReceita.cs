using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinalTI2.Models
{
    public class MedicamentoReceita
    {


        /// <summary>
        /// Id do download (PK).
        /// </summary>
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// Qual o ficheiro do qual foi feito download (obrigatório)(FK para Ficheiro).
        /// </summary>
        [Required]
        [ForeignKey(nameof(Receita))]
        public int ReceitaFk { get; set; }
        public Receita Receita { get; set; }


        /// <summary>
        /// Quem fez o download do ficheiro (obrigatório)(FK para Utilizador).
        /// </summary>
        [Required]
        [ForeignKey(nameof(Medicamento))]
        public int MedicamentoFk { get; set; }
        public Medicamento Medicamento { get; set; }
    }
}
