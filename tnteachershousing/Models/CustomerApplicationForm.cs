using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tnteachershousing.Models
{   
    [Table("CustomerApplicationForm")]
    public class CustomerApplicationForm
    {
        [Key, Column(Order = 0)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ApplicationID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string CustomerID { get; set; }

        [ForeignKey("Projects")]
        public int ProjectRefID { get; set; }

        [ForeignKey("InvestmentRanges")]
        public int InvestmentRangeRefID { get; set; }
        public string  NameOfapplicant { get; set; }

        
        public string SonOfWifeOfGuardian { get; set; }

        
        public string DoorFlatNo { get; set; }
       
        public string Street { get; set; }

        public string Area { get; set; }

        public string City { get; set; }

        
        public string StatePinCode { get; set; }

        public string Country { get; set; }

        
        public string ContactNoLandLines { get; set; }

        public string Mobile { get; set; }

        public string EmailID { get; set; }

        [ForeignKey("ProjectTypes")]
        public int ProjectTypeRefID { get; set; }

        
        public Boolean IndianResident { get; set; }

        public Boolean NonResidentIndian { get; set; }

        
        public Boolean Goverment { get; set; }

        
        public Boolean NonGoverment { get; set; }
        public Boolean Salaried { get; set; }
        public Boolean Business { get; set; }
        public Boolean Others { get; set; }
        public Boolean Teaching{ get; set; }

        
        public Boolean NonTeaching { get; set; }
   
        public Boolean NRI { get; set; }

        public Boolean GeneralPublic { get; set; }

        [DataType(DataType.MultilineText)]
        public string TeachingStatus { get; set; }
        
        public Boolean OwnPurpose { get; set; }
        
        public Boolean RentalPurpose { get; set; }
        
        public Boolean BankLoan { get; set; }

        public Boolean OwnFund { get; set; }

        public Boolean PhotoIDProof { get; set; }

        public Boolean AddressProof { get; set; }

        public Boolean OfficeIDCard { get; set; }

        public Boolean PanCard { get; set; }
        
        public Boolean SalarySlip { get; set; }
        
        public Boolean BankStatement { get; set; }

        public Boolean Form16ITR { get; set; }

        
        public Boolean EmploymentProof { get; set; }

        
        public Boolean ThreePhotos { get; set; }

        public DateTime CreationDate { get; set; }

        public ProjectType ProjectTypes { get; set; }

        public Project Projects { get; set; }

        public InvestmentRange InvestmentRanges { get; set; }
             


    }
}