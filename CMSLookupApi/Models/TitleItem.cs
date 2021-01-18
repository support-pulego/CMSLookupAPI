using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class TitleItem
    {
        [Key]
        public short ContactTitleId { get; set; }
        public string ContactTitleName { get; set; }
    }
}
