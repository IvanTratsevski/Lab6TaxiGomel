using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Lab6TaxiGomel.Models
{
    public partial class Car
    {

        public int CarId { get; set; }
        [Display(Name = "Регистрационный номер")]
        [Required(ErrorMessage = "Регистрационный номер не указан")]
        [StringLength(11, MinimumLength = 7)]
        public string? RegistrationNumber { get; set; }
        [Display(Name = "Марка")]
        [Required(ErrorMessage = "Марка автомобиля не указан")]
        public int? CarModelId { get; set; }
        [Display(Name = "Номер корпуса")]
        [Required(ErrorMessage = "Номер корпуса не указан")]
        [StringLength(11, MinimumLength = 7)]
        public string? CarcaseNumber { get; set; }
        [Display(Name = "Номер двигателя")]
        [Required(ErrorMessage = "Номер двигателя не указан")]
        [StringLength(11, MinimumLength = 7)]
        public string? EngineNumber { get; set; }
        [Display(Name = "Дата производства")]
        [Required(ErrorMessage = "Дата производства не указана")]
        [DataType(DataType.Date)]
        public DateTime? ReleaseYear { get; set; }
        [Display(Name = "Пробег")]
        [Required(ErrorMessage = "Пробег не указан")]
        [Range(1, 500000)]
        public int? Mileage { get; set; }
        [Display(Name = "Последний тех. осмотр")]
        [Required(ErrorMessage = "Дата тех. осмотра не указана")]
        [DataType(DataType.Date)]
        public DateTime? LastTi { get; set; }
        [Display(Name = "Особые отметки")]
        public string? SpecialMarks { get; set; }
        [JsonIgnore]
        public virtual ICollection<Call> Calls { get; set; }
    }
}
