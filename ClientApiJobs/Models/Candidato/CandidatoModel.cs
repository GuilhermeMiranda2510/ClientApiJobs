using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiJobs.Models.Candidato
{
    public class CandidatoModel
    {
        public bool success {  get; set; }
        public Guid Id { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public Guid VagaId { get; set; }
        public Guid UserId { get; set; }
    }
}
