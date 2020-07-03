using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using CMSLookupApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Controllers
{
    [Route("api/sp-web-complaint")]
    [ApiController]
    public class ComplaintController : ControllerBase
    {
        private readonly SPComplaintContext _context;

        public ComplaintController(SPComplaintContext context)
        {
            _context = context;
        }

        [HttpPost]
        public int CreateSpComplaint([FromBody] SpComplaintItem complaintItem)
        {
            var EntitypeIDAgainst = new SqlParameter("@EntitypeIDAgainst", complaintItem.EntitypeIDAgainst);

            var EntityIDAgainst = new SqlParameter("@EntityIDAgainst", complaintItem.EntityIDAgainst);

            var BenefitoptionIDAgainst = new SqlParameter("@BenefitoptionIDAgainst", complaintItem.BenefitoptionIDAgainst);

            var EntityTypeIDMember = new SqlParameter("@EntityTypeIDMember", complaintItem.EntityTypeIDMember);

            var EntityIDMember = new SqlParameter("@EntityIDMember", complaintItem.EntityIDMember);

            var MembershipNrMember = new SqlParameter("@MembershipNrMember", complaintItem.MembershipNrMember);

            var PracticeNameMember = new SqlParameter("@PracticeNameMember", complaintItem.PracticeNameMember);

            var FNameMember = new SqlParameter("@FNameMember", complaintItem.FNameMember);

            var LNameMember = new SqlParameter("@LNameMember", complaintItem.LNameMember);

            var TitleIDMember = new SqlParameter("@TitleIDMember", complaintItem.TitleIDMember);

            var PostalAdressMember = new SqlParameter("@PostalAdressMember", complaintItem.PostalAdressMember);

            var PostalSuburbMember = new SqlParameter("@PostalSuburbMember", complaintItem.PostalSuburbMember);

            var PostalBuildingMember = new SqlParameter("@PostalBuildingMember", complaintItem.PostalBuildingMember);

            var PostalCodeMember = new SqlParameter("@PostalCodeMember", complaintItem.PostalCodeMember);
            
            var CityMember = new SqlParameter("@CityMember", complaintItem.CityMember);

            var ProvinceIDMember = new SqlParameter("@ProvinceIDMember", complaintItem.ProvinceIDMember);

            var TelnumberMember = new SqlParameter("@TelnumberMember", complaintItem.TelnumberMember);

            var CellnumberMember = new SqlParameter("@CellnumberMember", complaintItem.CellnumberMember);

            var EmailMember = new SqlParameter("@EmailMember", complaintItem.EmailMember);

            var FNameComplainant = new SqlParameter("@FNameComplainant", complaintItem.FNameComplainant);

            var LNameComplainant = new SqlParameter("@LNameComplainant", complaintItem.LNameComplainant);

            var TitleIDComplainant = new SqlParameter("@TitleIDComplainant", complaintItem.TitleIDComplainant);

            var PostalAdressComplainant = new SqlParameter("@PostalAdressComplainant", complaintItem.PostalAdressComplainant);

            var PostalSuburbComplainant = new SqlParameter("@PostalSuburbComplainant", complaintItem.PostalSuburbComplainant);
           
            var PostalBuildingComplainant = new SqlParameter("@PostalBuildingComplainant",complaintItem.PostalBuildingComplainant);

            var PostalCodeComplainant = new SqlParameter("@PostalCodeComplainant", complaintItem.PostalCodeComplainant);

            var CityComplainant = new SqlParameter("@CityComplainant", complaintItem.CityComplainant);

            var ProvinceIDComplainant = new SqlParameter("@ProvinceIDComplainant", complaintItem.ProvinceIDComplainant);

            var TelnumberComplainant = new SqlParameter("@TelnumberComplainant", complaintItem.TelnumberComplainant);

            var CellnumberComplainant = new SqlParameter("@CellnumberComplainant", complaintItem.CellnumberComplainant);

            var EmailComplainant = new SqlParameter("@EmailComplainant", complaintItem.EmailComplainant);

            var complaintFacts = new SqlParameter("@complaintFacts", complaintItem.complaintFacts);

            var complaintDisputeResFollowed = new SqlParameter("@complaintDisputeResFollowed", complaintItem.complaintDisputeResFollowed);

            var complaintRecourseRequired = new SqlParameter("@complaintRecourseRequired", complaintItem.complaintRecourseRequired);

           return _context.Database.ExecuteSqlRaw("EXECUTE website.spI_Web_Complaint @EntitypeIDAgainst, @EntityIDAgainst, @BenefitoptionIDAgainst, @EntityTypeIDMember, @EntityIDMember, @MembershipNrMember, @PracticeNameMember, @FNameMember, @LNameMember, @TitleIDMember, @PostalAdressMember, @PostalSuburbMember, @PostalBuildingMember, @PostalCodeMember, @CityMember, @ProvinceIDMember, @TelnumberMember, @CellnumberMember, @EmailMember, @FNameComplainant, @LNameComplainant, @TitleIDComplainant, @PostalAdressComplainant, @PostalCodeMember, @CityMember, @ProvinceIDMember, @TelnumberMember, @CellnumberMember, @EmailMember, @FNameComplainant, @LNameComplainant, @TitleIDComplainant, @PostalAdressComplainant, @PostalSuburbComplainant, @PostalBuildingComplainant, @PostalCodeComplainant, @CityComplainant, @ProvinceIDComplainant, @TelnumberComplainant, @CellnumberComplainant, @EmailComplainant, @complaintFacts, @complaintDisputeResFollowed, @complaintRecourseRequired", EntitypeIDAgainst, EntityIDAgainst, BenefitoptionIDAgainst, EntityTypeIDMember, EntityIDMember, MembershipNrMember, PracticeNameMember, FNameMember, LNameMember, TitleIDMember, PostalAdressMember, PostalSuburbMember, PostalBuildingMember, PostalCodeMember, CityMember, ProvinceIDMember, TelnumberMember, CellnumberMember, EmailMember, FNameComplainant, LNameComplainant, TitleIDComplainant, PostalAdressComplainant, PostalCodeMember, CityMember, ProvinceIDMember, TelnumberMember, CellnumberMember, EmailMember, FNameComplainant, LNameComplainant, TitleIDComplainant, PostalAdressComplainant, PostalSuburbComplainant, PostalBuildingComplainant, PostalCodeComplainant, CityComplainant, ProvinceIDComplainant, TelnumberComplainant, CellnumberComplainant, EmailComplainant, complaintFacts, complaintDisputeResFollowed, complaintRecourseRequired);

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
            return await _context.SchemeBenefitOptions.FromSqlRaw("EXECUTE website.spGet_SchemeBenefitoptions @entityid", new SqlParameter("@entityid",entityid)).ToListAsync();
        }

        [HttpGet("sp-title")]
        public async Task<ActionResult<IEnumerable<TitleItem>>> Get_Title()
        {
            return await _context.TitleList.FromSqlRaw("EXECUTE website.spGet_Title").ToListAsync();
        }

        [HttpGet("entity-list-by-category/{entitytypeid}")]
        public async Task<ActionResult<IEnumerable<EntityListItem>>> GetEntityListByCategory(int entitytypeid)
        {
            return await _context.EntityList.FromSqlRaw("EXECUTE website.spGet_EntityList_ByCategory @entitytypeid", new SqlParameter("@entitytypeid",entitytypeid)).ToListAsync();
        }
    }
}