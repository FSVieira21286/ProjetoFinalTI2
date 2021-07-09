using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinalTI2.Models { 

    /// <summary>
    /// Fotografias dos Médicos
    /// </summary>
    public class Fotografias
    {
        /// <summary>
        /// Identificador da fotografia
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do ficheiro com a fotografia do Médico
        /// </summary>
        public string Fotografia { get; set; }

        // criação da FK que referencia o Médico a quem a Foto pertence
        [ForeignKey(nameof(Medico))]
        [Display(Name = "Médico")]
        public int MedicoFK { get; set; }
        public Medico Medico { get; set; }
    }
}



