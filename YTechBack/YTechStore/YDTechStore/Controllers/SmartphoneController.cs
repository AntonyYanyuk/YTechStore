using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YTechStore.Models;
using System.Data.SqlClient;
using System.Data;

namespace YTechStore.Controllers
{
    [ApiController]
    [Route("Smartphones")]
    public class SmartphoneController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SmartphoneController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("AllSmartphones")]
        public JsonResult AllSmartGet()
        {
            string query = @"
                 select Id, Name from SmartphoneTab";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("YanTechAppCon");
            SqlDataReader myReader;
            using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(table);
        }
        [HttpPost]
        public JsonResult PostSmartphone(Smartphone smart)
        {
            string query = @"
                 insert into dbo.SmartphoneTab (Id, Name, Value,OS, Display, Procesor, CoresAmount, Sim, 
                 MainCamera, FrontalCamera, RAM, InternalStorage, ExtraSdCard, Batery, Description)
                  values (1, 'Motorola G9 Play', 3799, 'Android 10.0', '6,5 (1600x720)','	
                 Qualcomm Snapdragon 662 + Adreno 610', 8, '	2 or 1 + SD card', '48 + 12 (f / 1,7) + 2 (f / 2,4) + 2 (f / 2,4)', 
                '8 (f / 2.2)', '4', '64', '256', '5000', 'The new moto g9 play gives you what you 
                  want and more. You want sharp and incredibly detailed photos, even in low light? With a 48 MP triple camera system1, you got it. 
            The power to go for days thanks to a 2-day battery2? It’s yours. A super-responsive processor that powers all your favourite apps and more, 
            and never slows you down? No problem. The new moto g9 play. You want it. You got it.')";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("YanTechAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Add Successfuly");
        }
    }
}
