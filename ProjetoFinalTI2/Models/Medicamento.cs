using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalTI2.Models
{
    public class Medicamento
    {

        /// <summary>
        /// id do medicamento
        /// </summary>
        [Key]
        public int MedicId { get; set; }


        /// <summary>
        /// nome do medicamento
        /// </summary>
        [Display(Name = "Nome do Medicamento")]
        public String Nome { get; set; }

        /// <summary>
        /// preço do medicamento
        /// </summary>
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        public virtual ICollection<MedicamentoReceita> MedicamentoReceita { get; set; }

        public Medicamento()
        {
            MedicamentoReceita = new HashSet<MedicamentoReceita>();
        }


    }
}
