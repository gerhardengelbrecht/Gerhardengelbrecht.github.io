using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            //if (customer.BirthDate == null)
            //{
            //    return new ValidationResult("Birthdate is required.");
            //}

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }

            var age = DateTime.Today.Year - customer.BirthDate.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Age should be at lease 18.");
        }
    }
}