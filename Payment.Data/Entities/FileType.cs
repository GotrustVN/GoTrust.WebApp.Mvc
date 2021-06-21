using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Entities
{
    public class FileType
    {
        public string code { get; set; }
        public string name { get; set; }
        public string allowExtension { get; set; }
        public string note { get; set; }
    }
}
