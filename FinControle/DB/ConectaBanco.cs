using System;
using FirebirdSql.Data.FirebirdClient;

namespace FinControle.DB {
    class ConectaBanco {
        public string CaminhoBanco { get; set; } = @"C:\BancoControle\";
        public string NomeBanco { get; set; } = "Controle.fdb";
        public string CaminhoBancoCompleto { get; private set; } = @"C:\BancoControle\Controle.fdb";
        public string UsuarioBanco { get; private set; } = "SYSDBA";
        public string SenhaBanco { get; private set; } = "masterkey";
        public string ClientLibrary { get; private set; } = @"C:\BancoControle\firebird_server\fbclient.dll";
        public FbCommand QuerySQL { get; set; }
        public FbConnectionStringBuilder Builder { get; set; } = new FbConnectionStringBuilder();
        public FbConnection connection { get; set; }

        public void AbreConexaoBanco() {
            Builder.Database = CaminhoBancoCompleto;
            Builder.Dialect = 3;
            Builder.UserID = UsuarioBanco;
            Builder.Password = SenhaBanco;
            Builder.ServerType = FbServerType.Embedded;
            Builder.ClientLibrary = ClientLibrary;

            connection = new FbConnection(Builder.ConnectionString);

            connection.Open();
        }
    }
}
