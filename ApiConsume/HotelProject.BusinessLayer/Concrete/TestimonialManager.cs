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
    partial class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialsDal _testimonialsDal;

        public TestimonialManager(ITestimonialsDal testimonialsDal)
        {
            _testimonialsDal = testimonialsDal;
        }

        public void TDelete(Testimonial t)
        {
            _testimonialsDal.Delete(t);
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialsDal.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialsDal.GetList();
        }

        public void TInsert(Testimonial t)
        {
            _testimonialsDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialsDal.Update(t);
        }
    }
}
