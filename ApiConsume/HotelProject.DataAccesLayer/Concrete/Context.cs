﻿using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=ATAKAN\\MYBLOG;Database=ApiDb;Integrated Security=false;");
            //optionsBuilder.UseSqlServer("server=ATAKAN\\MYBLOG;initial catalog=ApiDb;integrated security:true");
            //optionsBuilder.UseSqlServer("Server=ATAKAN\\MYBLOG;Database=ApiDb;Trusted_Connection=;");
            
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
//Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;