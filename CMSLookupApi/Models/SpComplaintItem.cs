using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSLookupApi.Models
{
    public class SpComplaintItem
    {
        [Key]
        public int  RC {get; set;}
        public int EntitypeIDAgainst { get; set; }
        public int EntityIDAgainst { get; set; }
        public int BenefitoptionIDAgainst { get; set; }
        public int EntityTypeIDMember { get; set; }
        public int EntityIDMember { get; set; }
        public string MembershipNrMember { get; set; }
        public string PracticeNameMember { get; set; }
        public string FNameMember { get; set; }
        public string LNameMember { get; set; }
        public string TitleIDMember { get; set; }
        public string PostalAdressMember { get; set; }
        public string PostalSuburbMember { get; set; }
        public string PostalBuildingMember { get; set; }
        public string PostalCodeMember { get; set; }
        public string CityMember { get; set; }
        public string ProvinceIDMember { get; set; }
        public string TelnumberMember { get; set; }
        public string CellnumberMember { get; set; }
        public string EmailMember { get; set; }
        public string FNameComplainant { get; set; }
        public string LNameComplainant { get; set; }
        public string TitleIDComplainant { get; set; }
        public string PostalAdressComplainant { get; set; }
        public string PostalSuburbComplainant { get; set; }
        public string PostalBuildingComplainant { get; set; }
        public string PostalCodeComplainant { get; set; }
        public string CityComplainant { get; set; }
        public string ProvinceIDComplainant { get; set; }
        public string TelnumberComplainant { get; set; }
        public string CellnumberComplainant { get; set; }
        public string EmailComplainant { get; set; }
        public string complaintFacts { get; set; }
        public string complaintDisputeResFollowed { get; set; }
        public string complaintRecourseRequired { get; set; }
    }
}
