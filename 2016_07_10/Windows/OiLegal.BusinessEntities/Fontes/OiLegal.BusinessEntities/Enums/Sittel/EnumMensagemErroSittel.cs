using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Sittel
{
    public enum EnumMensagemErroSittel
    {
        Código_da_ordem_inválido,
        Data_inválida,
        Hora_inválida,
        Email_inválido,
        Quantidade_de_requisições_inválida,
        Falta_anexo_com_a_Decisão_Judicial,
        Código_da_ordem_inexistente,
        Ausência_do_parâmetro_para_pesquisa,
        CPF_inválido,
        CNPJ_inválido,
        Falta_ou_excesso_de_dígitos,
        Alvo_não_pertence_à_Operadora,
        Período_indisponível,
        IP_inválido,
        Arquivos_esperados_não_indicados
    }

}