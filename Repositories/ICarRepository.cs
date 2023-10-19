using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICarRepository
    {
        List<CarInformation> GetCarInformation();
        CarInformation GetCarInformationById(int id);
        List<CarInformation> GetCarInformationByString(string value);
        List<CarInformation> GetCarInformationByCarRentingPricePerDay(decimal price);
        void InsertCar(CarInformation car);
        void DeleteCar(CarInformation car);
        void UpdateCar(CarInformation car);
    }
}
