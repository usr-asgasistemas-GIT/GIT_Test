using System;
using System.Collections.Generic;
using System.Text;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Sittel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Sittel
{
    [Serializable]
    public class ResultadoRequisicao
    {

        private long codigoOrdemField;

        private long codigoRequisicaoField;

        private object itemField;

        private string indSolicitanteField;

         /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long codigoOrdem
        {
            get
            {
                return this.codigoOrdemField;
            }
            set
            {
                this.codigoOrdemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long codigoRequisicao
        {
            get
            {
                return this.codigoRequisicaoField;
            }
            set
            {
                this.codigoRequisicaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resultadoNegativo", typeof(ResultadoNegativo), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("resultadoPositivo", typeof(ResultadoPositivo), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ind_solicitante
        {
            get
            {
                return this.indSolicitanteField;
            }
            set
            {
                this.indSolicitanteField = value;
            }
        }
        
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://sittel.gov.br/schemas/sittel-dados-comuns-1.0")]
    public partial class ResultadoNegativo
    {

        private int tipoField;

        private string justificativaField;

        private byte[] anexoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string justificativa
        {
            get
            {
                return this.justificativaField;
            }
            set
            {
                this.justificativaField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
         [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
        public byte[] anexo
        {
            get
            {
                return this.anexoField;
            }
            set
            {
                this.anexoField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://sittel.gov.br/schemas/sittel-dados-comuns-1.0")]
    public partial class ResultadoPositivo
    {

        private string tipoField;

        private ArquivoResultado[] arquivosField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("arquivo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public ArquivoResultado[] arquivos
        {
            get
            {
                return this.arquivosField;
            }
            set
            {
                this.arquivosField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://sittel.gov.br/schemas/sittel-dados-comuns-1.0")]
    public partial class ArquivoResultado
    {

        private ArquivoSittel nomeField;

        private byte[] xmlField;

        private string hashField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ArquivoSittel nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
        public byte[] xml
        {
            get
            {
                return this.xmlField;
            }
            set
            {
                this.xmlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string hash
        {
            get
            {
                return this.hashField;
            }
            set
            {
                this.hashField = value;
            }
        }
    }
}
