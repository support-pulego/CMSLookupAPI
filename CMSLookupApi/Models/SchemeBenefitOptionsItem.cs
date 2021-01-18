using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class SchemeBenefitOptionsItem
    {
        [Key]
       public int BenefitOptionId { get; set; }
       public string BenefitName { get; set; }
    }
}
