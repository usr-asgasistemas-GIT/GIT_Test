#region using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado
{
    /// <summary>
    /// Classe que representa uma chamada de categoria móvel com todos os dados do arquivo de retorno.
    /// </summary>
    [Serializable]
    public class ChamadaMovelCompleta
    {

        #region Propriedades

        public String NaFormatado { get; set; }
        public String NbFormatado { get; set; }
        public String Apn_Code { get; set; }
        public String Apn { get; set; }
        public String Aportado { get; set; }
        public String Bairro { get; set; }
        public String Bportado { get; set; }
        public String Cause_Term { get; set; }
        public String Celula { get; set; }
        public String Central { get; set; }
        public String Cn { get; set; }
        public String Cn_Celula { get; set; }
        public String Cnl_A { get; set; }
        public String Cnl_B { get; set; }
        public DateTime? Datahora { get; set; }
        public String Desc_Vpn { get; set; }
        public String Duracao { get; set; }
        public String Efficiencyind { get; set; }
        public String Endereco { get; set; }
        public String Eot_A { get; set; }
        public String Eot_B { get; set; }
        public String Flag_A_Portado { get; set; }
        public String Flag_B_Portado { get; set; }
        public String Gmt { get; set; }
        public String Gtt { get; set; }
        public String Identificadorchamada { get; set; }
        public String Imei { get; set; }
        public String Imsi { get; set; }
        public String Ind_Acb { get; set; }
        public String Ind_Agreg { get; set; }
        public String Ind_Free { get; set; }
        public String Ind_Pre { get; set; }
        public String Ind_Roam { get; set; }
        public String Ind_Serviços { get; set; }
        public String Ind_Vc { get; set; }
        public String Indsups { get; set; }
        public String Lac { get; set; }
        public String Latitude { get; set; }
        public String Longitude { get; set; }
        public String Mcc { get; set; }
        public String Mnc { get; set; }
        public String Msc { get; set; }
        public String Municipio { get; set; }
        public String Num_A_Msisdn { get; set; }
        public String Num_A_Ton { get; set; }
        public String Num_B_Msisdn { get; set; }
        public String Num_B_Ton { get; set; }
        public String Num_C_Msisdn { get; set; }
        public String Origem { get; set; }
        public String Origemcdr { get; set; }
        public String Parceiro { get; set; }
        public String Rota { get; set; }
        public String Rotaentrada { get; set; }
        public String Rotasaida { get; set; }
        public String Siteid { get; set; }
        public String Tecnologia { get; set; }
        public String Tipo_De_Uso { get; set; }
        public String Tipoacesso { get; set; }
        public String Tipocdr { get; set; }
        public String Uf { get; set; }
        public String Volume { get; set; }
        public ERB.ERB Erb { get; set; }
        public string Erb_Uf { get; set; }
        public string Erb_Endereco { get; set; }
        public string Erb_Bairro { get; set; }
        public string Erb_Municipio { get; set; }
        public string IndSistema { get; set; }
        public string Info_OCS { get; set; }
        public string EfficiencyInd { get; set; }
        public string Flag_9digito_a { get; set; }
        public string Flag_9digito_b { get; set; }
        public Enums.TipoSentido Sentido { get; set; }
        public string Ip_addr_ipv6 { get; set; }

        #region PIL

        public String Pil_tipoCDR { get; set; }
        public String Pil_tecnologia { get; set; }
        public String Pil_indSistema { get; set; }
        public String Pil_numATON { get; set; }
        public String Pil_numAMSISDN { get; set; }
        public String Pil_imsi { get; set; }
        public String Pil_imei { get; set; }
        public String Pil_dataHora { get; set; }
        public String Pil_cn_celula { get; set; }
        public String Pil_duracao { get; set; }
        public String Pil_gtt { get; set; }
        public String Pil_rota { get; set; }
        public String Pil_indPre { get; set; }
        public String Pil_celula { get; set; }
        public String Pil_indRoam { get; set; }
        public String Pil_indFree { get; set; }
        public String Pil_indAgreg { get; set; }
        public String Pil_causeTerm { get; set; }
        public String Pil_numBTON { get; set; }
        public String Pil_numBMSISDN { get; set; }
        public String Pil_indACB { get; set; }
        public String Pil_indVC { get; set; }
        public String Pil_indServicos { get; set; }
        public String Pil_descVPN { get; set; }
        public String Pil_indSupS { get; set; }
        public String Pil_efficiencyInd { get; set; }
        public String Pil_origem { get; set; }
        public String Pil_EOT_A { get; set; }
        public String Pil_CNL_A { get; set; }
        public String Pil_Flag_A_Portado { get; set; }
        public String Pil_EOT_B { get; set; }
        public String Pil_CNL_B { get; set; }
        public String Pil_Flag_B_Portado { get; set; }
        public String Pil_Info_OCS { get; set; }
            
        #endregion

        #endregion

        #region Construtor

        public ChamadaMovelCompleta()
        {
            NaFormatado = null;
            NbFormatado = null;
            Apn_Code = null;
            Apn = null;
            Aportado = null;
            Bairro = null;
            Bportado = null;
            Cause_Term = null;
            Celula = null;
            Central = null;
            Cn = null;
            Cn_Celula = null;
            Cnl_A = null;
            Cnl_B = null;
            Datahora = null;
            Desc_Vpn = null;
            Duracao = null;
            Efficiencyind = null;
            Endereco = null;
            Eot_A = null;
            Eot_B = null;
            Flag_A_Portado = null;
            Flag_B_Portado = null;
            Gmt = null;
            Gtt = null;
            Identificadorchamada = null;
            Imei = null;
            Imsi = null;
            Ind_Acb = null;
            Ind_Agreg = null;
            Ind_Free = null;
            Ind_Pre = null;
            Ind_Roam = null;
            Ind_Serviços = null;
            Ind_Vc = null;
            Indsups = null;
            Lac = null;
            Latitude = null;
            Longitude = null;
            Mcc = null;
            Mnc = null;
            Msc = null;
            Municipio = null;
            Num_A_Msisdn = null;
            Num_A_Ton = null;
            Num_B_Msisdn = null;
            Num_B_Ton = null;
            Num_C_Msisdn = null;
            Origem = null;
            Origemcdr = null;
            Parceiro = null;
            Rota = null;
            Rotaentrada = null;
            Rotasaida = null;
            Siteid = null;
            Tecnologia = null;
            Tipo_De_Uso = null;
            Tipoacesso = null;
            Tipocdr = null;
            Uf = null;
            Volume = null;
            Erb = null;

            #region Pil

            Pil_tipoCDR = null;
            Pil_tecnologia = null;
            Pil_indSistema = null;
            Pil_numATON = null;
            Pil_numAMSISDN = null;
            Pil_imsi = null;
            Pil_imei = null;
            Pil_dataHora = null;
            Pil_cn_celula = null;
            Pil_duracao = null;
            Pil_gtt = null;
            Pil_rota = null;
            Pil_indPre = null;
            Pil_celula = null;
            Pil_indRoam = null;
            Pil_indFree = null;
            Pil_indAgreg = null;
            Pil_causeTerm = null;
            Pil_numBTON = null;
            Pil_numBMSISDN = null;
            Pil_indACB = null;
            Pil_indVC = null;
            Pil_indServicos = null;
            Pil_descVPN = null;
            Pil_indSupS = null;
            Pil_efficiencyInd = null;
            Pil_origem = null;
            Pil_EOT_A = null;
            Pil_CNL_A = null;
            Pil_Flag_A_Portado = null;
            Pil_EOT_B = null;
            Pil_CNL_B = null;
            Pil_Flag_B_Portado = null;
            Pil_Info_OCS = null;

            #endregion
        }

        #endregion

    }
}
