using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tnteachershousing.Models
{
    [Table("CustApplicationReport")]
    public class CustApplicationReport
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ApplicationID { get; set; }
             
        public string CustomerID { get; set; }

        public string NameOfapplicant { get; set; }

        public string SonOfWifeOfGuardian { get; set; }

        public string DoorFlatNo { get; set; }

        public string Street { get; set; }

        public string Area { get; set; }

        public string City { get; set; }

        public string StatePinCode { get; set; }

        public string Country { get; set; }

        public string Mobile { get; set; }

        public string EmailID { get; set; }

        public bool IndianResident { get; set; }

        public bool NonResidentIndian { get; set; }

        public bool Goverment { get; set; }

        public bool NonGoverment { get; set; }

        public bool GeneralPublic { get; set; }

        public string TeachingStatus { get; set; }

        public bool OwnPurpose { get; set; }

        public bool RentalPurpose { get; set; }

        public bool BankLoan { get; set; }

        public bool OwnFund { get; set; }

        public bool PhotoIDProof { get; set; }

        public bool AddressProof { get; set; }

        public bool OfficeIDCard { get; set; }

        public bool PanCard { get; set; }

        public bool SalarySlip { get; set; }

        public bool BankStatement { get; set; }

        public bool Form16ITR { get; set; }

        public bool EmploymentProof { get; set; }

        public bool ThreePhotos { get; set; }

        public string ContactNoLandLines { get; set; }

        public bool Salaried { get; set; }

        public bool Business { get; set; }

        public bool Others { get; set; }

        public bool NonTeaching { get; set; }

        public bool NRI { get; set; }

        public bool Teaching { get; set; }

        public DateTime CreationDate { get; set; }

        public string InvestmentRangeValue { get; set; }

        public string ProjectName { get; set; }

        public string ProjectTypeName { get; set; }
    }
}