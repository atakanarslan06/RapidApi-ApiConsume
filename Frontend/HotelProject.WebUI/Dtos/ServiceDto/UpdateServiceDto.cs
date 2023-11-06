﻿using System.ComponentModel.DataAnnotations;
using Xunit.Abstractions;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Servis ikon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Hizmet açıklaması giriniz")]
        public string Description { get; set; }
    }
}
