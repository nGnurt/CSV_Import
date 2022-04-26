using CSV_Import_Business;
using CSV_Import_Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CSV_Import_Common;
using Microsoft.AspNetCore.Authorization;

namespace CSV_Import_Api.Controllers
{
    public class ImportController : ControllerBase
    {
        
        private readonly OrdersDbContext _dbContext;
        private readonly IImportHandler _handler;

        public ImportController(OrdersDbContext dbContext, IImportHandler handler)
        {            
            _dbContext = dbContext;
            _handler = handler;
        }

        [HttpPost]
        [Route("api/v1/csv")]
        [AllowAnonymous]
        public async Task<IActionResult> ImportCSV()
        {
            var url = _handler.GetFilePath();
            var data = _handler.ReadCSV(url);
            var result = await _handler.Import_CSV(data);
            return Helper.TransformData(result);
        }
    }
}
