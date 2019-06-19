using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using OfficeOnline.Entities.Concrete;

namespace OfficeOnline.Business.ValidationRules.FluentValidation
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.PersonName).NotEmpty().WithMessage("Ürün İsmi Bol Olamaz");// Ürün İsmi Gİrmen Gerekiyor. ve Uyarı Verdirdik.
            //Uyarı Mesajları Bölgeseldir. 19 dilde destek verir.
            RuleFor(p => p.SurName).NotEmpty();// Girmen Gerekiyor Boş Geçilemez
            RuleFor(p => p.UserName).NotEmpty();// Girmen Gerekiyor Boş Geçilemez 
            RuleFor(p => p.UserPassword).NotEmpty();// Girmen Gerekiyor Boş Geçilemez 

            //RuleFor(p => p.UnitPrice).GreaterThan(0);// 0'dan Büyük Olmalıdır.
            //RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);// Ürün Stokta yok tedarik edebilirsiniz.
            //RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);// Kategory Id 2 olduğunda Unit Price 10'dan büyük olmalıdır.

            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün Adı A ile Başlamalıdır.");//Kendi Validator Kodumuzu Yazdık. ProductName'ler A ile Başlamalıdır.
        }

        private bool StartWithA(String arg)
        {
            return arg.StartsWith("");
        }
    }
}
