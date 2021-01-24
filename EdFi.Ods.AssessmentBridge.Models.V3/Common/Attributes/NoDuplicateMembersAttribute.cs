using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EdFi.Ods.Api.Validation
{
    public sealed class NoDuplicateMembersAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var enumerable = value as IEnumerable;

            if (enumerable == null)
            {
                return ValidationResult.Success;
            }

            var i = 0;
            var enumerableHashSet = new HashSet<object>();

            foreach (var item in enumerable)
            {
                if (item != null)
                {
                    if (!enumerableHashSet.Add(item))
                    {
                        return
                            new ValidationResult(
                                string.Format(
                                    "{0} enumerable contains duplicate at index: {1}",
                                    validationContext.DisplayName,
                                    i));
                    }
                }

                i++;
            }

            // If we're still here, validation was successful
            return ValidationResult.Success;
        }
    }
}
