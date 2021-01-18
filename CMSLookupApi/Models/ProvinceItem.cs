using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class ProvinceItem
    {
        [Key]
        public short ProvinceId { get; set; }
        public string Province { get; set; }
    }
}
