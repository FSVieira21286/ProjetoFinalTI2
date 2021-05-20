using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjetoFinalTI2.Models
{
    public class MedicamentoReceita
    {
        public MedicamentoReceita()
        {
        }
        /// <summary>
        /// PK para a tabela do relacionamento entre Receitas e Medicamentos 

        /// </summary>
        [Key]
        public int Id { get; set; }  //Primary Key do relacionamento

        /// <summary>
        /// FK para a Receita
        /// </summary>
        [ForeignKey(nameof(Receita))]
        public int ReceitaFK { get; set; }
        public Receita Receita { get; set; }

        /// <summary>
        /// FK para o Medicamento
        /// </summary>
        [ForeignKey(nameof(Medicamento))]  // [ForeignKey("Medicamento")]
        public int MedicamentoFK { get; set; }
        public Medicamento Medicamento { get; set; }

    }
}