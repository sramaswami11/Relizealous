using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Relizealous.Data
{
    public static class Adhikaram
    {
        public enum AdhikaramName
        {
            //[Description("கடவுள் வாழ்த்து")]
            Kadavulvaazthu,
            வான்சிறப்பு,
            நீத்தார்_பெருமை,
            அறன்_வலியுறுத்தல்
        }

        public static string ToDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
