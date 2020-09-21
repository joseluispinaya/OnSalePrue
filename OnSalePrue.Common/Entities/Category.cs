using System;
using System.ComponentModel.DataAnnotations;

namespace OnSalePrue.Common.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe contener menos de {1} caracteres.")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Imagen")]
        public Guid ImageId { get; set; }

        //TODO: Pending to put the correct paths
        [Display(Name = "Imagen")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44328/images/noimage.png"
            : $"https://onsalejose.blob.core.windows.net/categories/{ImageId}";
    }

}
