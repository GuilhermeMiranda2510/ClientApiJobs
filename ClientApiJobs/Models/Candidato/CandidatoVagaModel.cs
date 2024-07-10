using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiJobs.Models.Candidato
{
    public   class CandidatoVagaModel
    {
        public Guid Id { get; set; }
        // public Guid UserID { get; set; }
        public DateTime DataCandidatura { get; set; }
        public Guid VagaID { get; set; }
        public DateTime DataAbertura { get; set; }
        public string TituloVaga { get; set; }
        public string DescricaoVaga { get; set; }
        public string SalarioVaga { get; set; }
        public string Empresa { get; set; }
        public string EmailCandidato { get; set; }
    }
}
