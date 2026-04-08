using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviewApi.Domain.Entities
{
    public class Review
    {
        public string ReviewId { get; set; }
        public string ReviewComment { get; set; }
        public int UserRating { get; set; }
        public DateTime ReviewDate { get; set; }
        public bool Status { get; set; }
    }
}
