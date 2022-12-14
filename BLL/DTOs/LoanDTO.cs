using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class LoanDTO
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int FarmerId { get; set; }
        public string BorrowDate { get; set; }
        public string ToDate { get; set; }
        public string Status { get; set; }
    }
}
