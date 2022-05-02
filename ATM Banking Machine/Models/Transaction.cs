using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Banking_Machine.Models
{
    internal class Transaction
    {
        [Key]
        public int Id { get; set; }
        public int AccountId { get; set; }
#nullable enable
        public string AccNum { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public string TransactionDate { get; set; }
#nullable disable
        public Account Account { get; set; }

    }
}
