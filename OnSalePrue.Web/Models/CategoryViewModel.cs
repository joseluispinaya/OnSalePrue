using Microsoft.AspNetCore.Http;
using OnSalePrue.Common.Entities;
using System.ComponentModel.DataAnnotations;

namespace OnSalePrue.Web.Models
{
    public class CategoryViewModel : Category
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
