namespace tnteachershousing.EFPoco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Receipt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ReceiptID { get; set; }

        [Required]
        [StringLength(13)]
        public string CustomerRefID { get; set; }

        [Required]
        [StringLength(100)]
        public string Remarks { get; set; }

        [Required]
        [StringLength(500)]
        public string CashChequeDD { get; set; }

        [StringLength(500)]
        public string ChequeNumber { get; set; }

        [StringLength(500)]
        public string ChequeDate { get; set; }

        [StringLength(500)]
        public string BankName { get; set; }

        [StringLength(500)]
        public string BankBranch { get; set; }

        public int Amount { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
