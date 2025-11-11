using MySql.Data.MySqlClient;
using ProjetoCrud2B.Models;
using System.Data;

namespace ProjetoCrud2B.Repositorio
{
    public class UsuarioRepositorio(IConfiguration configuration)
    {
        //declarando variavel somente de leitura para receber a string de conexão
        private readonly string _conexaoMySql = configuration.GetConnectionString("ConexaoMySql");


        public Usuario ObterUsuario(string email)
        {
            using (var conexao = new MySqlConnection(_conexaoMySql))
            {
                conexao.Open();

                MySqlCommand cmd = new("SELECT * FROM Usuario WHERE Email =@email ", conexao);
                cmd.Parameters.Add("email", MySqlDbType.VarChar).Value = email;

                using (MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    //iniciliza uma variavel
                    Usuario usuario = null;

                    if (dr.Read())
                    {
                        usuario = new Usuario
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Nome = dr["Nome"].ToString(),
                            Email = dr["Email"].ToString(),
                            Senha = dr["Senha"].ToString()

                        };
                    }
                    return usuario;

                }

            }

        }
    }
}
