using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tnteachershousing.ViewModel
{   
    public class ReceiptsViewModel
    {
        [Key]
        public long ReceiptID { get; set; }

        [Display(Name ="Customer ID")]
        public string CustomerRefID { get; set; }

        [Required(ErrorMessage ="Please enter payment details")]
        [Display(Name ="Payments towards")]
        public string Remarks { get; set; }

        [Required(ErrorMessage ="Plese enter the type of transactio")]
        [Display(Name ="Cash or Cheque or DD")]
        public string CashChequeDD { get; set; }

        [Display(Name ="Cheque No")]
        public string ChequeNumber { get; set; }

        [DisplayFormat(NullDisplayText ="")]
        [Display(Name ="Cheque Dated")]
        public DateTime? ChequeDate { get; set; }

        [Display(Name ="Name of the bank")]
        public string BankName { get; set; }

        [Display(Name ="Bank's Branch")]
        public string BankBranch { get; set; }

        [Range(1,int.MaxValue,ErrorMessage ="Please enter a positive numeric value")]
        [Required(ErrorMessage ="Please enter postive numeric value")]
        public int Amount { get; set; }
        
        [Display(Name ="Receipt Date")]
        [Required(ErrorMessage ="Please enter a date in dd/mm/yyyy format")]
        public DateTime CreationDate { get; set; }

        public long ApplicaionRefID { get; set; }

       
    }
}