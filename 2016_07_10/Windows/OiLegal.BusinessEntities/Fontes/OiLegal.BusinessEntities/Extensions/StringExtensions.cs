using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal
{
    public static class StringExtensions
    {
        /// <summary>
        /// Verifica se uma string está nula ou vazia.
        /// </summary>
        /// <param name="value">Valor à ser verificado</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}
