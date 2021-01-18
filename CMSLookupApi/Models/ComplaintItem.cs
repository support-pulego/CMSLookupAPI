using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class ComplaintItem
    {
        [JsonPropertyName("Membership Number Member")]
        public string MembershipNrMember { get; set; }
        [JsonPropertyName("Practice Name Member")]
        public string PracticeNameMember { get; set; }
        [JsonPropertyName("First Name Member")]
        public string FNameMember { get; set; }
        [JsonPropertyName("Last Name Member")]
        public string LNameMember { get; set; }
        public string TitleIDMember { get; set; }
        [JsonPropertyName("Postal Adress Member")]
        public string PostalAdressMember { get; set; }
        [JsonPropertyName("Postal Suburb Member")]
        public string PostalSuburbMember { get; set; }
        [JsonPropertyName("Postal Building Member")]
        public string PostalBuildingMember { get; set; }
        [JsonPropertyName("Postal Code Member")]
        public string PostalCodeMember { get; set; }
        [JsonPropertyName("City Member")]
        public string CityMember { get; set; }
        public string ProvinceIDMember { get; set; }
        [JsonPropertyName("Telephone Number")]
        public string TelnumberMember { get; set; }
        [JsonPropertyName("Cellphone Number")]
        public string CellnumberMember { get; set; }
        [JsonPropertyName("Email Member")]
        public string EmailMember { get; set; }
        [JsonPropertyName("First Name Complainant")]
        public string FNameComplainant { get; set; }
        [JsonPropertyName("Last Name Complainant")]
        public string LNameComplainant { get; set; }
        public string TitleIDComplainant { get; set; }
        [JsonPropertyName("Postal Adress Complainant")]
        public string PostalAdressComplainant { get; set; }
        [JsonPropertyName("Postal Suburb Complainant")]
        public string PostalSuburbComplainant { get; set; }
        [JsonPropertyName("Postal Building Complainant")]
        public string PostalBuildingComplainant { get; set; }
        [JsonPropertyName("Postal Code Complainant")]
        public string PostalCodeComplainant { get; set; }
        [JsonPropertyName("City Complainant")]
        public string CityComplainant { get; set; }
        public string ProvinceIDComplainant { get; set; }
        [JsonPropertyName("Telephone Number Complainant")]
        public string TelnumberComplainant { get; set; }
        [JsonPropertyName("Cellphone Number Complainant")]
        public string CellnumberComplainant { get; set; }
        [JsonPropertyName("Email Complainant")]
        public string EmailComplainant { get; set; }
        [JsonPropertyName("Complaint Facts")]
        public string complaintFacts { get; set; }
        [JsonPropertyName("Complaint Dispute Resolution Followed")]
        public string complaintDisputeResFollowed { get; set; }
        [JsonPropertyName("Complaint Recourse Required")]
        public string complaintRecourseRequired { get; set; }
    }
}
