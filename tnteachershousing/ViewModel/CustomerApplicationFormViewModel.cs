using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tnteachershousing.Models;

namespace tnteachershousing.ViewModel
{
    public class CustomerApplicationFormViewModel
    {   
        [Key]
        public int ApplicationID { get; set; }

        public string CustomerID { get; set; }

        [Required(ErrorMessage ="Please select a project your are interested in")]
        [Display(Name ="Current Projects")]
        public int ProjectRefID { get; set; }

        [Required(ErrorMessage = "Please select a investment range")]
        [Display(Name ="Investment Range")]
        public int InvestmentRangeRefID { get; set; }

        [Required(ErrorMessage ="Please enter your name")]
        [Display(Name ="Name of the Applicant")]
        public string  NameOfapplicant { get; set; }
        
        [Required(ErrorMessage = "Please enter Son of/ Wife of/ Guardian")]
        [Display(Name ="Son of/ Wife of/ Guardian")]
        public string SonOfWifeOfGuardian { get; set; }

        [Required(ErrorMessage ="Please enter Door or Flat No")]
        [Display(Name = "Door / Flat No")]
        public string DoorFlatNo { get; set; }

        [Required(ErrorMessage ="Please enter a street address")]
        public string Street { get; set; }

        [Required(ErrorMessage ="Please enter a area")]
        public string Area { get; set; }

        [Required(ErrorMessage ="Please enter a city")]
        public string City { get; set; }

        [Required(ErrorMessage ="Please enter state & pin code")]
        [Display(Name = "State & Pin Code")]
        public string StatePinCode { get; set; }

        [Required(ErrorMessage ="Please enter a country")]
        public string Country { get; set; }

        [Required(ErrorMessage ="Please enter a contact landlines")]
        [Display(Name = "Contact No(s) Landline")]
        public string ContactNoLandLines { get; set; }

        [Required(ErrorMessage ="Please enter a mobile no")]
        public string Mobile { get; set; }

        [Required(ErrorMessage ="Please enter a email id")]
        [Display(Name = "Email ID")]
        public string EmailID { get; set; }

        [Required(ErrorMessage ="Please select a project type")]
       
        [Display(Name ="Property Type")]
        public int ProjectTypeRefID { get; set; }

        [Display(Name = "Indian Resident")]
        public Boolean IndianResident { get; set; }

        [Display(Name = "Non-Resident Indian(NRI)")]
        public Boolean NonResidentIndian { get; set; }

        [Display(Name = "Goverment")]
        public Boolean Goverment { get; set; }

        [Display(Name = "Non-Goverment")]
        public Boolean NonGoverment { get; set; }
        public Boolean Salaried { get; set; }
        public Boolean Business { get; set; }
        public Boolean Others { get; set; }
        public Boolean Teaching{ get; set; }

        [Display(Name ="Non Teaching")]
        public Boolean NonTeaching { get; set; }
   
        public Boolean NRI { get; set; }

        [Display(Name ="Public")]
        public Boolean GeneralPublic { get; set; }

        [Required(ErrorMessage ="Please enter your teaching status")]
        [DataType(DataType.MultilineText)]
        public string TeachingStatus { get; set; }

        [Display(Name = "Own Purpose")]
        public Boolean OwnPurpose { get; set; }

        [Display(Name = "Rental Purpose")]
        public Boolean RentalPurpose { get; set; }


        [Display(Name = "Bank Loan")]
        public Boolean BankLoan { get; set; }

        [Display(Name = "Own Fund")]
        public Boolean OwnFund { get; set; }

        
        [Display(Name = "Photo ID Proof")]
        public Boolean PhotoIDProof { get; set; }


        [Display(Name = "Address Proof")]
        public Boolean AddressProof { get; set; }

        [Display(Name = "Office ID Card")]
        public Boolean OfficeIDCard { get; set; }

        [Display(Name = "Pan Card")]
        public Boolean PanCard { get; set; }

        [Display(Name = "Salary Slip")]
        public Boolean SalarySlip { get; set; }

        [Display(Name = "Bank Statement")]
        public Boolean BankStatement { get; set; }

        [Display(Name = "Form 16/ ITR")]
        public Boolean Form16ITR { get; set; }

        [Display(Name = "Employment Proof")]
        public Boolean EmploymentProof { get; set; }

        [Display(Name = "3 PP Size Photo")]
        public Boolean ThreePhotos { get; set; }

        public DateTime CreationDate { get; set; }


    }
}