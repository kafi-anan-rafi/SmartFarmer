using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RatingDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int FarmerId { get; set; }
        public int RatingPoint { get; set; }
    }
}
