using System.Collections.Generic;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.ERB
{
    /// <summary>
    /// O intuito dessa entidade é manter uma lista associativa entre CN e UF, atualizada pela tabela da Anatel em 20/nov/2009.
    /// </summary>
    public class CodigoAreaUf
    {
        public readonly Dictionary<byte, string> ListaCodigoAreaUf = new Dictionary<byte, string>();

        public CodigoAreaUf()
        {
            ListaCodigoAreaUf.Add(68, "AC");
            ListaCodigoAreaUf.Add(82, "AL");
            ListaCodigoAreaUf.Add(92, "AM");
            ListaCodigoAreaUf.Add(97, "AM");
            ListaCodigoAreaUf.Add(96, "AP");
            ListaCodigoAreaUf.Add(71, "BA");
            ListaCodigoAreaUf.Add(73, "BA");
            ListaCodigoAreaUf.Add(74, "BA");
            ListaCodigoAreaUf.Add(75, "BA");
            ListaCodigoAreaUf.Add(77, "BA");
            ListaCodigoAreaUf.Add(61, "DF");
            ListaCodigoAreaUf.Add(27, "ES");
            ListaCodigoAreaUf.Add(28, "ES");
            ListaCodigoAreaUf.Add(62, "GO");
            ListaCodigoAreaUf.Add(64, "GO");
            ListaCodigoAreaUf.Add(98, "MA");
            ListaCodigoAreaUf.Add(99, "MA");
            ListaCodigoAreaUf.Add(31, "MG");
            ListaCodigoAreaUf.Add(32, "MG");
            ListaCodigoAreaUf.Add(33, "MG");
            ListaCodigoAreaUf.Add(34, "MG");
            ListaCodigoAreaUf.Add(35, "MG");
            ListaCodigoAreaUf.Add(37, "MG");
            ListaCodigoAreaUf.Add(38, "MG");
            ListaCodigoAreaUf.Add(67, "MS");
            ListaCodigoAreaUf.Add(65, "MT");
            ListaCodigoAreaUf.Add(66, "MT");
            ListaCodigoAreaUf.Add(91, "PA");
            ListaCodigoAreaUf.Add(93, "PA");
            ListaCodigoAreaUf.Add(94, "PA");
            ListaCodigoAreaUf.Add(83, "PB");
            ListaCodigoAreaUf.Add(81, "PE");
            ListaCodigoAreaUf.Add(87, "PE");
            ListaCodigoAreaUf.Add(86, "PI");
            ListaCodigoAreaUf.Add(89, "PI");
            ListaCodigoAreaUf.Add(41, "PR");
            ListaCodigoAreaUf.Add(42, "PR");
            ListaCodigoAreaUf.Add(43, "PR");
            ListaCodigoAreaUf.Add(44, "PR");
            ListaCodigoAreaUf.Add(46, "PR");
            ListaCodigoAreaUf.Add(21, "RJ");
            ListaCodigoAreaUf.Add(22, "RJ");
            ListaCodigoAreaUf.Add(24, "RJ");
            ListaCodigoAreaUf.Add(84, "RN");
            ListaCodigoAreaUf.Add(69, "RO");
            ListaCodigoAreaUf.Add(95, "RR");
            ListaCodigoAreaUf.Add(51, "RS");
            ListaCodigoAreaUf.Add(53, "RS");
            ListaCodigoAreaUf.Add(54, "RS");
            ListaCodigoAreaUf.Add(55, "RS");
            ListaCodigoAreaUf.Add(47, "SC");
            ListaCodigoAreaUf.Add(48, "SC");
            ListaCodigoAreaUf.Add(49, "SC");
            ListaCodigoAreaUf.Add(79, "SE");
            ListaCodigoAreaUf.Add(11, "SP");
            ListaCodigoAreaUf.Add(12, "SP");
            ListaCodigoAreaUf.Add(13, "SP");
            ListaCodigoAreaUf.Add(14, "SP");
            ListaCodigoAreaUf.Add(15, "SP");
            ListaCodigoAreaUf.Add(16, "SP");
            ListaCodigoAreaUf.Add(17, "SP");
            ListaCodigoAreaUf.Add(18, "SP");
            ListaCodigoAreaUf.Add(19, "SP");
            ListaCodigoAreaUf.Add(63, "TO");
            ListaCodigoAreaUf.Add(85, "CE");
            ListaCodigoAreaUf.Add(88, "CE");
        }

        public byte CodigoArea { get; set; }
        public string Uf { get; set; }

    }
}