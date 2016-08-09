#region using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado
{
    /// <summary>
    /// Classe que representa uma chamada de categoria fixa com todos os dados do arquivo de retorno.
    /// </summary>
    [Serializable]
    public class ChamadaFixaCompleta
    {

        #region Propriedades

        public String Assinante_A { get; set; }
        public String Assinante_B { get; set; }
        public String Categoria { get; set; }
        public String Cod_Empresa_Assinante_A { get; set; }
        public String Cod_Empresa_Assinante_B { get; set; }
        public String Cod_Uf_Assinante_A { get; set; }
        public String Cod_Uf_Assinante_B { get; set; }
        public String Csp { get; set; }
        public DateTime? Datahora { get; set; }
        public String Duracao { get; set; }
        public String Estado_Chamada { get; set; }
        public String Ind_Atendimento { get; set; }
        public String Ind_Tipo_Chamada_Vpn { get; set; }
        public String Indicador_Tldn { get; set; }
        public String Parte_Tarifada { get; set; }
        public String Tipo_Terminal_A { get; set; }
        public String Tipo_Terminal_B { get; set; }

        #region Ama 91

        public String VozAma91_Codigo { get; set; }
        public String VozAma91_SiglaBil { get; set; }
        public String VozAma91_DataInicioReferencia { get; set; }
        public String VozAma91_DataFimReferencia { get; set; }
        public String VozAma91_HoraInicioReferencia { get; set; }
        public String VozAma91_HoraFimReferencia { get; set; }
        public String VozAma91_IdentSequencia { get; set; }
        public String VozAma91_NumSequencia { get; set; }
        public String VozAma91_Vago { get; set; }

        public String VozAma91_COD_REGISTRO { get; set; }
        public String VozAma91_NUM_ORIGEM { get; set; }
        public String VozAma91_PARTE_TARIFADA { get; set; }
        public String VozAma91_CATEGORIA { get; set; }
        public String VozAma91_NUM_DESTINO { get; set; }
        public String VozAma91_FIM_SELECAO { get; set; }
        public String VozAma91_HORA_INICIO { get; set; }
        public String VozAma91_DURACAO { get; set; }
        public String VozAma91_DATA_INICIO { get; set; }
        public String VozAma91_FATIAMENTO { get; set; }
        public String VozAma91_ROTA_ENTRADA { get; set; }
        public String VozAma91_JUNTOR_ENTRADA { get; set; }
        public String VozAma91_ROTA_SAIDA { get; set; }
        public String VozAma91_JUNTOR_SAIDA { get; set; }
        public String VozAma91_CLASSE_CHAMADA { get; set; }
        public String VozAma91_COD_EVENTO { get; set; }
        public String VozAma91_CONFIABILIDADE { get; set; }
        public String VozAma91_TIPO_TARIFA { get; set; }
        public String VozAma91_FILLER { get; set; }
        public String VozAma91_COD_BIL { get; set; }
        public String VozAma91_COD_OPER { get; set; }
        public String VozAma91_ANUF { get; set; }
        public String VozAma91_FIM_ARQ { get; set; }

        public String VozAma91_TOTAL_REGISTROS { get; set; }

        #endregion

        #region Ama 80

        public String VozAma80_Assinante_A {get; set;}
        public String VozAma80_Parte_Tarifada { get; set; }
        public String VozAma80_Categoria { get; set; }
        public String VozAma80_Assinante_B { get; set; }
        public String VozAma80_Fds { get; set; }
        public String VozAma80_Hora_Inicio { get; set; }
        public String VozAma80_Duracao { get; set; }
        public String VozAma80_Data_Inicio { get; set; }
        public String VozAma80_Causa_Saida { get; set; }
        public String VozAma80_Contador_Saidas_Parciais { get; set; }
        public String VozAma80_Rota_Entrada { get; set; }
        public String VozAma80_Juntor_Entrada { get; set; }
        public String VozAma80_Rota_Saida { get; set; }
        public String VozAma80_Juntor_Saida { get; set; }
        public String VozAma80_Classe { get; set; }
        public String VozAma80_Rdsi { get; set; }
        public String VozAma80_Bl_Sigla_Bilhetador { get; set; }

        #endregion

        #region AMA 128

        public String VozAma128_Assinante_A { get; set; }
        public String VozAma128_Nadi_Assinante_A { get; set; }
        public String VozAma128_Categoria { get; set; }
        public String VozAma128_Assinante_B { get; set; }
        public String VozAma128_Nadi_Assinante_B { get; set; }
        public String VozAma128_Data_Inicio { get; set; }
        public String VozAma128_Hora_Inicio { get; set; }
        public String VozAma128_Duracao { get; set; }
        public String VozAma128_Ind_Chamada_Adicional { get; set; }
        public String VozAma128_Ind_Desvio { get; set; }
        public String VozAma128_Classe { get; set; }
        public String VozAma128_Fds { get; set; }
        public String VozAma128_Ind_Localizacao_Desconexao { get; set; }
        public String VozAma128_Ind_Causa_Desconexao { get; set; }
        public String VozAma128_Ind_Atendimento { get; set; }
        public String VozAma128_Parte_Tarifada { get; set; }
        public String VozAma128_Ind_Liberacao { get; set; }
        public String VozAma128_Identificador_Central { get; set; }
        public String VozAma128_Causa_Saida { get; set; }
        public String VozAma128_Contador_Saidas_Parciais { get; set; }
        public String VozAma128_Tipo_Registro { get; set; }
        public String VozAma128_Rota_Entrada { get; set; }
        public String VozAma128_Juntor_Entrada { get; set; }
        public String VozAma128_Rota_Saida { get; set; }
        public String VozAma128_Juntor_Saida { get; set; }
        public String VozAma128_Cod_Evento { get; set; }
        public String VozAma128_Confiabilidade_Relogio { get; set; }
        public String VozAma128_Ind_Assinante { get; set; }
        public String VozAma128_Tipo_Bilhetagem { get; set; }
        public String VozAma128_Reserva { get; set; }

        #endregion

        #region AMA 111

        public String VozAma111_Tipo_Reg_Verificacao { get; set; }
        public String VozAma111_Digito_Verificador { get; set; }
        public String VozAma111_Tipo_Reg { get; set; }
        public String VozAma111_Stado_Chamada { get; set; }
        public String VozAma111_Causa_Saida { get; set; }
        public String VozAma111_Assinante_A { get; set; }
        public String VozAma111_Assinante_B { get; set; }
        public String VozAma111_Categoria { get; set; }
        public String VozAma111_Fds { get; set; }
        public String VozAma111_Parte_Tarifada { get; set; }
        public String VozAma111_Data_Inicio { get; set; }
        public String VozAma111_Hora_Inicio { get; set; }
        public String VozAma111_Duracao { get; set; }
        public String VozAma111_Codigo_Falha { get; set; }
        public String VozAma111_Ind_Erro_Rota { get; set; }
        public String VozAma111_Contador_Saidas_Parciais { get; set; }
        public String VozAma111_Num_Abreviado { get; set; }
        public String VozAma111_Filler_Rota_Saida { get; set; }
        public String VozAma111_Rota_Saida { get; set; }
        public String VozAma111_Juntor_Saida { get; set; }
        public String VozAma111_Filler_Rota_Entrada { get; set; }
        public String VozAma111_Rota_Entrada { get; set; }
        public String VozAma111_Juntor_Entrada { get; set; }
        public String VozAma111_Ind_Desconexao_Anormal { get; set; }
        public String VozAma111_Tipo_Procedimento_Assinante { get; set; }
        public String VozAma111_Ind_Assinante { get; set; }
        public String VozAma111_Csp { get; set; }
        public String VozAma111_Assinante_C { get; set; }
        public String VozAma111_Ind_Tipo_Chamada_Vpn { get; set; }

        #endregion

        #region Ama 550

        public String Flag_9digito_a { get; set; }
        public String Flag_9digito_b { get; set; }
        public String Flag_9digito_c { get; set; }
        public Enums.TipoSentido Sentido { get; set; }
        //public string TecnologiaCDR { get; set; }
        //public string NC { get; set; }
        //public string NumeroTerminalOrigemEncaminhada { get; set; }
        //public string TipoRegistro { get; set; }
        //public string OrigemCDR { get; set; }
        //public string Aportado { get; set; }
        //public string Bportado { get; set; }
        //public string Latitude { get; set; }
        //public string Longitude { get; set; }
        //public string NumeroOrigemFormatado { get; set; }
        //public string NaFormatado { get; set; }
        //public string NbFormatado { get; set; }
        //public string NaOuNbFormatado { get; set; }
        //public string NaOuOrigemFormatado { get; set; }

        public string Ama550_Area_Tarifaria_A { get; set; }
        public string Ama550_Area_Tarifaria_B { get; set; }
        public string Ama550_Flag_Ajuste { get; set; }
        public string Ama550_Mcdu_Assinante_A { get; set; }
        public string Ama550_Mcdu_Assinante_B { get; set; }
        public string Ama550_Prefixo_A { get; set; }
        public string Ama550_Prefixo_B { get; set; }
        public string Ama550_Cod_Empresa_Assinante_B { get; set; }
        public string Ama550_Tipo_Terminal_A { get; set; }
        public string Ama550_Tipo_Terminal_B { get; set; }
        public string Ama550_Cod_Ocorrencia_ClearTech { get; set; }
        public string Ama550_Status { get; set; }
        public string Ama550_Ind_Tarifacao_Rs { get; set; }
        public string Ama550_Ind_Tarifacao_Re { get; set; }
        public string Ama550_Ind_Empresa_Rota_Rs { get; set; }
        public string Ama550_Ind_Empresa_Rota_Re { get; set; }
        public string Ama550_Ind_Banda_A_B_D_RS { get; set; }
        public string Ama550_Ind_Interconexao_Rs { get; set; }
        public string Ama550_Ind_Interconexao_Re { get; set; }
        public string Ama550_Ind_Cancelamento { get; set; }
        public string Ama550_Ind_Primeira_Chamada { get; set; }
        public string Ama550_Tipo_Programacao { get; set; }
        public string Ama550_Setor_Assinante_B { get; set; }
        public string Ama550_Indicador_Tldn { get; set; }
        public string Ama550_Area_Local_Rota_Saida { get; set; }
        public string Ama550_Eot_Assinante_B { get; set; }
        public string Ama550_Hora_Programada { get; set; }
        public string Ama550_Data_Fim_Programacao { get; set; }
        public string Ama550_Data_Inicio_Programacao { get; set; }
        public string Ama550_Cnl_Anatel_Assinante_B { get; set; }
        public string Ama550_Data_Programacao { get; set; }
        public string Ama550_Setor_Assinante_A { get; set; }
        public string Ama550_Setor_Rota_Entrada { get; set; }
        public string Ama550_Cod_Ddd_Assinante_Tarifado { get; set; }
        public string Ama550_Num_Sequencial { get; set; }
        public string Ama550_Setor_Rota_Saida { get; set; }
        public string Ama550_Cod_Ddd_Assinante_B { get; set; }
        public string Ama550_Cod_Ddd_Assinante_A { get; set; }
        public string Ama550_Data_Fechamento_Arquivo { get; set; }
        public string Ama550_Cod_Empresa_Assinante_A { get; set; }
        public string Ama550_Cod_Uf_Empresa_Rota_Entrada { get; set; }
        public string Ama550_Ind_Banda_A_B_D { get; set; }
        public string Ama550_Ind_Pre_Pago_Assinante_A { get; set; }
        public string Ama550_Flag_Di { get; set; }
        public string Ama550_Flag_Ebt { get; set; }
        public string Ama550_Cod_Tecnologia_Bilhetador { get; set; }
        public string Ama550_Cod_Uf { get; set; }
        public string Ama550_Bl_Sigla_Bilhetador { get; set; }
        public string Ama550_Cod_UF_Assinante_B { get; set; }
        public string Ama550_Cod_UF_Assinante_A { get; set; }
        public string Ama550_Cod_Empresa_Dest_Rota_Saida { get; set; }
        public string Ama550_Cod_Empresa_Orig_Rota_Saida { get; set; }
        public string Ama550_Cod_Empresa_Dest_Rota_Entrada { get; set; }
        public string Ama550_Cod_Empresa_Orig_Rota_Entrada { get; set; }
        public string Ama550_Cod_Loc_Orig_Assinante_B { get; set; }
        public string Ama550_Cod_Loc_Orig_Assinante_A { get; set; }
        public string Ama550_Cod_Loc_Assinante_B { get; set; }
        public string Ama550_Cod_Loc_Assinante_A { get; set; }
        public string Ama550_Cod_Layout { get; set; }
        public string Ama550_Ind_Alteracao_Fatia { get; set; }
        public string Ama550_Ident_Anuncio { get; set; }
        public string Ama550_Eot_Assinante_A { get; set; }
        public string Ama550_Cnl_Anatel_Assinante_A { get; set; }
        public string Ama550_Ident_Bep { get; set; }
        public string Ama550_Area_Local_Rota_Entrada { get; set; }
        public string Ama550_Informacao_Portabilidade { get; set; }
        public string Ama550_Assinante_A_Portabilidade_Tab { get; set; }
        public string Ama550_Setor_Bilhetador { get; set; }
        public string Ama550_Cod_Remessa { get; set; }
        public string Ama550_Ident_Bilhete { get; set; }
        public string Ama550_Ind_Clearing { get; set; }
        public string Ama550_Ocorrencia { get; set; }
        public string Ama550_Carimbo_O { get; set; }
        public string Ama550_Carimbo_S { get; set; }
        public string Ama550_Carimbo_D { get; set; }
        public string Ama550_Carimbo_T { get; set; }
        public string Ama550_Carimbo_B { get; set; }
        public string Ama550_Carimbo_A { get; set; }
        public string Ama550_Carimbo_C { get; set; }
        public string Ama550_Carimbo_P { get; set; }
        public string Ama550_Carimbo_RS { get; set; }
        public string Ama550_Carimbo_Re { get; set; }
        public string Ama550_Ind_Tipo_Chamada_Vpn { get; set; }
        public string Ama550_Assinante_C { get; set; }
        public string Ama550_Csp { get; set; }
        public string Ama550_Ind_Assinante { get; set; }
        public string Ama550_Tipo_Procedimento_Assinante { get; set; }
        public string Ama550_Ind_Erro_Rota { get; set; }
        public string Ama550_Num_Abreviado { get; set; }
        public string Ama550_Estado_Chamada { get; set; }
        public string Ama550_Classe_Tarifa { get; set; }
        public string Ama550_Assinante_B_Portabilidade_Tab { get; set; }
        public string Ama550_Tipo_Bilhetagem { get; set; }
        public string Ama550_Rdsi { get; set; }
        public string Ama550_Confiabilidade_Relogio { get; set; }
        public string Ama550_Cod_Evento { get; set; }
        public string Ama550_Juntor_Saida { get; set; }
        public string Ama550_Rota_Saida { get; set; }
        public string Ama550_Juntor_Entrada { get; set; }
        public string Ama550_Rota_Entrada { get; set; }
        public string Ama550_Tipo_Registro { get; set; }
        public string Ama550_Contador_Saidas_Parciais { get; set; }
        public string Ama550_Causa_Saida { get; set; }
        public string Ama550_Identificador_Central { get; set; }
        public string Ama550_Ind_Liberacao { get; set; }
        public string Ama550_Parte_Tarifada { get; set; }
        public string Ama550_Ind_Atendimento { get; set; }
        public string Ama550_Ind_Localizacao_Desconexao { get; set; }
        public string Ama550_Ind_Causa_Desconexao { get; set; }
        public string Ama550_Fds { get; set; }
        public string Ama550_Classe { get; set; }
        public string Ama550_Ind_Desvio { get; set; }
        public string Ama550_Ind_Chamada_Adicional { get; set; }
        public string Ama550_Duracao { get; set; }
        public string Ama550_Hora_Inicio { get; set; }
        public string Ama550_Data_Inicio { get; set; }
        public string Ama550_Nadi_Assinante_B { get; set; }
        public string Ama550_Assinante_B { get; set; }
        public string Ama550_Categoria { get; set; }
        public string Ama550_Nadi_Assinante_A { get; set; }
        public string Ama550_Assinante_A { get; set; }
        public string CDR_Concatenado { get; set; }

        #endregion

        #region AMA235
        public string Ama235_Codigo_Evento { get; set; }
        public string Ama235_Flag_Portabilidade_A { get; set; }
        public string Ama235_Flag_Portabilidade_B { get; set; }
        public string Ama235_Flag_Portabilidade_C { get; set; }
        public string Ama235_Brancos { get; set; }
        public string Ama235_Numero_Discado { get; set; }
        public string Ama235_Anndl { get; set; }
        public string Ama235_Localidade_Origem { get; set; }
        public string Ama235_Localidade_Destino { get; set; }
        public string Ama235_Localidade_Origem_C { get; set; }
        public string Ama235_Operadora_Origem_A { get; set; }
        public string Ama235_Operadora_Origem_B { get; set; }
        public string Ama235_Operadora_Origem_C { get; set; }
        public string Ama235_Numero_Assinante_A { get; set; }
        public string Ama235_Numero_Assinante_B { get; set; }
        public string Ama235_Numero_Assinante_C { get; set; }
        public string Ama235_Fim_Registro { get; set; }

        #endregion

        #region Ipdr
        public string Ipdr_Tipo_Registro { get; set; }
        public string Ipdr_Tipo_Log { get; set; }
        public string Ipdr_Endereco_Ip_Nas { get; set; }
        public string Ipdr_Codigo_Estacao { get; set; }
        public string Ipdr_Vpdn { get; set; }
        public string Ipdr_Dnis { get; set; }
        public string Ipdr_Localidade_Nas { get; set; }
        public string Ipdr_Localidade_Usuario { get; set; }
        public string Ipdr_Uf_Nas { get; set; }
        public string Ipdr_Nas_Port { get; set; }
        public string Ipdr_Terminal_Origem { get; set; }
        public string Ipdr_Endereco_Ip_Cliente { get; set; }
        public string Ipdr_Identificacao_Usuario { get; set; }
        public string Ipdr_Nome_Usuario { get; set; }
        public string Ipdr_Ident_Cliente { get; set; }
        public string Ipdr_Codigo_Provedor { get; set; }
        public string Ipdr_Sessao { get; set; }
        public DateTime? Ipdr_Data_Inicio_Conexao { get; set; }
        public DateTime? Ipdr_Data_Fim_Conexao { get; set; }
        public string Ipdr_Duracao { get; set; }
        public string Ipdr_Duracao_consolidada { get; set; }
        public string Ipdr_Qte_Octetos_Entrada { get; set; }
        public string Ipdr_Qte_Octetos_Saida { get; set; }
        public string Ipdr_Qte_Pacotes_Entrada { get; set; }
        public string Ipdr_Qte_Pacotes_Saida { get; set; }
        public string Ipdr_Causa_Desconexao { get; set; }
        public string Ipdr_Service_Type { get; set; }
        public string Ipdr_Framed_Protocol { get; set; }
        public string Ipdr_Acct_Delay_Time { get; set; }
        public string Ipdr_NAS_Port_Type { get; set; }
        public string Ipdr_Cisco_NAS_Port { get; set; }
        public string Ipdr_Numero_Remessa { get; set; }
        public string Ipdr_Codigo_ident_RADIUS { get; set; }
        public string Ipdr_Tipo_Remessa { get; set; }
        public string Ipdr_Carimbo_I { get; set; }
        public string Ipdr_Carimbo_IP_Usuario { get; set; }
        public string Ipdr_Carimbo_U { get; set; }
        public string Ipdr_Carimbo_L { get; set; }
        public string Ipdr_Carimbo_Servico { get; set; }
        public string Ipdr_Carimbo_Porta_NAS { get; set; }
        public string Ipdr_Carimbo_Service_Type { get; set; }
        public string Ipdr_Carimbo_Framed_IP_Address { get; set; }
        public string Ipdr_Carimbo_NAS_Port_Type { get; set; }
        public string Ipdr_Carimbo_Cisco_NAS_Port { get; set; }
        public string Ipdr_Carimbo_C { get; set; }
        public string Ipdr_Carimbo_Reserva1 { get; set; }
        public string Ipdr_Carimbo_Reserva2 { get; set; }
        public string Ipdr_Carimbo_Reserva3 { get; set; }
        public string Ipdr_Ocorrencia_Faturamento { get; set; }
        public string Ipdr_Status_Faturamento { get; set; }
        public string Ipdr_Ocorrencia_Clearing { get; set; }
        public string Ipdr_Flag_Clearing { get; set; }
        public string Ipdr_Ident_Bilhete { get; set; }
        public string Ipdr_Ident_Remessa { get; set; }
        public string Ipdr_Cod_Layout { get; set; }
        public string Ipdr_Tipo_de_Produto { get; set; }
        public string Ipdr_Id_Overflow { get; set; }
        public string Ipdr_Qte_Bytes_Consol_Entrada { get; set; }
        public string Ipdr_Qte_Bytes_Consol_Saida { get; set; }
        public string Ipdr_Categoria_Terminal { get; set; }
        public string Ipdr_Numero_Circuito { get; set; }
        public string Ipdr_Velocidade_Circuito { get; set; }
        public string Ipdr_Unidade_Velocidade { get; set; }
        public string Ipdr_Modalidade { get; set; }
        public string Ipdr_Flag_Ajuste_Automatico { get; set; }
        public string Ipdr_Cod_Lit_Loc_Circuito { get; set; }
        public string Ipdr_DSLAM { get; set; }
        public string Ipdr_Nas_Identifier { get; set; }
        public string Ipdr_Franquia { get; set; }
        public string Ipdr_framedIPV6Prefix { get; set; }
        public string Ipdr_DelegatedIPV6Prefix { get; set; }
        #endregion

        #endregion

        #region Construtor

        public ChamadaFixaCompleta()
        {

            Assinante_A = null;
            Assinante_B = null;
            Categoria = null;
            Cod_Empresa_Assinante_A = null;
            Cod_Empresa_Assinante_B = null;
            Cod_Uf_Assinante_A = null;
            Cod_Uf_Assinante_B = null;
            Csp = null;
            Datahora = null;
            Duracao = null;
            Estado_Chamada = null;
            Ind_Atendimento = null;
            Ind_Tipo_Chamada_Vpn = null;
            Indicador_Tldn = null;
            Parte_Tarifada = null;
            Tipo_Terminal_A = null;
            Tipo_Terminal_B = null;

            #region Ama 91
            
            VozAma91_Codigo = null;
            VozAma91_SiglaBil = null;
            VozAma91_DataInicioReferencia = null;
            VozAma91_DataFimReferencia = null;
            VozAma91_HoraInicioReferencia = null;
            VozAma91_HoraFimReferencia = null;
            VozAma91_IdentSequencia = null;
            VozAma91_NumSequencia = null;
            VozAma91_Vago = null;

            VozAma91_COD_REGISTRO = null;
            VozAma91_NUM_ORIGEM = null;
            VozAma91_PARTE_TARIFADA = null;
            VozAma91_CATEGORIA = null;
            VozAma91_NUM_DESTINO = null;
            VozAma91_FIM_SELECAO = null;
            VozAma91_HORA_INICIO = null;
            VozAma91_DURACAO = null;
            VozAma91_DATA_INICIO = null;
            VozAma91_FATIAMENTO = null;
            VozAma91_ROTA_ENTRADA = null;
            VozAma91_JUNTOR_ENTRADA = null;
            VozAma91_ROTA_SAIDA = null;
            VozAma91_JUNTOR_SAIDA = null;
            VozAma91_CLASSE_CHAMADA = null;
            VozAma91_COD_EVENTO = null;
            VozAma91_CONFIABILIDADE = null;
            VozAma91_TIPO_TARIFA = null;
            VozAma91_FILLER = null;
            VozAma91_COD_BIL = null;
            VozAma91_COD_OPER = null;
            VozAma91_ANUF = null;
            VozAma91_FIM_ARQ = null;

            VozAma91_TOTAL_REGISTROS = null;

            #endregion

            #region Ama 80

            VozAma80_Assinante_A = null;
            VozAma80_Parte_Tarifada = null;
            VozAma80_Categoria = null;
            VozAma80_Assinante_B = null;
            VozAma80_Fds = null;
            VozAma80_Hora_Inicio = null;
            VozAma80_Duracao = null;
            VozAma80_Data_Inicio = null;
            VozAma80_Causa_Saida = null;
            VozAma80_Contador_Saidas_Parciais = null;
            VozAma80_Rota_Entrada = null;
            VozAma80_Juntor_Entrada = null;
            VozAma80_Rota_Saida = null;
            VozAma80_Juntor_Saida = null;
            VozAma80_Classe = null;
            VozAma80_Rdsi = null;
            VozAma80_Bl_Sigla_Bilhetador = null;

            #endregion

            #region AMA 128

            VozAma128_Assinante_A = null;
            VozAma128_Nadi_Assinante_A = null;
            VozAma128_Categoria = null;
            VozAma128_Assinante_B = null;
            VozAma128_Nadi_Assinante_B = null;
            VozAma128_Data_Inicio = null;
            VozAma128_Hora_Inicio = null;
            VozAma128_Duracao = null;
            VozAma128_Ind_Chamada_Adicional = null;
            VozAma128_Ind_Desvio = null;
            VozAma128_Classe = null;
            VozAma128_Fds = null;
            VozAma128_Ind_Localizacao_Desconexao = null;
            VozAma128_Ind_Causa_Desconexao = null;
            VozAma128_Ind_Atendimento = null;
            VozAma128_Parte_Tarifada = null;
            VozAma128_Ind_Liberacao = null;
            VozAma128_Identificador_Central = null;
            VozAma128_Causa_Saida = null;
            VozAma128_Contador_Saidas_Parciais = null;
            VozAma128_Tipo_Registro = null;
            VozAma128_Rota_Entrada = null;
            VozAma128_Juntor_Entrada = null;
            VozAma128_Rota_Saida = null;
            VozAma128_Juntor_Saida = null;
            VozAma128_Cod_Evento = null;
            VozAma128_Confiabilidade_Relogio = null;
            VozAma128_Ind_Assinante = null;
            VozAma128_Tipo_Bilhetagem = null;
            VozAma128_Reserva = null;

            #endregion

            #region AMA 111

            VozAma111_Tipo_Reg_Verificacao = null;
            VozAma111_Digito_Verificador = null;
            VozAma111_Tipo_Reg = null;
            VozAma111_Stado_Chamada = null;
            VozAma111_Causa_Saida = null;
            VozAma111_Assinante_A = null;
            VozAma111_Assinante_B = null;
            VozAma111_Categoria = null;
            VozAma111_Fds = null;
            VozAma111_Parte_Tarifada = null;
            VozAma111_Data_Inicio = null;
            VozAma111_Hora_Inicio = null;
            VozAma111_Duracao = null;
            VozAma111_Codigo_Falha = null;
            VozAma111_Ind_Erro_Rota = null;
            VozAma111_Contador_Saidas_Parciais = null;
            VozAma111_Num_Abreviado = null;
            VozAma111_Filler_Rota_Saida = null;
            VozAma111_Rota_Saida = null;
            VozAma111_Juntor_Saida = null;
            VozAma111_Filler_Rota_Entrada = null;
            VozAma111_Rota_Entrada = null;
            VozAma111_Juntor_Entrada = null;
            VozAma111_Ind_Desconexao_Anormal = null;
            VozAma111_Tipo_Procedimento_Assinante = null;
            VozAma111_Ind_Assinante = null;
            VozAma111_Csp = null;
            VozAma111_Assinante_C = null;
            VozAma111_Ind_Tipo_Chamada_Vpn = null;

            #endregion

            #region Ama 550

            //TecnologiaCDR = null;
            //NC = null;
            //NumeroTerminalOrigemEncaminhada = null;
            //TipoRegistro = null;
            //OrigemCDR = null;
            //Aportado = null;
            //Bportado = null;
            //Latitude = null;
            //Longitude = null;
            //NumeroOrigemFormatado = null;
            //NaFormatado = null;
            //NbFormatado = null;
            //NaOuNbFormatado = null;
            //NaOuOrigemFormatado = null;

            Ama550_Area_Tarifaria_A = null;
            Ama550_Area_Tarifaria_B = null;
            Ama550_Flag_Ajuste = null;
            Ama550_Mcdu_Assinante_A = null;
            Ama550_Mcdu_Assinante_B = null;
            Ama550_Prefixo_A = null;
            Ama550_Prefixo_B = null;
            Ama550_Cod_Empresa_Assinante_B = null;
            Ama550_Tipo_Terminal_A = null;
            Ama550_Tipo_Terminal_B = null;
            Ama550_Cod_Ocorrencia_ClearTech = null;
            Ama550_Status = null;
            Ama550_Ind_Tarifacao_Rs = null;
            Ama550_Ind_Tarifacao_Re = null;
            Ama550_Ind_Empresa_Rota_Rs = null;
            Ama550_Ind_Empresa_Rota_Re = null;
            Ama550_Ind_Banda_A_B_D_RS = null;
            Ama550_Ind_Interconexao_Rs = null;
            Ama550_Ind_Interconexao_Re = null;
            Ama550_Ind_Cancelamento = null;
            Ama550_Ind_Primeira_Chamada = null;
            Ama550_Tipo_Programacao = null;
            Ama550_Setor_Assinante_B = null;
            Ama550_Indicador_Tldn = null;
            Ama550_Area_Local_Rota_Saida = null;
            Ama550_Eot_Assinante_B = null;
            Ama550_Hora_Programada = null;
            Ama550_Data_Fim_Programacao = null;
            Ama550_Data_Inicio_Programacao = null;
            Ama550_Cnl_Anatel_Assinante_B = null;
            Ama550_Data_Programacao = null;
            Ama550_Setor_Assinante_A = null;
            Ama550_Setor_Rota_Entrada = null;
            Ama550_Cod_Ddd_Assinante_Tarifado = null;
            Ama550_Num_Sequencial = null;
            Ama550_Cod_Ddd_Assinante_B = null;
            Ama550_Cod_Ddd_Assinante_A = null;
            Ama550_Data_Fechamento_Arquivo = null;
            Ama550_Cod_Empresa_Assinante_A = null;
            Ama550_Cod_Uf_Empresa_Rota_Entrada = null;
            Ama550_Ind_Banda_A_B_D = null;
            Ama550_Ind_Pre_Pago_Assinante_A = null;
            Ama550_Flag_Di = null;
            Ama550_Flag_Ebt = null;
            Ama550_Cod_Tecnologia_Bilhetador = null;
            Ama550_Cod_Uf = null;
            Ama550_Bl_Sigla_Bilhetador = null;
            Ama550_Cod_UF_Assinante_B = null;
            Ama550_Cod_UF_Assinante_A = null;
            Ama550_Cod_Empresa_Dest_Rota_Saida = null;
            Ama550_Cod_Empresa_Orig_Rota_Saida = null;
            Ama550_Cod_Empresa_Dest_Rota_Entrada = null;
            Ama550_Cod_Empresa_Orig_Rota_Entrada = null;
            Ama550_Cod_Loc_Orig_Assinante_B = null;
            Ama550_Cod_Loc_Orig_Assinante_A = null;
            Ama550_Cod_Loc_Assinante_B = null;
            Ama550_Cod_Loc_Assinante_A = null;
            Ama550_Cod_Layout = null;
            Ama550_Ind_Alteracao_Fatia = null;
            Ama550_Ident_Anuncio = null;
            Ama550_Eot_Assinante_A = null;
            Ama550_Cnl_Anatel_Assinante_A = null;
            Ama550_Ident_Bep = null;
            Ama550_Area_Local_Rota_Entrada = null;
            Ama550_Informacao_Portabilidade = null;
            Ama550_Assinante_A_Portabilidade_Tab = null;
            Ama550_Setor_Bilhetador = null;
            Ama550_Cod_Remessa = null;
            Ama550_Ident_Bilhete = null;
            Ama550_Ind_Clearing = null;
            Ama550_Ocorrencia = null;
            Ama550_Carimbo_O = null;
            Ama550_Carimbo_S = null;
            Ama550_Carimbo_D = null;
            Ama550_Carimbo_T = null;
            Ama550_Carimbo_B = null;
            Ama550_Carimbo_A = null;
            Ama550_Carimbo_C = null;
            Ama550_Carimbo_P = null;
            Ama550_Carimbo_RS = null;
            Ama550_Carimbo_Re = null;
            Ama550_Ind_Tipo_Chamada_Vpn = null;
            Ama550_Assinante_C = null;
            Ama550_Ind_Assinante = null;
            Ama550_Tipo_Procedimento_Assinante = null;
            Ama550_Ind_Erro_Rota = null;
            Ama550_Num_Abreviado = null;
            Ama550_Estado_Chamada = null;
            Ama550_Classe_Tarifa = null;
            Ama550_Assinante_B_Portabilidade_Tab = null;
            Ama550_Tipo_Bilhetagem = null;
            Ama550_Rdsi = null;
            Ama550_Confiabilidade_Relogio = null;
            Ama550_Cod_Evento = null;
            Ama550_Juntor_Saida = null;
            Ama550_Rota_Saida = null;
            Ama550_Juntor_Entrada = null;
            Ama550_Rota_Entrada = null;
            Ama550_Tipo_Registro = null;
            Ama550_Contador_Saidas_Parciais = null;
            Ama550_Causa_Saida = null;
            Ama550_Identificador_Central = null;
            Ama550_Ind_Liberacao = null;
            Ama550_Ind_Atendimento = null;
            Ama550_Ind_Localizacao_Desconexao = null;
            Ama550_Ind_Causa_Desconexao = null;
            Ama550_Fds = null;
            Ama550_Classe = null;
            Ama550_Ind_Desvio = null;
            Ama550_Ind_Chamada_Adicional = null;
            Ama550_Duracao = null;
            Ama550_Hora_Inicio = null;
            Ama550_Data_Inicio = null;
            Ama550_Nadi_Assinante_B = null;
            Ama550_Assinante_B = null;
            Ama550_Categoria = null;
            Ama550_Nadi_Assinante_A = null;
            Ama550_Assinante_A = null;

            #endregion

        }

        #endregion

    }
}
