using System.Data;
using Main.BLL.Modules.Config;
using Npgsql;

namespace Main.BLL.Modules.DB
{
    public class MDB
    {
        private static MDB instance;

        private readonly IDbConnection connection;

        public static MDB Get() {
            instance = instance ?? new MDB();
            return instance;
        }

        private MDB() {
            connection = new NpgsqlConnection(MConfig.Get().GetDbConnectionString());
            connection.Open();
        }

        public IDbConnection Connection() => connection;
    }
}