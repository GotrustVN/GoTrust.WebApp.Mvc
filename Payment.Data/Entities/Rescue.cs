using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Entities
{
    public class Rescue
    {
        public int id { get; set; }
        public User user { get; set; }
        public RescueType type { get; set; }
        public decimal lat { get; set; }
        public decimal lon { get; set; }
        public string address { get; set; }
        public DateTime? createdAt { get; set; }
        public string description { get; set; }
        public ICollection<RescueThumbnail> thumbnails { get; set; }
    }
}
