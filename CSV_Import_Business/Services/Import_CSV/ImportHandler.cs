using CSV_Import_Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using AutoMapper;
using System.Threading.Tasks;
using System.Net;
using CSV_Import_Common;

namespace CSV_Import_Business
{
    public class ImportHandler : IImportHandler
    {
        private readonly IConfiguration _config;
        private readonly OrdersDbContext _dbContext;
        private readonly IMapper _mapper;
        public ImportHandler(IConfiguration config, OrdersDbContext dbContext, IMapper mapper)
        {
            _config = config;
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public string GetFilePath()
        {
            string url = Path.GetFullPath(@"C:\Users\Microsoft Windows\Desktop\eBay-OrdersReport-Apr-14-2022-10_17_14-0700-1335846329.csv");
            return url;
        }
        public List<OrderModel> ReadCSV(string url)
        {
            try
            {
                var records = new List<OrderModel>();
                string[] lines = File.ReadAllLines(url);
                for (int i = 3; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    for(int j = 3; j < fields.Length; j++)
                    {
                        fields[j] = fields[j].Replace("\"",string.Empty);
                    }
                    var record = new OrderModel()
                    {
                        OrderNumber = fields[1],
                        BuyerUserName = fields[2],
                        BuyerName = fields[3],
                        BuyerNote = fields[5],
                        BuyerAddress1 = fields[6],
                        BuyerAddress2 = fields[7],
                        BuyerCity = fields[8],
                        BuyerSate = fields[9],
                        BuyerZip = fields[10],
                        BuyerCountry = fields[11],
                        ShipToName = fields[14],
                        ShipToPhone = fields[15],
                        ShipToAddress1 = fields[16],
                        ShipToAddress2 = fields[17],
                        ShipToCity = fields[18],
                        ShipToState = fields[19],
                        ShipToZip = fields[20],
                        ShipToCountry = fields[21],
                        ItemNumber = fields[22],
                        ItemTitle = fields[23],
                        CustomLabel = fields[24],
                        Quantity = Int32.Parse(fields[26]),
                        TotalPrice = float.Parse(fields[45]),
                        SaleDate = DateTime.Parse(fields[48]),
                        Size = ConvertSize(fields[61]),
                        SellerId = fields[0]
                    };
                    records.Add(record);
                }                                      
                return records;
            }                            
            catch(Exception)
            {
                return null;
            }                       
        }
        public async Task<Response> Import_CSV(List<OrderModel> models)
        {
            try
            {               
                foreach (var model in models)
                {
                    if (!isExistRecord(model.OrderNumber))
                    {
                        model.Id = new Guid();
                        var result = _mapper.Map<OrderModel, Orders>(model);
                        _dbContext.Orders.Add(result);
                    }
                    else
                    {
                        var result = _mapper.Map<OrderModel, Orders>(model);
                        _dbContext.Orders.Update(result);
                    }
                }
                await _dbContext.SaveChangesAsync();
                return new Response<List<OrderModel>>(models);
            }
            catch(Exception)
            {
                return new Response(HttpStatusCode.BadRequest,"Can't import file");
            }
            
        }
        public bool isExistRecord(string OrderNumber)
        {
            var check = _dbContext.Orders.Where(c => c.OrderNumber == OrderNumber).FirstOrDefault();
            if (check != null)
                return true;
            else return false;
        }
        public string ConvertSize(string size)
        {
            string[] newSize = size.Split(',');
            newSize[0] = newSize[0].Substring(6);
            return newSize[0];
        }
    }
}
