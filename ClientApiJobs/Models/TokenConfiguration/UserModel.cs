using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiJobs.Models.TokenConfiguration
{
    public class UserModel
    {
        public Guid id { get; set; }
        public string email { get; set; }
        public IEnumerable<ClaimModel> Claims { get; set; }
    }
}
