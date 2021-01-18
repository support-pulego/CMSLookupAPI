using System;
using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class PublicationItem
    {
        [Key]
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
