using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity

namespace ControleDeTarefasUNIP.Models.ExemploDBCOntext
{
    public class DBContextExemplo : DbContext
    {
        public DBContextExemplo()
            : base("Exemplo")
        {
        }
        public DbSet<ClienteModel> Clientes { get; set; }
    }
}