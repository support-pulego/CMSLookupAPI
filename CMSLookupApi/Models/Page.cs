using System;
using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class Page
    {
        [Key]
        public int PageID { get; set; }
        public int ParentID { get; set; }
        public Int16 PageTypeID { get; set; }
        public string PageTitle { get; set; }
        public string PageContent { get; set; }
        public Boolean IsPublished { get; set; }
        public Boolean IsNonMenu { get; set; }
        public Boolean IsLockedLink { get; set; }
        public string LockedLink { get; set; }
        public Boolean IsQuickLink { get; set; }
        public string QuickLinkDescription { get; set; }
        public int FlashID { get; set; }
        public int OrderID { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
    }
}
