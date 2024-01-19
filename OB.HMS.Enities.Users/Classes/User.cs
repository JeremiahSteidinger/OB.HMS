using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OB.HMS.Enities.Users.Classes
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<EmailAddress> EmailAddresses { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
