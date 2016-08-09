#region Using

using System;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado
{

    /// <summary>
    /// Classe que representa uma chamada de categoria fixa.
    /// </summary>
    [Serializable]
    public class ChamadaFixa : Chamada
    {

        #region Construtores

        /// <summary>
        /// Construtor da Chamada
        /// </summary>
        /// <param name="pOrigem">Recebe o valor de Origem</param>
        /// <param name="pResponsavelOrigem">Recebe o valor do Responsável da Origem</param>
        /// <param name="pGrupoOrigem">Recebe o valor do Grupo de Origem</param>
        /// <param name="pDestino">Recebe o valor do Destino</param>
        /// <param name="pResponsavelDestino">Recebe o valor do Responsável do Destino</param>
        /// <param name="pGrupoDestino">Recebe o valor do Grupo de Destino</param>
        /// <param name="pData">Recebe o valor da Data</param>
        /// <param name="pDuracao">Recebe o valor da Duração</param>
        /// <param name="pAtendimento">Recebe o valor do Atendimento</param>
        /// <param name="pTipoDeTelefoneOrigem">Recebe o valor do Tipo de Telefone de Origem</param>
        /// <param name="pTipoDeTelefoneDestino">Recebe o valor do Tipo de Telefone de Destino</param>
        /// <param name="pTipoDeTelefone">Recebe o valor do Tipo de Telefone</param>
        /// <param name="pOperadoraOrigem">Recebe o valor da Operadora de Origem</param>
        /// <param name="pOperadoraDestino">Recebe o valor da Operadora de Destino</param>
        /// <param name="pOperadora">Recebe o valor da Operadora</param>
        /// <param name="pTipoDeChamada">Recebe o valor do Tipo de Chamada</param>
        /// <param name="pCsp">Recebe o valor do CSP</param>
        /// <param name="pSentido">Recebe o valor do Sentido</param>
        /// <param name="pPaisOrigem">Recebe o valor do País de Origem</param>
        /// <param name="pPaisDestino">Recebe o valor do País de Destino</param>
        /// <param name="pPais">Recebe o valor do País</param>
        /// <param name="pUfOrigem">Recebe o valor da UF de Origem</param>
        /// <param name="pUfDestino">Recebe o valor da UF de Destino</param>
        /// <param name="pEstado">Recebe o valor do do Estado</param>
        /// <param name="pCidadeOrigem">Recebe o valor da Cidade de Origem</param>
        /// <param name="pCidadeDestino">Recebe o valor da Cidade de Destino</param>
        /// <param name="pCidade">Recebe o valor da Cidade</param>
        public ChamadaFixa(string pOrigem, string pResponsavelOrigem, string pGrupoOrigem, string pDestino, string pResponsavelDestino, string pGrupoDestino, DateTime? pData, int? pDuracao, string pAtendimento, string pTipoDeTelefoneOrigem, string pTipoDeTelefoneDestino, string pTipoDeTelefone, string pOperadoraOrigem, string pOperadoraDestino, string pOperadora, string pTipoDeChamada, string pCsp, Enums.TipoSentido pSentido, string pPaisOrigem, string pPaisDestino, string pPais, string pUfOrigem, string pUfDestino, string pEstado, string pCidadeOrigem, string pCidadeDestino, string pCidade)
        {

            _origem = pOrigem;
            _responsavelOrigem = pResponsavelOrigem;
            _grupoOrigem = pGrupoOrigem;
            _destino = pDestino;
            _responsavelDestino = pResponsavelDestino;
            _grupoDestino = pGrupoDestino;
            _atendimento = pAtendimento;
            _tipoDeTelefoneOrigem = pTipoDeTelefoneOrigem;
            _tipoDeTelefoneDestino = pTipoDeTelefoneDestino;
            _tipoDeTelefone = pTipoDeTelefone;
            _operadoraOrigem = pOperadoraOrigem;
            _operadoraDestino = pOperadoraDestino;
            _operadora = pOperadora;
            _tipoDeChamada = pTipoDeChamada;
            _csp = pCsp;
            _sentido = pSentido;
            _paisOrigem = pPaisOrigem;
            _paisDestino = pPaisDestino;
            _pais = pPais;
            _ufOrigem = pUfOrigem;
            _ufDestino = pUfDestino;
            _estado = pEstado;
            _cidadeOrigem = pCidadeOrigem;
            _cidadeDestino = pCidadeDestino;
            _cidade = pCidade;
        }

        public ChamadaFixa() { }

        #endregion

        #region Propriedades

        public bool Internacional
        {
            get { return _internacional; }
            set { _internacional = value; }
        }
        private bool _internacional;

        public string Indicador
        {
            get { return _indicador; }
            set { _indicador = value; }
        }
        private string _indicador;

        public string Origem
        {
            get { return _origem; }
            set { _origem = value; }
        }
        private string _origem;

        public string ResponsavelOrigem
        {
            get { return _responsavelOrigem; }
            set { _responsavelOrigem = value; }
        }
        private string _responsavelOrigem;

        public string GrupoOrigem
        {
            get { return _grupoOrigem; }
            set { _grupoOrigem = value; }
        }
        private string _grupoOrigem;

        public string Destino
        {
            get { return _destino; }
            set { _destino = value; }
        }
        private string _destino;

        public string ResponsavelDestino
        {
            get { return _responsavelDestino; }
            set { _responsavelDestino = value; }
        }
        private string _responsavelDestino;

        public string GrupoDestino
        {
            get { return _grupoDestino; }
            set { _grupoDestino = value; }
        }
        private string _grupoDestino;


        public string Atendimento
        {
            get { return _atendimento; }
            set { _atendimento = value; }
        }
        private string _atendimento;

        public string TipoDeTelefoneOrigem
        {
            get { return _tipoDeTelefoneOrigem; }
            set { _tipoDeTelefoneOrigem = value; }
        }
        private string _tipoDeTelefoneOrigem;

        public string TipoDeTelefoneDestino
        {
            get { return _tipoDeTelefoneDestino; }
            set { _tipoDeTelefoneDestino = value; }
        }
        private string _tipoDeTelefoneDestino;

        public string TipoDeTelefone
        {
            get { return _tipoDeTelefone; }
            set { _tipoDeTelefone = value; }
        }
        private string _tipoDeTelefone;

        public string OperadoraOrigem
        {
            get { return _operadoraOrigem; }
            set { _operadoraOrigem = value; }
        }
        private string _operadoraOrigem;

        public string OperadoraDestino
        {
            get { return _operadoraDestino; }
            set { _operadoraDestino = value; }
        }
        private string _operadoraDestino;

        public string Operadora
        {
            get { return _operadora; }
            set { _operadora = value; }
        }
        private string _operadora;

        public string TipoDeChamada
        {
            get { return _tipoDeChamada; }
            set { _tipoDeChamada = value; }
        }
        private string _tipoDeChamada;

        public string Csp
        {
            get { return _csp; }
            set { _csp = value; }
        }
        private string _csp;

        public Enums.TipoSentido Sentido
        {
            get { return _sentido; }
            set { _sentido = value; }
        }
        private Enums.TipoSentido _sentido;

        public string PaisOrigem
        {
            get { return _paisOrigem; }
            set { _paisOrigem = value; }
        }
        private string _paisOrigem;

        public string PaisDestino
        {
            get { return _paisDestino; }
            set { _paisDestino = value; }
        }
        private string _paisDestino;

        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }
        private string _pais;

        public string UfOrigem
        {
            get { return _ufOrigem; }
            set { _ufOrigem = value; }
        }
        private string _ufOrigem;

        public string UfDestino
        {
            get { return _ufDestino; }
            set { _ufDestino = value; }
        }
        private string _ufDestino;

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        private string _estado;

        public string CidadeOrigem
        {
            get { return _cidadeOrigem; }
            set { _cidadeOrigem = value; }
        }
        private string _cidadeOrigem;

        public string CidadeDestino
        {
            get { return _cidadeDestino; }
            set { _cidadeDestino = value; }
        }
        private string _cidadeDestino;

        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        private string _cidade;

        private bool _assinanteOperadora;

        public bool AssinanteOperadora
        {
            set { _assinanteOperadora = value; }
            get
            {
                return ValidarEotFixa();
            }
        }

        public string ParteTarifada { get; set; }
        public String Flag_9digito_a { get; set; }
        public String Flag_9digito_b { get; set; }
        public String Flag_9digito_c { get; set; }


        // Novos campos AMA550
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
        public string Ama550_Ind_Assinante { get; set; }
        public string Ama550_Csp { get; set; }
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
        public string Ama550_ParteTarifada { get; set; }
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
        public string Ama550_Flag_Classificacao { get; set; }
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
        public string Ama235_Numero_Assinante_A{ get; set; }
        public string Ama235_Numero_Assinante_B { get; set; }
        public string Ama235_Numero_Assinante_C { get; set; }
        public string Ama235_Fim_Registro { get; set; }
        public string Uf_Bilhetador { get; set; }

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

        public bool EhNumeroWll { get; set; }
        #endregion
        #endregion

        #region Metodos
        public bool ValidarEotFixa()
        {
            var result = false; 
            var numeroEotAssinante = Sentido == TipoSentido.Recebida ? Ama550_Eot_Assinante_A : Ama550_Eot_Assinante_B;

            int eotAssinante;
            int.TryParse(numeroEotAssinante, out eotAssinante);

            if (string.IsNullOrEmpty(numeroEotAssinante) || eotAssinante == 0 || ListaEot().Contains(numeroEotAssinante))
                result = true;

            PertenceBrt = result && ListaEotBRTFixa().Contains(numeroEotAssinante);

            return result;
        }

        public bool ValidarEotBRTFixa()
        {
            var numeroEotAssinante = Sentido == TipoSentido.Recebida ? Ama550_Eot_Assinante_A : Ama550_Eot_Assinante_B;

            return ListaEotBRTFixa().Contains(numeroEotAssinante); ;
        }

        #endregion

    }
}
