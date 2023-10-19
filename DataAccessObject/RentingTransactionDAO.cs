using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class RentingTransactionDAO
    {
        private static RentingTransactionDAO instance = null;
        public static readonly object Lock = new object();
        private RentingTransactionDAO() { }
        public static RentingTransactionDAO Instance
        {
            get
            {
                lock (Lock)
                {
                    if (instance == null)
                    {
                        instance = new RentingTransactionDAO();
                    }
                    return instance;
                }
            }
        }
        public List<RentingTransaction> GetRentingTransactions()
        {
            using var db = new FUCarRentingManagementContext();
            return db.RentingTransactions
                    .Include(m => m.Customer)
                    .ToList();
        }// Lấy ra danh sách các Renting Transaction      
        public List<RentingTransaction> GetRentingTransactionByCusId(int id)
        {
            var tmp = GetRentingTransactions().FindAll(m => m.CustomerId == id);
            return tmp;
        }// Lấy Renting Transaction theo CustomerId
        public void SaveRentingTransaction(RentingTransaction rt)
        {
            using var db = new FUCarRentingManagementContext();
            db.RentingTransactions.Add(rt);
            db.SaveChanges();
        }// Lưu Renting Transaction
        public void UpdateRentingTransaction(RentingTransaction rt)
        {
            using var db = new FUCarRentingManagementContext();
            db.RentingTransactions.Update(rt);
            db.SaveChanges();
        }// Cập nhật Renting Transaction
        public void RemoveRentingTransaction(RentingTransaction rt)
        {
            using var db = new FUCarRentingManagementContext();
            var c1 = db.RentingTransactions.SingleOrDefault(m => m.RentingTransationId == rt.RentingTransationId);
            db.RentingTransactions.Remove(c1);
            db.SaveChanges();
        }// Xóa Renting Transaction

        public List<RentingDetail> GetRentingDetails()
        {
            using var db = new FUCarRentingManagementContext();
            return db.RentingDetails.ToList();
        }// Lấy tất cả Renting Detail
        public List<RentingDetail> SearchByDate(DateTime fDate)
        {
            var tmp = GetRentingDetails().FindAll(a => a.StartDate < fDate && a.EndDate < fDate);
            return tmp;
        }// Search bằng ngày 
        public void SaveRentingDetail(RentingDetail rtDetail)
        {
            using var db = new FUCarRentingManagementContext();
            db.RentingDetails.Add(rtDetail);
            db.SaveChanges();
        }// Lưu Renting Detail
        public void UpdateRentingDetail(RentingDetail rtDetail)
        {
            using var db = new FUCarRentingManagementContext();
            db.RentingDetails.Update(rtDetail);
            db.SaveChanges();
        }// Cập nhật Renting Detail
        public void RemoveRentingDetail(RentingDetail rtDetail)
        {
            using var db = new FUCarRentingManagementContext();
            var c1 = db.RentingDetails.SingleOrDefault(m => m.RentingTransactionId == rtDetail.RentingTransactionId);
            db.RentingDetails.Remove(c1);
            db.SaveChanges();
        }// Xóa Renting Detail
    }
}
