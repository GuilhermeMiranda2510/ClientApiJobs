using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiJobs.Business
{
    public class Configuiration
    {
        public static string WriteLog()
        {
            return ConfigurationManager.AppSettings["WriteLog"];
        }
    }
}
