#region Using

using System;
using System.Text;
using System.Security.Cryptography;
using System.Web.Security;
using System.Web;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Usuario
{
    [Serializable]
    public class Usuario : MembershipUser, IEnumerableClass
    {

        #region Atributos

        private int? _id;
        private Grupo.Grupo _grupo;
        private Permissao.Permissao _permissao;
        private string _nome;
        private string _email;
        //private Empresa.Empresa _empresa;
        private EnumUser _enumUser;
        private string _senha;
        private string _login;
        private Area.Area _area;
        private bool _excluido;
        private string _idsDosUsuariosFilhos; // Id dos respectivos usuários inferiores (na sequência).
        private string _idsDosGruposFilhos;   // Id dos respectivos grupos inferiores (na sequência).
        private bool _AdminLimiteAreas;
        private bool _bloqueada;



        #endregion

        #region Construtores

        public Usuario() { }

        public Usuario(int? usuarioId)
        {
            Id = usuarioId;
        }

        #endregion

        #region Propriedades

        public bool Bloqueada
        {
            get { return _bloqueada; }
            set { _bloqueada = value; }
        }

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        ////provisorio
        //private List<Grupo.Grupo> _grupos = new List<Grupo.Grupo>();

        ///// <summary>
        ///// Grupos do Usuário.
        ///// </summary>
        //public List<Grupo.Grupo> Grupos { get { return _grupos; } set { _grupos = value; } }

        public int? Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Grupo.Grupo Grupo
        {
            get { return _grupo; }
            set { _grupo = value; }
        }

        public Permissao.Permissao Permissao
        {
            get { return _permissao; }
            set { _permissao = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        //public Empresa.Empresa Empresa
        //{
        //    get { return _empresa; }
        //    set { _empresa = value; }
        //}

        public EnumUser EnumUser
        {
            get { return _enumUser; }
            set { _enumUser = value; }
        }

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        public Area.Area Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public bool Excluido
        {
            get { return _excluido; }
            set { _excluido = value; }
        }

        public bool AdminLimiteAreas
        {
            get { return _AdminLimiteAreas; }
            set { _AdminLimiteAreas = value; }
        }


        public string IdsDosUsuariosFilhos
        {
            get { return _idsDosUsuariosFilhos;}
            set{ _idsDosUsuariosFilhos = value;}
        }

        public string IdsDosGruposFlhos
        {
            get { return _idsDosGruposFilhos; }
            set { _idsDosGruposFilhos = value; }
        }

        public override string ToString()
        {
            return String.Format
                ("ID: {0}, Login: {1}, Nome: {2}, Tipo: {3}, Area: {4}, Grupo: {5}", Id, Login, Nome, EnumUser == 0 ? "Comum" : "Admin", Area ==null? "Sem Area":Area.NomeArea, Grupo == null?"Sem Grupo": Grupo.NomeGrupo);
        }

        public bool HasThisPermission(EnumPermissao enumPermissao)
        {
            if (EnumUser == EnumUser.SuperUser)
            {
                return true;
            }
            //Verifica primeiro se usuário tem permissão. Se obtiver , verifica no grupo dele.
            return Permissao.HasThisPermission(enumPermissao);
        }

        public static void SetReferencia(Usuario usuario)
        {
            HttpContext.Current.Session["usuario"] = usuario;
        }

        public static Usuario GetReferencia()
        {
            return (Usuario)Membership.GetUser(HttpContext.Current.User.Identity.Name);
        }

        public static string GeraMD5(string senha)
        {
            MD5 md = MD5CryptoServiceProvider.Create();
            string md5 = null;
            byte[] hash;
            //Create a new instance of ASCIIEncoding to
            //convert the string into an array of Unicode bytes.  
            ASCIIEncoding enc = new ASCIIEncoding();
            //Convert the string into an array of bytes.  
            byte[] buffer = enc.GetBytes(senha);
            //Create the hash value from the array of bytes.  
            hash = md.ComputeHash(buffer);
            foreach (byte b in hash)
            {
                md5 += b.ToString("x2");
            }
            return md5;
        }
        #region Método de Teste - Popula Usuário Fake
        public static Usuario GetReferenciaFake()
        {
            Usuario usuario = new Usuario
            {
                Email = "anderson.olympio@asgasistemas.com.br",
                Senha = "827ccb0eea8a706c4c34a16891f84e7b",
                Nome = "Olympio",
                EnumUser = EnumUser.SuperUser,
                Id = 1,
                Login = "anderson.olympio",
                Excluido = false
            };

            //Empresa.Empresa company = new Empresa.Empresa { Id = 4, Descricao = "Company 4" };

            Grupo.Grupo grupo = new Grupo.Grupo { CodGrupo = 1, NomeGrupo = "Grupo 1" };//, Empresa = company };

            Area.Area area = new Area.Area { IdArea = 1, NomeArea = "Ações Restritas" };

            usuario.Permissao = Domain.Permissao.Permissao.GetAllPermissions();
            grupo.Permissao = Domain.Permissao.Permissao.GetAllPermissions();
            usuario.Area = area;
            //usuario.Empresa = company;
            usuario.Grupo = grupo;
            return usuario;
        }
        #endregion


        #region IEnumerableClass Members

        public string Key
        {
            get { return _id.ToString(); }
            set { _id = Int32.Parse(value); }
        }

        public string Text
        {
            get { return _nome; }
            set { _nome = value; }
        }

        #endregion

        public string IPUser { get; set; }

        #endregion

    }
}