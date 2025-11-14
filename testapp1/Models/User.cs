using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace testapp1.Models
{
    public class User
    {

        public int? Id  { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required , StringLength(200)]
        public string Address { get; set; }
    }
}


