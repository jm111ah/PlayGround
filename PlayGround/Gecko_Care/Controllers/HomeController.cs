using Dapper;
using Gecko_Care.Model;
using Gecko_Care.Util;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Gecko_Care.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        private readonly DbConnectoin _dbContext;

        public DataController(DbConnectoin dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        [HttpPost]
        public async Task<IActionResult> InsertMember(Member member)
        {
            try
            {
                using IDbConnection db = _dbContext.GetConnection();

                int result = await db.ExecuteAsync(Query.Query.InsertMember, new { member.Name, member.Gender, member.BirthDay, member.Morph, member.Memo, member.MotherSeq, member.FatherSeq });

                if (result > 0)
                {
                    return Ok("Member created successfully.");
                }
                else
                {
                    return BadRequest("Failed to create member.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while fetching data.");
            }
        }
    }
}
