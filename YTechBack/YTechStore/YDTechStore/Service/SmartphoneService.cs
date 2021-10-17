using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YTechStore.Common;
using YTechStore.IServices;
using YTechStore.Models;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace YTechStore.Service
{
    public class SmartphoneService : ISmartphoneService
    {
        Smartphone _smartphone = new Smartphone();
        List<Smartphone> _smartphones = new List<Smartphone>();
        public Smartphone Save(Smartphone smartphone)
        {
            _smartphone = new Smartphone();

            try
            {
                int operationType = Convert.ToInt32(smartphone.Id == 0 ? OperationType.Insert : OperationType.Update);

                using (IDbConnection con = new SqlConnection(Global.ConnectionString))
                {
                    if (con.State == ConnectionState.Closed) con.Open();

                    var smartphones = con.Query<Smartphone>("AddSmartphone",
                       this.SetParametrs(smartphone, operationType),
                       commandType: CommandType.StoredProcedure);

                    if (smartphones != null && smartphones.Count() > 0)
                    {
                        _smartphone = smartphones.FirstOrDefault(); 
                    }
                }
            }
            catch (Exception ex)
            {
                string _saveError = ex.Message;
            }
            return _smartphone;
        }

        private DynamicParameters SetParametrs(Smartphone smartphone, int operationType)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", smartphone.Id);
            parameters.Add("@Name", smartphone.Name);
            parameters.Add("@Value", smartphone.Value);
            parameters.Add("@Manufacturer", smartphone.Manufacturer);
            parameters.Add("@Description", smartphone.Description);
            return parameters;
        }
    }
}
