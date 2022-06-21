using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace FinControle.DB {
    class UsuarioConectado {
        public static int IdUsuario { get; set; }
        public static string Nome { get; set; }
        public static string DicaSenha { get; set; }
        public static int Idade { get; set; }

        public static ConectaBanco conectaBanco { get; private set; } = new ConectaBanco();
        public static DBClassePrincipal classePrincipal { get; set; } = new DBClassePrincipal();

        public UsuarioConectado() { }

        public static void ResgataInfoUsuario(int id, string senha) {
            classePrincipal.VerificaBanco();
            conectaBanco.AbreConexaoBanco();

            conectaBanco.QuerySQL = new FbCommand($"SELECT * FROM Usuarios WHERE id_usuario = {id} AND senha = '{senha}'", conectaBanco.connection);

            conectaBanco.QuerySQL.CommandType = CommandType.Text;

            FbDataReader reader = conectaBanco.QuerySQL.ExecuteReader();

            while (reader.Read()) {
                IdUsuario = reader.GetInt32(0);
                Nome = reader.GetString(1);
                Idade = reader.GetInt32(2);
                DicaSenha = reader.GetString(4);
            }
        }
    }
}
