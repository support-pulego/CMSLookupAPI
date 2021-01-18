using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class SpComplaintItem
    {
        [Key]
        public int? RC { get; set; }
        public int? EntitypeIDAgainst { get; set; }
        public int? EntityIDAgainst { get; set; }
        public int? BenefitoptionIDAgainst { get; set; }
        public int? EntityTypeIDMember { get; set; }
        public int? EntityIDMember { get; set; }
        public string? MembershipNrMember { get; set; }
        public int? SchemeEntityIDPrivateMember { get; set; }
        public string? PracticeNameMember { get; set; }
        public string? FNameMember { get; set; }
        public string? LNameMember { get; set; }
        public int? TitleIDMember { get; set; }
        public string? PostalAdressMember { get; set; }
        public string? PostalSuburbMember { get; set; }
        public string? PostalBuildingMember { get; set; }
        public string? PostalCodeMember { get; set; }
        public string? CityMember { get; set; }
        public int? ProvinceIDMember { get; set; }
        public string? TelnumberMember { get; set; }
        public string? CellnumberMember { get; set; }
        public string? EmailMember { get; set; }
        public string? FNameComplainant { get; set; }
        public string? LNameComplainant { get; set; }
        public int? TitleIDComplainant { get; set; }
        public string? PostalAdressComplainant { get; set; }
        public string? PostalSuburbComplainant { get; set; }
        public string? PostalBuildingComplainant { get; set; }
        public string? PostalCodeComplainant { get; set; }
        public string? CityComplainant { get; set; }
        public int? ProvinceIDComplainant { get; set; }
        public string? TelnumberComplainant { get; set; }
        public string? CellnumberComplainant { get; set; }
        public string? EmailComplainant { get; set; }
        public string? ComplaintFacts { get; set; }
        public string? ComplaintDisputeResFollowed { get; set; }
        public string? ComplaintRecourseRequired { get; set; }
        public string? AttachmentLocation { get; set; }
    }
}
