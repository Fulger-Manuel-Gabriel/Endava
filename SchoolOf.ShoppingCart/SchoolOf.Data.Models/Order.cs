using SchoolOf.Data.Abstraction;

namespace SchoolOf.Data.Models
{
    public class Order : BaseEntityModel
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public int PhoneNo { get; set; }
        public decimal Total { get; set; }
    }
}
