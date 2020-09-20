using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnSalePrue.Common.Entities
{
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe contener menos de {1} caracteres.")]
        [Required]
        [Display(Name = "Departamento")]
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }

        [DisplayName("Numero de Provincias")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;

        [JsonIgnore]
        [NotMapped]
        public int IdCountry { get; set; }
    }

}
