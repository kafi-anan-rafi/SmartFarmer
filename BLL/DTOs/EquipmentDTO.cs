using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class EquipmentDTO
    {
        public int Id { get; set; }
        public int SellerID { get; set; }
        public int Price { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }

    }
}
