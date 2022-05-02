using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Banking_Machine.Models
{
    internal class Account
    {
        [Key]
        public int Id { get; set; }
#nullable enable
        public string AccNum { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Education { get; set; }
        public string Occupation { get; set; }
        public int PIN { get; set; }
        public int Balance { get; set; }
#nullable disable
        public ICollection<Transaction> Transactions { get; set; }
    }
}
