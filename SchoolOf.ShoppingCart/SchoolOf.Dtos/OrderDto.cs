using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOf.Dtos
{
    public class OrderDto
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public int PhoneNo { get; set; }
        public decimal Total { get; set; }
    }
}
