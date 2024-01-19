using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OB.HMS.Enities.Users.Classes
{
    public class EmailAddress
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UserId { get; set; }
        public string Email { get; set; }
        public bool? Active { get; set; }
        
        public User User { get; set; }
    }
}
