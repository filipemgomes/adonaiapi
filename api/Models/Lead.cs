using System;

namespace api.Models
{
    public class Lead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Consorcio { get; set; }
        public DateTime CreateDate { get; set; }
    }
}