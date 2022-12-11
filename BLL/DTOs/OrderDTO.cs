using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public System.DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
    }
}
