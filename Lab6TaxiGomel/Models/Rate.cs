using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Lab6TaxiGomel.Models
{
    public partial class Rate
    {

        public int RateId { get; set; }
        [Display(Name = "Тариф")]
        [Required(ErrorMessage = "Тариф не указан")]
        [StringLength(20, MinimumLength = 1)]
        public string? RateDescription { get; set; }
        [Display(Name = "Стоимость")]
        [Required(ErrorMessage = "Стоимость не указана")]
        [Range(1, 100)]
        public decimal? RatePrice { get; set; }
        [JsonIgnore]
        public virtual ICollection<Call> Calls { get; set; }
    }
}
