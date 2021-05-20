using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalTI2.Models
{
    public class Medico
    {


        public Medico()
        {
            // inicializar a lista de Fotografias dos Medicos
            ListasDeFotografias = new HashSet<Fotografias>();
        }


        /// <summary>
        /// id do médico
        /// </summary>
        /// 
        [Key]
        public int MedicoId { get; set; }

        /// <summary>
        /// nome do medico
        /// </summary>
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public String Nome { get; set; }


        /// <summary>
        /// Lista das Fotografias dos Médicos
        /// </summary>

        public ICollection< Fotografias> ListasDeFotografias { get; set; }

        // ##########################################################

        /// <summary>
        /// especialidade
        /// </summary>
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public String Especialidade { get; set; }


    }
} 