using System.ComponentModel.DataAnnotations;

namespace SlnIannielloRocio.Validations
{
    public class ValidCategory : ValidationAttribute
    {
        public ValidCategory()
        {
            ErrorMessage = "La categoria solo puede ser desayuno";
        }
        public override bool IsValid(object value)
        {
            string categoria = (string)value;
            if (categoria.ToUpper() == "DESAYUNO")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
