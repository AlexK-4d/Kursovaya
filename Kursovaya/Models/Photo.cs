using System.ComponentModel.DataAnnotations;

namespace Kursovaya.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }

        [Display(Name = "Фотография")]
        public IFormFile? Image { get; set; }

        public int AdvertismentId { get; set; }

        public Advertisment? Advertisment { get; set; }

    }
}
