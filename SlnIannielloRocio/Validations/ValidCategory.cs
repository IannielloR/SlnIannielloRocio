using System.ComponentModel.DataAnnotations;

namespace SlnIannielloRocio.Validations
{
    public class ValidCategory : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            if (value.ToString() != "Desayuno")
            {
                return new ValidationResult("Solo se permite ingresar la categoría desayuno!");
            }

            return ValidationResult.Success;
        }
    }
}
