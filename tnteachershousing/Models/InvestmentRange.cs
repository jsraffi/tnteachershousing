using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tnteachershousing.Models
{
    [Table("InvestmentRange")]
    public class InvestmentRange
    {
        public int InvestmentRangeID { get; set; }

        public string InvestmentRangeValue { get; set; }
    }
}