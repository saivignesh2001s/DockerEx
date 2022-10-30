using System.ComponentModel.DataAnnotations;

namespace Bankapp.Models
{
    public class Login
    {
        [Required]
        public string username
        {
            get;
            set;
        }
        [DataType(DataType.Password)]
        public string password
        {
            get;
            set;
        }
    }
}
