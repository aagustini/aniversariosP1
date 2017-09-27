using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniversariosBLL
{
    public class Aniversario
    {
        public int AniversarioId { get; set; }
        public String Nome { get; set; }
        [Display(Name ="Data de nascimento")]
        public DateTime DataAniversario { get; set; }
    }
}
