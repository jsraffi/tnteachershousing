using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tnteachershousing.Models
{
    [Table("Receipts")]
    public class Receipts
    {
        [Key, Column(Order = 0)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public long ReceiptID { get; set; }

        public string CustomerRefID { get; set; }

        public string Remarks { get; set; }
        public string CashChequeDD { get; set; }
        public string ChequeNumber { get; set; }
        public DateTime? ChequeDate { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
        public int Amount { get; set; }
        public DateTime CreationDate { get; set; }

        [Column(Order = 10)]
        [ForeignKey("CustAppForm")]
        public long ApplicationRefID {get;set;}

        public CustomerApplicationForm CustAppForm { get; set; }
    }
}