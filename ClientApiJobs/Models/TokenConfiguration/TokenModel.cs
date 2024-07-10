using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiJobs.Models.TokenConfiguration
{
    public class TokenModel
    {
        public bool success { get; set; }

        public TokenConfigurationModel data { get; set; }
    }
}
