using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Lab6TaxiGomel.Models
{
    public partial class Position
    {

        public int PositionId { get; set; }
        [Display(Name = "Должность")]
        [Required(ErrorMessage = "Должность не указана")]
        [StringLength(30, MinimumLength = 7)]
        public string? PositionName { get; set; }
        [Display(Name = "Заработная плата")]
        [Required(ErrorMessage = "Заработная плата не указана")]
        [Range(1, 100000)]
        public decimal? Salary { get; set; }
        [JsonIgnore]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
