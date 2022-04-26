using CSV_Import_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Import_Business
{
    public interface IImportHandler
    {
        public string GetFilePath();
        public List<OrderModel> ReadCSV(string url);
        public Task<Response> Import_CSV(List<OrderModel> models);
    }
}
