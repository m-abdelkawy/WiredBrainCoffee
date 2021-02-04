using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace WiredBrainCoffee.CustomersApp.Model
{
    public class CustomerConverter:TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if(sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if(value is string inputString)
            {
                var lstValue = inputString.Split(',');
                return new Customer
                {
                    FirstName = lstValue[0],
                    LastName = lstValue[1],
                    IsDeveloper = bool.Parse(lstValue[2])
                };
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}
