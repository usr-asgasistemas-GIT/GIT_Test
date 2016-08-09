using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Requisicao;

namespace AsgaSistemas.saga.CE.OiLegal
{
    public static class EnumExtension
    {
        /// <summary>
        /// Converte uma string em um Enum existente
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T ParseEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        /// <summary>
        /// Converte o valor do enum em inteiro
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToInt32(this Enum value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>
        /// Converte o valor inteiro do enum em string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FromInt32ToString(this Enum value)
        {
            int valorInteiro = Convert.ToInt32(value);
            return valorInteiro.ToString();
        }

        public static TAttribute GetAttribute<TAttribute>(this Enum value)
            where TAttribute : Attribute
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            return type.GetField(name) // I prefer to get attributes this way
                .GetCustomAttributes(false)
                .OfType<TAttribute>()
                .SingleOrDefault();
        }

        public static string GetEnumDescription(this Enum e)
        {
            var attr = e.GetAttribute<DescriptionAttribute>();
            return attr.Description;
        }
    }
}
