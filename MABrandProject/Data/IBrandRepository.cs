using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MABrandProject.Models;

namespace MABrandProject.Data
{
    interface IBrandRepository
    {
        List<BrandData> GetClassification();

        BrandData GetSingleClassification(int brand_classification_Id);

        //bool InsertClassification(BrandData ourClassification);

        //bool DeleteClassification(int brand_classification_id);

        //bool UpdateClassification(BrandData ourCustomer);
    }
}


