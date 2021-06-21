using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Entities
{
    public class FileImport : BaseEntity
    {
        public string code { get; set; }
        public string user { get; set; }
        public FileType type { get; set; }
        public string fileName { get; set; }
        public string savePath { get; set; }
    }
}
