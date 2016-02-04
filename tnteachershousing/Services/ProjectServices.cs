using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tnteachershousing.ViewModel;

namespace tnteachershousing.Services
{
    public class ProjectServices : IProjectServices
    {
        private ModelStateDictionary _modelstate;

        public ModelStateDictionary ModelState
        {
            get
            {
                return this._modelstate;
            }

            set
            {
                this._modelstate = value;
            }
        }

        public bool validateCustAppForm(CustomerApplicationFormViewModel custappviewmodel)
        {
            bool validate = true;
            if (custappviewmodel.IndianResident == false && custappviewmodel.NonResidentIndian == false)
            {
                ModelState.AddModelError("IndianResident", "Please select a appropriate value");
                validate = false;
            }
            if (custappviewmodel.Goverment == false && custappviewmodel.NonGoverment == false)
            {
                ModelState.AddModelError("Goverment", "Please select a appropriate value");
                validate = false;
            }
            if (custappviewmodel.Salaried == false && custappviewmodel.Business == false && custappviewmodel.Others == false)
            {
                ModelState.AddModelError("Salaried", "Please select a appropriate value");
                validate = false; ;

            }
            if (custappviewmodel.Teaching == false && custappviewmodel.NonTeaching == false && custappviewmodel.NRI == false && custappviewmodel.GeneralPublic == false)
            {
                ModelState.AddModelError("Teaching", "Please select a appropriate value");
                validate = false;
            }
            if (custappviewmodel.OwnPurpose == false && custappviewmodel.RentalPurpose == false)
            {
                ModelState.AddModelError("OwnPurpose", "Please select a appropriate value");
                validate = false;
            }
            if (custappviewmodel.BankLoan == false && custappviewmodel.OwnFund == false)
            {
                ModelState.AddModelError("BankLoan", "Please select a appropriate value");
                validate = false;
            }
            return validate;
        }
    }

    public interface IProjectServices
    {
        ModelStateDictionary ModelState { get; set; }

        bool validateCustAppForm(CustomerApplicationFormViewModel custappformviewmodel);
    }
}