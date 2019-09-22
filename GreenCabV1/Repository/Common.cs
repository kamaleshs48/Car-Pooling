using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using GreenCabV1.Models;
namespace GreenCabV1.Repository
{
    public class Common : IComman
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

        public int SaveCarOwnerDetails(string name, string mobileNo, string city)
        {
            SqlParameter[] pr = new SqlParameter[]
           {

                new SqlParameter("@name",name),
                new SqlParameter("@Phone",mobileNo),
                new SqlParameter("@city",city),
                new SqlParameter("@Mode","SaveCarOwnerDetails")

           };


            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStr(), CommandType.StoredProcedure, "sp_Save_Corporate_Enquiry", pr);



        }


        public int SaveCorporateCarpool(CorporateCarpoolModels models)
        {
            SqlParameter[] pr = new SqlParameter[]
               {

                new SqlParameter("@Name",models.Name),
                new SqlParameter("@Phone",models.Phone),
                new SqlParameter("@Email",models.Email),
                new SqlParameter("@Comments",models.Comments),

                new SqlParameter("@Mode","Save"),


               };


            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStr(), CommandType.StoredProcedure, "sp_Save_Corporate_Enquiry", pr);


        }


        public int SaveContactUsData(ContactUsModels models)
        {
            SqlParameter[] pr = new SqlParameter[]
                {

                new SqlParameter("@FirstName",models.FirstName),
                new SqlParameter("@LastName",models.LastName),
                new SqlParameter("@MobileNo",models.MobileNo),
                new SqlParameter("@EmailID",models.EmailID),
                new SqlParameter("@Mode","Save"),
                };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStr(), CommandType.StoredProcedure, "sp_Save_ContactUsData", pr);
            return 1;
        }

        public int SaveNewLetterData(string Email)
        {

            string Qry = "Insert Into tbl_Newsletter (Email) values ('" + Email + "')";


            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStr(), CommandType.Text, Qry);
        }


    }
}
