using Dapper;
using Oracle.ManagedDataAccess.Client;
using Transaction.repository.Interface;

namespace Transaction.repository.Repository
{
    public class SqlRepository : ISqlRepository
    {
        private readonly string _connectionString;
        public SqlRepository()
        {
            _connectionString = util.Method.GetStringConn();
        }

        public List<T> GetAll<T>(string command, object parms)
        {
            using var connection = new OracleConnection(_connectionString);
            return (connection.Query<T>(command, parms)).ToList();
        }

        public T GetById<T>(string command, string id)
        {
            using var connection = new OracleConnection(_connectionString);
            return (connection.QuerySingleOrDefault<T>(command, new { Id = id }));
        }

        public int Insert(string command, object parms)
        {
            using var connection = new OracleConnection(_connectionString);
            return connection.Execute(command, parms);
        }

        public int Update(string command, object parms)
        {
            using var connection = new OracleConnection(_connectionString);
            return connection.Execute(command, parms);
        }

        public int Delete(string command, string id)
        {
            using var connection = new OracleConnection(_connectionString);
            return connection.Execute(command, new { Id = id });
        }
    }
}
