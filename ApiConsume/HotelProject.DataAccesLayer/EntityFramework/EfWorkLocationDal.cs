﻿using HotelProject.DataAccesLayer.Abstract;
using HotelProject.DataAccesLayer.Concrete;
using HotelProject.DataAccesLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.EntityFramework
{
    public class EfWorkLocationDal : GenericRepository<WorkLocation>, IWorkLocationDal
    {

        public EfWorkLocationDal(Context context) : base(context)
        {

        }
    }
}
