using Dapper;
using Gecko_Care.Model;
using Gecko_Care.Util;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.Common;

namespace Gecko_Care.Controllers
{
    [ApiController]
    [Route("api/member")]
    public class DataController : ControllerBase
    {
        private readonly DbConnectoin _dbContext;

        public DataController(DbConnectoin dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        [HttpGet("select")]
        public async Task<IActionResult> SelectMember(string name)
        {
            try
            {
                using IDbConnection db = _dbContext.GetConnection();

                IEnumerable<Member> memberResult = await db.QueryAsync<Member>(Query.Query.SelectMember, new { name });

                if (memberResult.Count() > 0)
                {
                    return Ok(memberResult);
                }
                else
                {
                    return BadRequest("Failed Select");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertMember(Member member)
        {
            try
            {
                using IDbConnection db = _dbContext.GetConnection();

                int result = await db.ExecuteAsync(Query.Query.InsertMember, new { member.Name, member.Gender, member.BirthDay, member.Morph, member.Memo, member.MotherSeq, member.FatherSeq });

                if (result > 0)
                {
                    return Ok("Good Insert");
                }
                else
                {
                    return BadRequest("Failed Insert");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateMember(Member member)
        {
            try
            {
                using IDbConnection db = _dbContext.GetConnection();

                int result = await db.ExecuteAsync(Query.Query.UpdateMember, new { member.Name, member.Gender, member.BirthDay, member.Morph, member.MotherSeq, member.FatherSeq, member.MemberSeq });

                if (result > 0)
                {
                    return Ok("Good Update");
                }
                else
                {
                    return BadRequest("Failed Update");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteMember(int seq)
        {
            try
            {
                using IDbConnection db = _dbContext.GetConnection();

                int result = await db.ExecuteAsync(Query.Query.DeleteMember, new { seq });

                if (result > 0)
                {
                    return Ok("Good Delete");
                }
                else
                {
                    return BadRequest("Failed Delete");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        



    }
}
