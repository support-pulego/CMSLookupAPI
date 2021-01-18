using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class ComplaintResponseItem
    {
        [Key]
        public bool isSuccess { get; set; }
        public string Result { get; set; }
    }
}
