using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Entities
{
    public class RescueThumbnail
    {
        public int id { get; set; }
        public Rescue rescue { get; set; }
        public string refUrl { get; set; }
        public DateTime? createdAt { get; set; }
    }
}
