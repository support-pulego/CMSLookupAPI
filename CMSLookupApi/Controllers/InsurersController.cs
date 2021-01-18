using CMSLookupApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMSLookupApi.Controllers
{
    [Route("insurers")]
    [ApiController]
    public class InsurersController : ControllerBase
    {
        private readonly InsurersContext _context;

        public InsurersController(InsurersContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InsurersItem>>> GetInsurers()
        {
            string sqlQuery = "SELECT dbo.[Insurer].InsurerId AS id, dbo.[Insurer].[CompanyName] AS Insurer, dbo.[Insurer].[CMSRefNo], dbo.[Underwriter].[UnderwriterName] AS Underwriter, dbo.[CEO].CeoId AS CEOId, dbo.[CEO].[FullNames] AS InsurerCEOName, dbo.[Underwriter].[CEO] AS UnderwriterCEOName, [Director1Names] = (SELECT [FullNames] FROM dbo.[Director] WHERE dbo.[Director].Id = dbo.[Insurer].FkDirector1Id), [Director2Names] = (SELECT [FullNames] FROM dbo.[Director] WHERE dbo.[Director].Id = dbo.[Insurer].FkDirector2Id), dbo.[Insurer].FkDirector1Id AS Director1Id, dbo.[Insurer].FkDirector2Id AS Director2Id, dbo.[Insurer].FkUnderwriterId AS UnderwriterId, dbo.[Insurer].[ComplaintsNo], dbo.[Insurer].[CustomerCareNo], dbo.[Insurer].[FraudTipOffNo], dbo.[Insurer].[ExemptionPeriodStart], dbo.[Insurer].[ExemptionPeriodEnd], dbo.[Insurer].[IsUnderwriter] FROM Insurer FULL JOIN dbo.[Underwriter] ON dbo.[Underwriter].UnderwriterId = dbo.[Insurer].FkUnderwriterId FULL JOIN dbo.[CEO] ON dbo.[CEO].CeoId = dbo.[Insurer].FkCEOId WHERE dbo.Insurer.Active = 1 ORDER BY Insurer ASC";

            return await _context.InsurersService.FromSqlRaw(sqlQuery).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<InsurerDetailItem>>> GetInsurerDetails(int id)
        {
            string sqlQuery = "SELECT dbo.[Insurer].InsurerId,dbo.[Insurer].[CompanyName], dbo.[Insurer].[PhysicalAddress], dbo.[Insurer].[PostalAddress], dbo.[Insurer].[Website], dbo.[Insurer].[Tel], dbo.[Insurer].[Fax], dbo.[Insurer].[Email], dbo.[Insurer].[CompanyRegNo], dbo.[Insurer].[FSPNo], dbo.[Insurer].[TradingName], dbo.[Insurer].[CustomerCareNo], dbo.[Insurer].CMSRefNo, [Director1Names] = (SELECT [FullNames] FROM dbo.Director WHERE dbo.Director.DirectorId = dbo.Insurer.FkDirector1Id), [Director2Names] =	(SELECT [FullNames] FROM dbo.Director WHERE dbo.Director.DirectorId = dbo.Insurer.FkDirector2Id), dbo.[Administrator].CEO AS AdministratorCEO, dbo.[ManagedCare].CEO AS ManagedCareCEO, dbo.[Distributor].CEO AS DistributorCEO, dbo.[Insurer].ComplaintsNo, dbo.[Insurer].ComplaintsEmail, dbo.[Insurer].FraudTipOffNo, dbo.[Insurer].FraudTipOffEmail FROM Insurer FULL JOIN dbo.Administrator ON dbo.Administrator.AdministratorId = dbo.Insurer.FkAdministratorCEOId	FULL JOIN dbo.ManagedCare ON dbo.ManagedCare.ManagedCareId = dbo.Insurer.FkManagedCareCEOId	FULL JOIN dbo.Distributor ON dbo.Distributor.DistributorId = dbo.Insurer.FkDistributorCEOId	WHERE dbo.Insurer.InsurerId = " + id.ToString();

            return await _context.InsurerDetailService.FromSqlRaw(sqlQuery).ToListAsync();
        }
        
        [HttpGet("product/{refno}")]
        public async Task<ActionResult<IEnumerable<ProductDetailItem>>> GetProductDetails(string refno)
        {
            //SELECT dbo.[Insurer].[CompanyName], dbo.[ExeProducts].ProductId AS ProductID, dbo.[ExeProducts].[Description] AS Product, dbo.[ExeProducts].[ExemptionPeriodStart], dbo.[ExeProducts].[ExemptionPeriodEnd], dbo.[ExeProducts].[ProductStatusID], Exemption = (SELECT[Description] FROM dbo.Exemption WHERE Exemption.Id = ExeProducts.ExemptionId) FROM dbo.[ExeProducts] JOIN dbo.[Insurer] ON dbo.[Insurer].[CMSRefNo] = dbo.[ExeProducts].[fkCMSRefNo] WHERE dbo.[ExeProducts].[fkCMSRefNo] = @CMSRefNo ORDER BY dbo.ExeProducts.ProductId
            string sqlQuery = "SELECT dbo.[Insurer].[CompanyName], dbo.[ExeProducts].ProductId AS ProductID, dbo.[ExeProducts].[Description] AS Product, dbo.[ExeProducts].[ExemptionPeriodStart], dbo.[ExeProducts].[ExemptionPeriodEnd], dbo.[ExeProducts].[ProductStatusID], Exemption = (SELECT[Description] FROM dbo.Exemption WHERE Exemption.Id = ExeProducts.ExemptionId) FROM dbo.[ExeProducts] JOIN dbo.[Insurer] ON dbo.[Insurer].[CMSRefNo] = dbo.[ExeProducts].[fkCMSRefNo] WHERE dbo.[ExeProducts].[fkCMSRefNo] = '" + refno + "' ORDER BY dbo.ExeProducts.ProductId";

            return await _context.ProductDetailService.FromSqlRaw(sqlQuery).ToListAsync();
        }

        [HttpGet("productoptions/{productId}")]
        public async Task<ActionResult<IEnumerable<ProductOptionItem>>> GetProductOptions(string productId)
        {
            //SELECT [Description], [fkProductID] FROM dbo.ExeProductOptions WHERE dbo.ExeProductOptions.fkProductID =
            string sqlQuery = "SELECT Id, Description, Active,fkProductId as ProductId FROM ExeProductOptions WHERE Active=1 AND fkProductId = " + productId;

            return await _context.ProductOptionService.FromSqlRaw(sqlQuery).ToListAsync();
        }
        
        [HttpGet("productconditions/{productId}")]
        public async Task<ActionResult<IEnumerable<ProductConditionItem>>> GetProductConditions(string productId)
        {
            //string sqlQuery = "SELECT ExeConditions.Id, ExeConditions.ConditionNo, ExeConditions.Description AS ConditionDescription, ExeConditions.DueDateStart, ExeConditionsInfo.InfoNo, ExeConditionsInfo.Description AS InfoDescription, ExeConditionRequirements.RequirementNo, ExeConditionRequirements.Description AS RequirementDescription FROM ExeConditions FULL OUTER JOIN ExeConditionsInfo ON ExeConditionsInfo.FkExemptionConditionId = ExeConditions.Id FULL OUTER JOIN ExeConditionRequirements ON ExeConditionRequirements.FkExemptionConditionId = ExeConditions.Id INNER JOIN ExeProducts ON ExeProducts.Id = (SELECT ProductId FROM ExeProducts WHERE fkCMSRefNo='" + refno + "')";
            string sqlQuery = "SELECT dbo.[ExeConditions].[id],dbo.[ExeConditions].[ConditionNo], dbo.[ExeConditions].[Description] AS ConditionDescription,dbo.[ExeConditions].[DueDateStart], dbo.[ExeConditionsInfo].[InfoNo], dbo.[ExeConditionsInfo].[Description] AS InfoDescription, dbo.[ExeConditionRequirements].[RequirementNo], dbo.[ExeConditionRequirements].[Description] AS RequirementDescription, dbo.[ExeProducts].[Description] AS ProductName FROM dbo.[ExeConditions] FULL JOIN dbo.[ExeConditionsInfo] ON ExeConditionsInfo.fkExemptionConditionId = ExeConditions.id FULL JOIN dbo.[ExeConditionRequirements] ON ExeConditionRequirements.fkExemptionConditionId = ExeConditions.id JOIN dbo.[ExeProducts] ON dbo.[ExeProducts].Id = " + productId;

            return await _context.ProductConditionsService.FromSqlRaw(sqlQuery).ToListAsync();
        }
       
        [HttpGet("insurerfspdetail/{refno}/{underwriterid}/{isunderwriter}")]
        public async Task<ActionResult<IEnumerable<InsurerFSBDetailItem>>> GetInsurerFSPDetail(string refno,int underwriterid, int isunderwriter)
        {
            string sqlQuery = "SELECT UnderwriterName = (SELECT CompanyName FROM Insurer WHERE CMSRefNo ='" + refno + "'),CompanyName AS FSPName, CMSRefNo, FSPNo FROM Insurer WHERE dbo.Insurer.FkUnderwriterId = " + underwriterid.ToString() + " AND IsUnderwriter = " + isunderwriter.ToString();
            
            return await _context.InsureFSPDetailService.FromSqlRaw(sqlQuery).ToListAsync();
        }


        [HttpGet("insurerconditions/{refno}")]
        public async Task<ActionResult<IEnumerable<InsurerConditionItem>>> GetInsurerConditions(string refno)
        {
            string sqlQuery = "SELECT ExeConditions.Id, ExeConditions.ConditionNo, ExeConditions.Description AS ConditionDescription, ExeConditions.DueDateStart, ExeConditionsInfo.InfoNo, ExeConditionsInfo.Description AS InfoDescription, ExeConditionRequirements.RequirementNo, ExeConditionRequirements.Description AS RequirementDescription, Insurer.CompanyName FROM ExeConditions FULL OUTER JOIN ExeConditionsInfo ON ExeConditionsInfo.FkExemptionConditionId = ExeConditions.Id FULL OUTER JOIN ExeConditionRequirements ON ExeConditionRequirements.FkExemptionConditionId = ExeConditions.Id INNER JOIN Insurer ON Insurer.Id = (select Insurer.InsurerId from Insurer WHERE CMSRefNo='" + refno + "')";

            return await _context.InsurerConditionsService.FromSqlRaw(sqlQuery).ToListAsync();
        }

    }

}