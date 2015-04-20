namespace EnumExample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;

    public class EnumHelper
    {
        public static string EnumTypeDescription(Enum EnumType)
        {
            // FieldInfo: discover the attribute of a field and provide access to field metadata
            FieldInfo fi = EnumType.GetType().GetField(EnumType.ToString());
            // DescriptionAttribute: specify a description for a property or event
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return EnumType.ToString();
            }
        }

    }
}
