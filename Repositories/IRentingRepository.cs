using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRentingRepository
    {
        List<RentingTransaction> GetRentingTransactions();
        List<RentingTransaction> GetRentingTransactionByCusId(int id);
        void SaveRentTrans(RentingTransaction rt);
        void UpdateRentTrans(RentingTransaction rt);
        void RemoveRentTrans(RentingTransaction rt);
        List<RentingDetail> GetRentingDetails();
        List<RentingDetail> SearchByDate(DateTime fDate);
        void SaveRentingDetail(RentingDetail rtDetail);
        void UpdateRentingDetail(RentingDetail rtDetail);
        void RemoveRentingDetail(RentingDetail rtDetail);

    }
}
