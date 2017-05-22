using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidley.Models
{
    public class StockBetween1And20 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            //if (movie.NumberInStock == null)
                //return new ValidationResult("A Number in Stock is required");

            return (movie.NumberInStock >= 1 || movie.NumberInStock < 20) ? ValidationResult.Success : new ValidationResult("Number in Stock must be between 1 and 20");
        }
    }
}
