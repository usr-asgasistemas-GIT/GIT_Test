#region Using

using System;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Usuario.GraficoConfiguracao
{
    [Serializable]
    public class GraficoConfiguracoes
    {

        #region Atributos

        private int _graficoConfiguracoesID;
        private EnumColunaChamada _enumColunaAgrupamento;
        private EnumMedicao _enumMedicao;
        private EnumGrafico _enumGrafico;

        #endregion

        #region Construtores

        public int GraficoConfiguracoesID
        {
            get { return _graficoConfiguracoesID; }
            set { _graficoConfiguracoesID = value; }
        }

        public GraficoConfiguracoes()
        {
        }

        public GraficoConfiguracoes(int graficoConfiguracoesID, EnumColunaChamada enumColunaAgrupamento, EnumMedicao enumMedicao, EnumGrafico enumGrafico)
        {
            GraficoConfiguracoesID = graficoConfiguracoesID;
            EnumColunaAgrupamento = enumColunaAgrupamento;
            EnumMedicao = enumMedicao;
            EnumGrafico = enumGrafico;
        }

        public GraficoConfiguracoes(EnumColunaChamada enumColunaAgrupamento, EnumMedicao enumMedicao, EnumGrafico enumGrafico)
        {
            EnumColunaAgrupamento = enumColunaAgrupamento;
            EnumMedicao = enumMedicao;
            EnumGrafico = enumGrafico;
        }

        #endregion

        #region Propriedades

        public EnumColunaChamada EnumColunaAgrupamento
        {
            get { return _enumColunaAgrupamento; }
            set { _enumColunaAgrupamento = value; }
        }
        
        public EnumMedicao EnumMedicao
        {
            get { return _enumMedicao; }
            set { _enumMedicao = value; }
        }
        
        public EnumGrafico EnumGrafico
        {
            get { return _enumGrafico; }
            set { _enumGrafico = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (! (obj is GraficoConfiguracoes))
            {
                return false;
            }

            GraficoConfiguracoes graficoConfiguracoes = (GraficoConfiguracoes)obj;
            if (graficoConfiguracoes.EnumColunaAgrupamento != EnumColunaAgrupamento)
            {
                return false;
            }
            if (graficoConfiguracoes.EnumGrafico != EnumGrafico)
            {
                return false;
            }
            if (graficoConfiguracoes.EnumMedicao != EnumMedicao)
            {
                return false;
            }
            return true;
        }

        public void CopySettings(GraficoConfiguracoes configuracoes)
        {
            if (configuracoes == null)
            {
                return;
            }

            EnumColunaAgrupamento = configuracoes.EnumColunaAgrupamento;
            EnumMedicao = configuracoes.EnumMedicao;
            EnumGrafico = configuracoes.EnumGrafico;
        }

        #endregion

    }
}