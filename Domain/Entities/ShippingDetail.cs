using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ShippingDetail
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите как вас зовут")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Вставьте первый адрес доставки")]
        [Display(Name = "Адрес адрес")]
        public string Adress { get; set; }

        [Display(Name = "Номер телефона")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Укажите почту")]
        [Display(Name = "Почта")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Вы ввели некорректный email")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Укажите город")]
        [Display(Name = "Город")]
        public string City { get; set; }

        [Required(ErrorMessage = "Укажите страну")]
        [Display(Name = "Страна")]
        public string Country { get; set; }

        public string PartAndAmount { get; set; }

       
    }
}
