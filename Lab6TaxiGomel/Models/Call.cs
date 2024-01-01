using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab6TaxiGomel.Models
{
    public partial class Call
    {
        public int CallId { get; set; }
        [Display(Name = "Время вызова")]
        [Required(ErrorMessage = "Время вызова не указано")]
        public DateTime CallTime { get; set; }
        [Display(Name = "Телефон клиента")]
        [StringLength(11, MinimumLength = 7)]
        public string? Telephone { get; set; }
        [Display(Name = "Адрес отправления")]
        [StringLength(25, MinimumLength = 7)]
        public string? StartPosition { get; set; }
        [Display(Name = "Адрес доставки")]
        [StringLength(25, MinimumLength = 7)]
        public string? EndPosition { get; set; }
        [Display(Name = "Тариф")]
        public int? RateId { get; set; }
        [Display(Name = "Автомобиль")]
        public int? CarId { get; set; }
        [Display(Name = "Диспетчер")]
        public int? DispatcherId { get; set; }

        public virtual Car? Car { get; set; }
        public virtual Employee? Dispatcher { get; set; }
        public virtual Rate? Rate { get; set; }
    }
}
