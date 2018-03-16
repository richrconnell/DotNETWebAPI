using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using System.Web;
using MABrandProject.Models;

namespace MABrandProject.Data
{
    public class BrandRepository : IBrandRepository
    {
        private IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        //private readonly IDbConnection _db;

        public BrandRepository()
        {
            _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        public List<BrandData> GetClassification()
        {
            return this._db.Query<BrandData>("SELECT TOP 100 [brand_classification_name] FROM [Brand_Classification]").ToList();
        }

        public BrandData GetSingleClassification(int brand_classification_Id)
        {
            return _db.Query<BrandData>("SELECT[brand_classification_id],[brand_classification_name]", new { brand_classification_id = brand_classification_Id }).SingleOrDefault();
        }

        //public bool InsertClassification(BrandData ourClassification)
        //{
        //int rowsAffected = this._db.Execute(@")",
        //    new { CustomerFirstName = ourCustomer.CustomerFirstName, CustomerLastName = ourCustomer.CustomerLastName, IsActive = true });

        //if (rowsAffected > 0)
        //{
        //    return true;
        //}

        //return false;
        //}

        //    public bool DeleteClassification(int brand_classification_id);
        //    {
        //        int rowsAffected = this._db.Execute(@"",
        //            new { CustomerID = customerId });

        //        if (rowsAffected > 0)
        //        {
        //            return true;
        //        }

        //        return false;
        //    }

        //    public bool UpdateClassification(BrandData ourCustomer)
        //{
        //        int rowsAffected = this._db.Execute(
        //                    "");

        //        if (rowsAffected > 0)
        //        {
        //            return true;
        //        }

        //        return false;
        //    }
        //}
    }
}