#region Using

using System;
using System.Collections.Generic;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    public static class CalculadoraData
    {

        #region Propriedades

        public static DateTime CalcData(DateTime dataBase, CalculaDataOperador operador, short valorDoPrazo, string unidadeDoPazo)
        {
            switch (unidadeDoPazo.ToUpper())
            {
                case "HORA":
                case "HORAS":
                    return dataBase.AddHours(AplicaOperador(valorDoPrazo, operador));
                case "DIA":
                case "DIAS":
                    return dataBase.AddDays(AplicaOperador(valorDoPrazo, operador));
                case "MÊS":
                case "MESES":
                    return dataBase.AddMonths(AplicaOperador(valorDoPrazo, operador));
                case "ANO":
                case "ANOS":
                    return dataBase.AddYears(AplicaOperador(valorDoPrazo, operador));
            }
            throw new Exception("CalculadoraDataType Inválido");
        }

        private static int AplicaOperador(int valor, CalculaDataOperador operador)
        {
            if (operador == CalculaDataOperador.Subtrair)
            {
                return (valor * -1);
            }
            return valor;
        }
        #endregion

    }
}