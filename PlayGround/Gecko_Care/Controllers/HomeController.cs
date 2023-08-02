using Dapper;
using Gecko_Care.Model;
using Gecko_Care.Util;
using Microsoft.AspNetCore.Mvc;

namespace Gecko_Care.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class DataController : ControllerBase
	{
		private readonly DbContext _dbContext;

		public DataController(DbContext dbContext)
		{
			_dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
		}

		[HttpPost]
		public async Task<IActionResult> GetData(Member member)
		{
			try
			{
				using (var connection = _dbContext.GetConnection())
				{
					connection.Open();
					// 여기에서 데이터를 가져오는 SQL 쿼리를 실행합니다.
					// 예를 들어:
					var sql = "insert into member(Name,Gender,BrithDay,Morph,Memo,MotherSeq,FatherSeq,CreateTime) values(@Name,@Gender,@BrithDay,@Morph,@Memo,@MotherSeq,@FatherSeq,@CreateTime)";
					int rowsAffected = await connection.ExecuteAsync(sql, member);
					if (rowsAffected > 0)
					{
						return Ok("Member created successfully.");
					}
					else
					{
						return BadRequest("Failed to create member.");
					}
				}
			}
			catch (Exception ex)
			{
				return StatusCode(500, "An error occurred while fetching data.");
			}
		}
	}
}
