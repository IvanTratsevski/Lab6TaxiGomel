using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Lab6TaxiGomel.Models
{
    public partial class Employee
    {

        public int EmployeeId { get; set; }
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Имя не указано")]
        [StringLength(20, MinimumLength = 2)]
        public string? FirstName { get; set; }
        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Фамилия не указана")]
        [StringLength(20, MinimumLength = 2)]
        public string? LastName { get; set; }
        [Display(Name = "Возраст")]
        [Required(ErrorMessage = "Возраст не указан")]
        [Range(18, 100)]
        public int? Age { get; set; }
        [Display(Name = "Должность")]
        [Required(ErrorMessage = "Должность не указана")]
        public int? PositionId { get; set; }
        [Display(Name = "Стаж")]
        [Required(ErrorMessage = "Стаж не указана")]
        [Range(0, 100)]
        public int? Experience { get; set; }
        [JsonIgnore]
        public virtual ICollection<Call> Calls { get; set; }
    }
}
