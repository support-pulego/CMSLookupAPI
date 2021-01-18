using CMSLookupApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSLookupApi.Controllers
{
    [Route("complaint")]
    [ApiController]
    public class ComplaintController : ControllerBase
    {
        private readonly SPComplaintContext _context;

        public ComplaintController(SPComplaintContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<ComplaintResponseItem>>> CreateSpComplaint([FromBody] SpComplaintItem complaintItem)
        //public ComplaintResponseItem[] CreateSpComplaint([FromBody] SpComplaintItem complaintItem)
        {

            var schemeEntityIDPrivateMember = (object)complaintItem.SchemeEntityIDPrivateMember ?? DBNull.Value;
            var entityTypeIDMember = (object)complaintItem.EntityTypeIDMember ?? DBNull.Value;
            var primaryNoMember = (object)complaintItem.EntityIDMember ?? DBNull.Value;
            var benefitoptionIDAgainst = (object)complaintItem.BenefitoptionIDAgainst ?? DBNull.Value;
            var provinceIDMember = (object)complaintItem.ProvinceIDMember ?? DBNull.Value;
            var titleIDMember = (object)complaintItem.TitleIDMember ?? DBNull.Value;
            var titleIDComplainant = (object)complaintItem.TitleIDComplainant ?? DBNull.Value;
            var provinceIDComplainant = (object)complaintItem.ProvinceIDComplainant ?? DBNull.Value;

            return await _context.SpCompliant.FromSqlRaw("EXECUTE website.spI_Web_Complaint " +
                "@EntitypeIDAgainst, " +
                "@PrimaryNo, " +
                "@BenefitoptionIDAgainst, " +
                "@EntityTypeIDMember, " +
                "@PrimaryNoMember, " +
                "@MembershipNrMember, " +
                "@SchemeEntityIDPrivateMember, " +
                "@PracticeNameMember, " +
                "@FNameMember, " +
                "@LNameMember, " +
                "@TitleIDMember, " +
                "@PostalAdressMember, " +
                "@PostalSuburbMember, " +
                "@PostalBuildingMember, " +
                "@PostalCodeMember, " +
                "@CityMember, " +
                "@ProvinceIDMember, " +
                "@TelnumberMember, " +
                "@CellnumberMember, " +
                "@EmailMember, " +
                "@FNameComplainant, " +
                "@LNameComplainant, " +
                "@TitleIDComplainant, " +
                "@PostalAdressComplainant, " +
                "@PostalSuburbComplainant , " +
                "@PostalBuildingComplainant , " +
                "@PostalCodeComplainant, " +
                "@CityComplainant, " +
                "@ProvinceIDComplainant, " +
                "@TelnumberComplainant, " +
                "@CellnumberComplainant, " +
                "@EmailComplainant, " +
                "@complaintFacts, " +
                "@complaintDisputeResFollowed, " +
                "@complaintRecourseRequired, " +
                "@AttachmentLocation",
                new SqlParameter("EntitypeIDAgainst", complaintItem.EntitypeIDAgainst),
                new SqlParameter("PrimaryNo", complaintItem.EntityIDAgainst),
                new SqlParameter("BenefitoptionIDAgainst", benefitoptionIDAgainst),
                new SqlParameter("EntityTypeIDMember", entityTypeIDMember),
                new SqlParameter("PrimaryNoMember", primaryNoMember),
                new SqlParameter("MembershipNrMember", complaintItem.MembershipNrMember),
                new SqlParameter("SchemeEntityIDPrivateMember", schemeEntityIDPrivateMember),
                new SqlParameter("PracticeNameMember", complaintItem.PracticeNameMember),
                new SqlParameter("FNameMember", complaintItem.FNameMember),
                new SqlParameter("LNameMember", complaintItem.LNameMember),
                new SqlParameter("TitleIDMember", titleIDMember),
                new SqlParameter("PostalAdressMember", complaintItem.PostalAdressMember),
                new SqlParameter("PostalSuburbMember", complaintItem.PostalSuburbMember),
                new SqlParameter("PostalBuildingMember", complaintItem.PostalBuildingMember),
                new SqlParameter("PostalCodeMember", complaintItem.PostalCodeMember),
                new SqlParameter("CityMember", complaintItem.CityMember),
                new SqlParameter("ProvinceIDMember", provinceIDMember),
                new SqlParameter("TelnumberMember", complaintItem.TelnumberMember),
                new SqlParameter("CellnumberMember", complaintItem.CellnumberMember),
                new SqlParameter("EmailMember", complaintItem.EmailMember),
                new SqlParameter("FNameComplainant", complaintItem.FNameComplainant),
                new SqlParameter("LNameComplainant", complaintItem.LNameComplainant),
                new SqlParameter("TitleIDComplainant", titleIDComplainant),
                new SqlParameter("PostalAdressComplainant", complaintItem.PostalAdressComplainant),
                new SqlParameter("PostalSuburbComplainant", complaintItem.PostalSuburbComplainant),
                new SqlParameter("PostalBuildingComplainant", complaintItem.PostalBuildingComplainant),
                new SqlParameter("PostalCodeComplainant", complaintItem.PostalCodeComplainant),
                new SqlParameter("CityComplainant", complaintItem.CityComplainant),
                new SqlParameter("ProvinceIDComplainant", provinceIDComplainant),
                new SqlParameter("TelnumberComplainant", complaintItem.TelnumberComplainant),
                new SqlParameter("CellnumberComplainant", complaintItem.CellnumberComplainant),
                new SqlParameter("EmailComplainant", complaintItem.EmailComplainant),
                new SqlParameter("complaintFacts", complaintItem.ComplaintFacts),
                new SqlParameter("complaintDisputeResFollowed", complaintItem.ComplaintDisputeResFollowed),
                new SqlParameter("complaintRecourseRequired", complaintItem.ComplaintRecourseRequired),
                new SqlParameter("AttachmentLocation", complaintItem.AttachmentLocation)).ToListAsync();
            //var generator = new RandomGenerator();
            //return new ComplaintResponseItem[] { new ComplaintResponseItem { isSuccess = true, Result = "Complaint registered successfully. Your reference number is CM755" + generator.RandomNumber(10, 100) } };

        }

        public class RandomGenerator
        {
            // Instantiate random number generator.  
            // It is better to keep a single Random instance 
            // and keep using Next on the same instance.  
            private readonly Random _random = new Random();

            // Generates a random number within a range.      
            public int RandomNumber(int min, int max)
            {
                return _random.Next(min, max);
            }

            // Generates a random string with a given size.    
            public string RandomString(int size, bool lowerCase = false)
            {
                var builder = new StringBuilder(size);

                // Unicode/ASCII Letters are divided into two blocks
                // (Letters 65–90 / 97–122):   
                // The first group containing the uppercase letters and
                // the second group containing the lowercase.  

                // char is a single Unicode character  
                char offset = lowerCase ? 'a' : 'A';
                const int lettersOffset = 26; // A...Z or a..z: length = 26  

                for (var i = 0; i < size; i++)
                {
                    var @char = (char)_random.Next(offset, offset + lettersOffset);
                    builder.Append(@char);
                }

                return lowerCase ? builder.ToString().ToLower() : builder.ToString();
            }
        }

        [HttpGet("against-categories")]
        public async Task<ActionResult<IEnumerable<ComplaintCategoryAgainstItem>>> GetSpComplaintAgainstCategories()
        {
            return await _context.CategoryAgainst.FromSqlRaw("EXECUTE website.spGet_ComplaintAgainst_Category").ToListAsync();
        }

        [HttpGet("by-categories")]
        public async Task<ActionResult<IEnumerable<ComplaintCategoryByItem>>> GetSpComplaintByCategories()
        {
            return await _context.CategoryBy.FromSqlRaw("EXECUTE website.spGet_ComplaintBy_Category").ToListAsync();
        }

        [HttpGet("sp-province")]
        public async Task<ActionResult<IEnumerable<ProvinceItem>>> GetSpProvince()
        {
            return await _context.ProvinceData.FromSqlRaw("EXECUTE website.spGet_Province").ToListAsync();
        }

        [HttpGet("sp-scheme-benefit-options/{entityid}")]
        public async Task<ActionResult<IEnumerable<SchemeBenefitOptionsItem>>> GetSpSchemeBenefitOptions(int entityid)
        {
            return await _context.SchemeBenefitOptions.FromSqlRaw("EXECUTE website.spGet_SchemeBenefitoptions @entityid", new SqlParameter("@entityid", entityid)).ToListAsync();
        }

        [HttpGet("sp-title")]
        public async Task<ActionResult<IEnumerable<TitleItem>>> Get_Title()
        {
            return await _context.TitleList.FromSqlRaw("EXECUTE website.spGet_Title").ToListAsync();
        }

        [HttpGet("entity-list-by-category/{entitytypeid}")]
        public async Task<ActionResult<IEnumerable<EntityListItem>>> GetEntityListByCategory(int entitytypeid)
        {
            return await _context.EntityList.FromSqlRaw("EXECUTE website.spGet_EntityList_ByCategory @entitytypeid", new SqlParameter("@entitytypeid", entitytypeid)).ToListAsync();
        }

        [HttpGet("complaint-status/{complaintId}")]
        public async Task<ActionResult<IEnumerable<ComplaintStatusItem>>> GetComplaintStatus(int complaintId) {

            return await _context.ComplaintStatus.FromSqlRaw("EXECUTE website.spGet_Complaint_Status @complaintid;", new SqlParameter("@complaintid", complaintId)).ToListAsync();
            
        }
    }
}