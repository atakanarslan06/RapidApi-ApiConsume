using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Servis ikon linki giriniz")]   
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        public string Title { get; set; }

        
        public string Description { get; set; }
    }
}
