using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiJobs.Models.Empresa
{
    public class EmpresaConfigurationModel
    {
        public Guid Id { get; set; }
        public Guid? UserID { get; set; }

        public DateTime DataCadastro { get; set; }

        public string TituloVaga { get; set; }

        public string DescricaoVaga { get; set; }

        public string StatusVaga { get; set; }

        public string SalarioVaga { get; set; }

        public string Empresa { get; set; }
    }
}
