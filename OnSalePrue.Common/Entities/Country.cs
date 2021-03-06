﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnSalePrue.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe contener menos de {1} caracteres.")]
        [Required]
        [Display(Name = "Pais")]
        public string Name { get; set; }

        public ICollection<Department> Departments { get; set; }

        [DisplayName("Numero de Departamentos")]
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;

    }
}
