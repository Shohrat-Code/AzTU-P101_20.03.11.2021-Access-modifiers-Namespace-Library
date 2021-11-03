using AccModNSLib.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccModNSLib.Models
{
    class Social
    {
        public string Name { get; set; }
        internal string Surname { get; set; }

        protected private int Age;
        public Social()
        {
        }
    }
}
