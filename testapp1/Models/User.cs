using System.ComponentModel.DataAnnotations;

namespace testapp1.Models
{
    public class User
    {
        
        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
