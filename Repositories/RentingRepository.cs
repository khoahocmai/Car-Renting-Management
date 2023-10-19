using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RentingRepository : IRentingRepository
    {
        public List<RentingTransaction> GetRentingTransactions() => RentingTransactionDAO.Instance.GetRentingTransactions();
        public List<RentingTransaction> GetRentingTransactionByCusId(int id) => RentingTransactionDAO.Instance.GetRentingTransactionByCusId(id);
        public void SaveRentTrans(RentingTransaction rt) => RentingTransactionDAO.Instance.SaveRentingTransaction(rt);
        public void UpdateRentTrans(RentingTransaction rt) => RentingTransactionDAO.Instance.UpdateRentingTransaction(rt);
        public void RemoveRentTrans(RentingTransaction rt) => RentingTransactionDAO.Instance.RemoveRentingTransaction(rt);
        public List<RentingDetail> GetRentingDetails() => RentingTransactionDAO.Instance.GetRentingDetails();
        public List<RentingDetail> SearchByDate(DateTime fDate) => RentingTransactionDAO.Instance.SearchByDate(fDate);
        public void SaveRentingDetail(RentingDetail rtDetail) => RentingTransactionDAO.Instance.SaveRentingDetail(rtDetail);
        public void UpdateRentingDetail(RentingDetail rtDetail) => RentingTransactionDAO.Instance.UpdateRentingDetail(rtDetail);
        public void RemoveRentingDetail(RentingDetail rtDetail) => RentingTransactionDAO.Instance.RemoveRentingDetail(rtDetail);
    }
}
