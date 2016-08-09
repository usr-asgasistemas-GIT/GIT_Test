using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    public class RequisicaoSittel
    {

        #region Properties        
        public int Codigo_Requisicao { get; set; }
        public int Codigo_Ordem { get; set; }
        public string Ind_Solicitante { get; set; }
        public string Versao { get; set; }
        public string Tipo_Investigado { get; set; }
        public string Operacao_Policial { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string Documento_Assinante { get; set; }
        public string Nome_Assinante { get; set; }
        public string Numero_Terminal_Assinante { get; set; }
        public string Imei { get; set; }
        public string Cgi_Erb { get; set; }
        public string Endereco_Erb { get; set; }
        public string Latitude_Investigada { get; set; }
        public string Longitude_Investigada { get; set; }
        public DateTime Inicio_Periodo { get; set; }
        public DateTime Fim_Periodo { get; set; }
        public string Endereco_IP { get; set; }
        public int Porta_IP { get; set; }
        public int Tipo_Servico { get; set; }
        public string Direcao { get; set; }
        public bool Dados_Cadastrais_Interloc { get; set; }
        public int Lista_Arquivos { get; set; }
        public string Observacao { get; set; }
        public string Status { get; set; }
        public int Codigo_Erro { get; set; }
        public string Descricao_Erro { get; set; }
        public int Codigo_Tipo_Rejeicao { get; set; }
        public DateTime Data_Recebimento { get; set; }
        public DateTime Data_Resposta { get; set; }
        public DateTime Data_Conclusao { get; set; }
        public int Tipo_Requisicao { get; set; }
        public int Id_Usuario { get; set; }
        public string Justificativa_Rejeicao { get; set; }
        public DateTime Data_Rejeicao { get; set; }
        public int Tipo_Conteudo { get; set; }
        public string Alvo { get; set; }
        public string Alvo_Valor { get; set; }
        public string Tipo_Interceptacao { get; set; }
        public int Duracao_Interceptacao { get; set; }
        public string Desvio_Conteudo { get; set; }
        public string Desvio_Conteudo_Valor { get; set; }
        public int Autorizacao_Adicional { get; set; }
        public int Tipo_Requisicao_Agrupada { get; set; }
        public DateTime Data_Recepcao_Recibo { get; set; }
        #endregion

    }
}
