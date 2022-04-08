using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTarefas.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }

        [Required(ErrorMessage = "(0) é obrigatorio")]
        [StringLength(50, ErrorMessage = "Use Menos Caracteres")]
        public string Nome { get; set; }

        public string Data { get; set; }

        [Required(ErrorMessage = "(0) é obrigatorio")]
        [DataType(DataType.Time)]
        public string Horario { get; set; }
    }
}
