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
        /// id da receita médica
        /// </summary>
        [Key]
        public int id { get; set; }


        public string Medicamento { get; set; }
    }
}