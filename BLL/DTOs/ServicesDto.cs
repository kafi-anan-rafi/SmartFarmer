using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ServicesDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ServiceType { get; set; }
        public int ProviderId { get; set; }
        public DateTime Date { get; set; }
        public int Rate { get; set; }
        public int Bill { get; set; }
    }
}
