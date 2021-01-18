using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class ComplaintStatusItem
    {
        [Key]
        public string result { get; set; }
    }
}
