using System;
using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class MedschemeItem
    {
        [Key]
        public string? SchemeName { get; set; }
        public string? SchemeType { get; set; }
        public string? Telephone { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string? isp_schemereferencenumber { get; set; }
        public string? isp_previousname { get; set; }
        public string? isp_amalgamationschemeidname { get; set; }
        public string? fax { get; set; }
        public string? emailaddress2 { get; set; }
        public string? websiteurl { get; set; }
        public string? address1_line1 { get; set; }
        public string? address1_line2 { get; set; }
        public string? address1_line3 { get; set; }
        public string? address1_postalcode { get; set; }
        public string? address1_city { get; set; }
        public int? isp_address1province { get; set; }
        public string? address2_line1 { get; set; }
        public string? address2_line2 { get; set; }
        public string? address2_line3 { get; set; }
        public string? address2_city { get; set; }
        public string? address2_postalcode { get; set; }
        public int? isp_address2province { get; set; }

    }
}

//SELECT name AS 'SchemeName', isp_schemetypename AS 'SchemeType', address1_telephone2 AS Telephone, isp_schemestartdate AS 'RegistrationDate', 
//isp_schemereferencenumber, isp_previousname, isp_amalgamationschemeidname, fax, 
//emailaddress2, websiteurl, address1_line1, address1_line2, address1_line3, address1_postalcode, address1_city, isp_address1province, address2_line1, 
//address2_line2, address2_line3, address2_city, address2_postalcode, 
//                  isp_address2province
//FROM     FilteredAccount