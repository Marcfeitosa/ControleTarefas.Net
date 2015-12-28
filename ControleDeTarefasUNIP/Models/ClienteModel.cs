using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations
using System.Linq;
using System.Web;

namespace ControleDeTarefasUNIP.Models
{
    public class ClienteModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get;  set}
        [EmailAddress(ErrorMessage ="Email Inválido")]
        public string Email { get; set}
        [DataType(DataType.Date, ErrorMessage ="Data Inválida")]
        public DateTime DataNascimento { get; set; }



    }
}