using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiJobs.Models.TokenConfiguration
{
    public class TokenConfigurationModel
    {
        public string AccessToken { get; set; }

        public double ExpiresIn { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public UserModel userToken { get; set; }
    }
}
