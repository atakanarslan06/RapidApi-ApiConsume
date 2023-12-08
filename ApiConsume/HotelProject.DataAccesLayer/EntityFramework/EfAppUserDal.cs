﻿using HotelProject.DataAccesLayer.Abstract;
using HotelProject.DataAccesLayer.Concrete;
using HotelProject.DataAccesLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {

        }

        public int AppuserCount()
        {
            var context = new Context();
            var value = context.Users.Count();
            return value;
        }
        public List<AppUser> UserListWithWorkLocation()
        {
            var context = new Context();
            return context.Users.Include(x=>x.WorkLocation).ToList();
        }
    }
}
