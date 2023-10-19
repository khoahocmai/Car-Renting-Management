using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessObject;

namespace Repositories
{
    public class CarRepository: ICarRepository
    {
        public List<CarInformation> GetCarInformation() => CarInformationDAO.Instance.GetCarInformations();
        public CarInformation GetCarInformationById(int id) => CarInformationDAO.Instance.GetCarInformationById(id);
        public List<CarInformation> GetCarInformationByString(string value) => CarInformationDAO.Instance.GetCarInformationByString(value);
        public List<CarInformation> GetCarInformationByCarRentingPricePerDay(decimal price)
        => CarInformationDAO.Instance.GetCarInformationByCarRentingPricePerDay(price);
        public void InsertCar(CarInformation car) => CarInformationDAO.Instance.SaveCarInformation(car);
        public void DeleteCar(CarInformation car) => CarInformationDAO.Instance.RemoveCarInformation(car);
        public void UpdateCar(CarInformation car) => CarInformationDAO.Instance.UpdateCarInformation(car);
    }
}
