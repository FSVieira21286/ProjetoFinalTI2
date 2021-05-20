using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalTI2.Models
{
    public class Receita
    {
        /// <summary>
        /// Id da receita médica
        /// </summary>
        [Key]
        public int ReceitaId { get; set; }

        /// <summary>
        /// Preço total da receita médica
        /// </summary>
        [Display(Name = "Preço do(s) medicamento(s) total")]
        public decimal Preco { get; set; }


        ///<sumary>
        /// Data de quando a receita médica foi receitada
        /// </sumary
        public DateTime ReceitaData { get; set; }


        //---------------------------





        /// <summary>
        /// FK para o médico que receitou a receita médica
        /// </summary>
        [ForeignKey(nameof(Medico))]
        [Display(Name = "Médico")]
        public int MedicoIDFK { get; set; }
        public Medico MedicoID { get; set; }



        /// <summary>
        /// FK do utente da receita médica
        /// </summary>
        [ForeignKey(nameof(Utente))]
        public int UtenteIDFK { get; set; }
        public int UtenteID { get; set; }

        //lista de medicamentos receitas




        /// <summary>
        /// FK do(s) medicamentos receitados
        /// </summary>
        /// [ForeignKey(nameof(Medicamento))]
        /// public int MedicIDFK { get; set; }
        ///public int MedicID { get; set; }





    }
}
