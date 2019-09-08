using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using GreenCabV1.Models;
namespace GreenCabV1.Repository
{
    public class Common:IComman
    {
        public int SaveDailyCarPool(DailyCabModels models)
        {

          
                SqlParameter[] pr = new SqlParameter[]
                {

                new SqlParameter("@Gender",models.Sex),
                new SqlParameter("@Name",models.Name),
                new SqlParameter("@EMail",models.Email),
                new SqlParameter("@OfficeEmail",models.Official),

                new SqlParameter("@MobileNo",models.MobileNo),
                new SqlParameter("@Leaving",models.Source),
                new SqlParameter("@GoingTo",models.Destination),
                new SqlParameter("@ReachingHour",models.ReachingHour),
                new SqlParameter("@ReachingMinite",models.ReachingMinute),
                new SqlParameter("@DepartureHour",models.DepartureHour),
                new SqlParameter("@DepartureMinute",models.DepartureMinute),
                new SqlParameter("@Seat",models.NoOfSeat),
                new SqlParameter("@Cast",models.EstimatedCast),


                };


                return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStr(), CommandType.StoredProcedure, "sp_SaveEnquiry", pr);
           



            
        }
    }
}
