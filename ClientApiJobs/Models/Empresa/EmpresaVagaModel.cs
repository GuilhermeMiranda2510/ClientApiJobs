using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiJobs.Models.Empresa
{
    public class EmpresaVagaModel
    {
        public bool success { get; set; }

        public EmpresaConfigurationModel data { get; set; }
    }
}
