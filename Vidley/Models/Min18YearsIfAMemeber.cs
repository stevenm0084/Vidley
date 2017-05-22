using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Vidley.Models
{
    public class Min18YearsIfAMemeber : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            
            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthday is required");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Customer should be 18 years or older to be on membership");
        }
    }
}
