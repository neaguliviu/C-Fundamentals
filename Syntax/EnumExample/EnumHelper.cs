namespace EnumExample
{
    using System;
    using System.ComponentModel;
    using System.Reflection;

    public class EnumHelper
    {
        public static string EnumTypeDescription(Enum enumType)
        {
            // FieldInfo: discover the attribute of a field and provide access to field metadata
            FieldInfo fi = enumType.GetType().GetField(enumType.ToString());
            // DescriptionAttribute: specify a description for a property or event
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return enumType.ToString();
            }
        }

    }
}
