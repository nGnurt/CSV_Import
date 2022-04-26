using AutoMapper;
using CSV_Import_Business;
using CSV_Import_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSV_Import_Api
{
    public class MapConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DatabaseTableToViewModelMapping());
                cfg.AddProfile(new ViewModelToDatabaseTableMapping());
            });
        }

        public class DatabaseTableToViewModelMapping : Profile
        {
            public DatabaseTableToViewModelMapping()
            {
                CreateMap<OrderModel, Orders>();
            }           
        }
        public class ViewModelToDatabaseTableMapping : Profile
        {
            public ViewModelToDatabaseTableMapping()
            {
                CreateMap<Orders, OrderModel>();
            }
        }
    }
}
