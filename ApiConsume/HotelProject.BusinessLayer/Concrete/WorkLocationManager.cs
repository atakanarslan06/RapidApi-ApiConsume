using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccesLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDal _worlocationDal;

        public WorkLocationManager(IWorkLocationDal worlocationDal)
        {
            _worlocationDal = worlocationDal;
        }

        public void TDelete(WorkLocation t)
        {
            _worlocationDal.Delete(t);
        }

        public WorkLocation TGetById(int id)
        {
            return _worlocationDal.GetById(id); 
        }

        public List<WorkLocation> TGetList()
        {
            return _worlocationDal.GetList();
        }

        public void TInsert(WorkLocation t)
        {
            _worlocationDal.Insert(t);
        }

        public void TUpdate(WorkLocation t)
        {
            _worlocationDal.Update(t);
        }
    }
}
