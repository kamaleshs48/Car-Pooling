using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenCabV1.Models;
namespace GreenCabV1.Repository
{
    public interface IComman
    {
        int SaveDailyCarPool(DailyCabModels models);
        int SaveCorporateCarpool(CorporateCarpoolModels models);

    }
}
